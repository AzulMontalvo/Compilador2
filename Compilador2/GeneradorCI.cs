using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compilador2
{
    internal class GeneradorCI
    {
        private int tempCount = 0; // Para crear nombres de variables temporales
        public List<string> CodigoIntermedio { get; private set; } = new List<string>();

        private Dictionary<string, string> operadores = new Dictionary<string, string>
        {
            { "BAM", "+" },  // Operador suma
            { "PUM", "-" }, // Operador resta
            { "BOOM", "*" }, // Operador multiplicación
            { "ZAP", "/" }, // Operador de división
            { "PLOP", ";" } //Termino de instrucción
        };

        public void Generar(NodoPrograma programa)
        {
            CodigoIntermedio.Clear();
            CodigoIntermedio.Add("{");
            foreach (var nodo in programa.Declaraciones)
            {
                
                ProcesarNodo(nodo);
                
            }
            CodigoIntermedio.Add("}");
        }

        private void ProcesarNodo(NodoAST nodo)
        {
            if (nodo is NodoDeclaracionVariable declaracion)
            {
                // Asignación directa
                var resultado = ProcesarExpresion(declaracion.Valor);
                
                CodigoIntermedio.Add($"{declaracion.Identificador} = {resultado};");
                
            }
            else if (nodo is NodoOperacion operacion)
            {
                ProcesarExpresion(operacion);
            }
        }

        private string ProcesarExpresion(NodoAST nodo)
        {
            if (nodo is NodoLiteral literal)
            {
                return literal.Valor.ToString(); // Devuelve el valor literal
            }
            else if (nodo is NodoIdentificador identificador)
            {
                return identificador.Nombre; // Devuelve el nombre de la variable
            }
            else if (nodo is NodoOperacion operacion)
            {
                var izq = ProcesarExpresion(operacion.Izquierda);
                var der = ProcesarExpresion(operacion.Derecha);

                string operadorIntermedio = ObtenerOperadorIntermedio(operacion.Operador);

                // Generar un temporal para almacenar el resultado
                string temporal = GenerarTemporal();
                CodigoIntermedio.Add($"{temporal} = {izq} {operadorIntermedio} {der};");
                return temporal;
            }

            throw new Exception("Tipo de nodo no soportado en la generación de código intermedio.");
        }

        private string ObtenerOperadorIntermedio(string operador)
        {
            // Si el operador no se encuentra en el diccionario, lanzamos un error
            if (!operadores.ContainsKey(operador))
            {
                throw new Exception($"Operador desconocido: {operador}");
            }

            return operadores[operador];
        }

        private string GenerarTemporal()
        {
            return $"t{tempCount++}";
        }
    }
}
