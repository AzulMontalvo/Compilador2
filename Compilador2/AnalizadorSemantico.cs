using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compilador2
{
    internal class AnalizadorSemantico
    {
        private TablaSimbolos tablaSimbolos;

        public List<string> Errores { get; private set; } = new List<string>();

        public AnalizadorSemantico(TablaSimbolos tablaSimbolos)
        {
            this.tablaSimbolos = tablaSimbolos;
        }

        public void Analizar(NodoPrograma programa)
        {
            Errores.Clear();

            foreach (var nodo in programa.Declaraciones)
            {
                try
                {
                    AnalizarNodo(nodo);
                }
                catch (Exception ex)
                {
                    Errores.Add(ex.Message);
                }
            }
        }

        private void AnalizarNodo(NodoAST nodo)
        {
            if (nodo is NodoDeclaracionVariable declaracion)
            {
                // Verificar si la variable ya está declarada
                if (tablaSimbolos.EsDeclarada(declaracion.Identificador))
                {
                    throw new Exception($"Error: La variable '{declaracion.Identificador}' ya ha sido declarada.");
                }

                // Agregar la variable a la tabla de símbolos
                tablaSimbolos.AgregarSimbolo(declaracion.Identificador, declaracion.Tipo);
            }
            else if (nodo is NodoOperacion operacion)
            {
                var tipoIzquierda = ObtenerTipo(operacion.Izquierda);
                var tipoDerecha = ObtenerTipo(operacion.Derecha);

                if (tipoIzquierda != tipoDerecha)
                {
                    throw new Exception($"Error de tipo: no se pueden operar {tipoIzquierda} y {tipoDerecha}.");
                }
            }
            // Analizar otros tipos de nodos según sea necesario
        }

        private string ObtenerTipo(NodoAST nodo)
        {
            if (nodo is NodoLiteral nodoLiteral)
            {
                return nodoLiteral.Valor is int ? "NUM-NUM" : "TIKI";
            }
            else if (nodo is NodoIdentificador nodoIdentificador)
            {
                return tablaSimbolos.ObtenerTipo(nodoIdentificador.Nombre);
            }

            throw new Exception("Error: Tipo desconocido.");
        }
    }
}
