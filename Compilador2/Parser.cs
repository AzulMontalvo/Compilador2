using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Compilador2
{
    internal class Parser
    {
        private List<(string TokenName, string TokenValue)> tokens;
        private int posicion;
        //private TablaSimbolos tablaSimbolos;

        public Parser(List<(string TokenName, string TokenValue)> tokens)
        {
            this.tokens = tokens;
            this.posicion = 0;
            //this.tablaSimbolos = new TablaSimbolos();
        }

        private (string TokenName, string TokenValue) CurrentToken =>
       posicion < tokens.Count ? tokens[posicion] : ("EOF", "");

        // Método principal
        public NodoPrograma Parse()
        {
            var programa = new NodoPrograma();
            
            
            
            // Procesamos las declaraciones y expresiones
            while (!EsFin())
            {
                programa.Declaraciones.Add(ParseInicio());
                programa.Declaraciones.Add(ParseDeclaracion());
            }
            return programa;
        }

        private NodoAST ParseInicio()
        {
            if (MiraToken("Iniciar"))
            {
                return ParseInicioBloqueCodigo();
            }
            else
            {
                return ParseDeclaracion();
            }


            throw new Exception("Error: Se esperaba ALOHA al inicio del programa");
        }

        // Parseo de declaraciones
        private NodoAST ParseDeclaracion()
        {
            if (MiraToken("Declaracion"))
            {
                return ParseDeclaracionVariable();
            }

            // Si no es una declaración de variable, asumir que es una expresión
            if (MiraToken("Identificador") || MiraToken("Numero"))
            {
                return ParseExpresion();
            }
            /*else if (MiraToken("FinPrograma")) //Para aceptar BING como termino del programa
            {
                Consume("FinPrograma");
            }*/

            
            //return ParseExpresion();

            throw new Exception("Error: Error de declaración de token.");
        }

        private NodoInicio ParseInicioBloqueCodigo()
        {
            string iniciaPrograma = Consume("Iniciar").TokenValue;
            return new NodoInicio
            {
                IniciarPrograma = iniciaPrograma
            };

        }

        private NodoDeclaracionVariable ParseDeclaracionVariable()
        {
            Consume("Declaracion");
            string identificador = Consume("Identificador").TokenValue;

            // Tipo de dato (NUM-NUM o TIKI)
            string tipoDato = Consume("TipoDato").TokenValue;

            // Operador de asignación
            Consume("Asignacion");

            // Valor de la variable
            NodoAST valor = tipoDato == "NUM-NUM"
                ? (NodoAST)new NodoLiteral { Valor = int.Parse(Consume("Numero").TokenValue) }
                : new NodoLiteral { Valor = Consume("Cadena").TokenValue };

            // Terminador de instrucción
            Consume("TerminaInstruccion");

            // Crear y devolver la declaración de variable
            return new NodoDeclaracionVariable
            {
                Identificador = identificador,
                Tipo = tipoDato,  // Almacenar el tipo de dato
                Valor = valor
            };
        }

        // Parseo de expresiones
        private NodoAST ParseExpresion()
        {
            var izquierda = ParseTermino();

            while (MiraToken("OperadorSuma") || MiraToken("OperadorResta") ||
                   MiraToken("OperadorMultiplica") || MiraToken("OperadorDivide"))
            {
                string operador = ConsumeActual().TokenValue;
                var derecha = ParseTermino();

                izquierda = new NodoOperacion
                {
                    Izquierda = izquierda,
                    Operador = operador,
                    Derecha = derecha
                };
            }
            if (MiraToken("PLOP"))
            {
                var nodoPlop = new NodoInstruccion();
            }
            Consume("TerminaInstruccion");
            return izquierda;
        }

        /*private NodoAST ParseWhile()
        {
            Consume("While");
            var izquierda = ParseExpresion();
            var operador = Consume("Condicion").TokenValue; // Operador de la condición
            var derecha = ParseExpresion();
            var instrucciones = new List<NodoAST>();
            Consume("TerminaInstruccion"); // Consume BING

            return new NodoWhile
            {
                Izquierda = izquierda,
                Operador = operador,
                Derecha = derecha,
                Instrucciones = instrucciones
            };
        }*/

        private NodoAST ParseTermino()
        {
            if (MiraToken("Identificador"))
            {
                string nombre = Consume("Identificador").TokenValue;

                // Verificar que la variable esté declarada
                /*if (!tablaSimbolos.EsDeclarada(nombre))
                {
                    throw new Exception($"Error: La variable '{nombre}' no está declarada.");
                }*/

                return new NodoIdentificador { Nombre = nombre };
            }
            if (MiraToken("Numero"))
            {
                return new NodoLiteral { Valor = int.Parse(Consume("Numero").TokenValue) };
            }
            else if (MiraToken("Cadena"))
            {
                return new NodoLiteral { Valor = Consume("Cadena").TokenValue };
            }
            else if (MiraToken("Identificador"))
            {
                return new NodoIdentificador { Nombre = Consume("Identificador").TokenValue };
            }

            throw new Exception("Error: Término inválido de la expresión");
        }

        private void ParseBing()
        {
            if (MiraToken("BING"))
            {
                Consume("BING"); // Consumimos BING para confirmar el fin del código
            }
            else
            {
                throw new Exception("Error: El código debe terminar con 'BING'.");
            }

            // Verificamos que no haya más código después de BING
            if (MiraToken("Identificador") || MiraToken("Numero") || MiraToken("KABOOM") || MiraToken("TA-DA") || MiraToken("PLOP"))
            {
                throw new Exception("Error: No debe haber código después de 'BING'.");
            }
        }

            // Métodos auxiliares
            private (string TokenName, string TokenValue) Consume(string esperado = null)
        {
            if (EsFin())
                throw new Exception($"Se esperaba '{esperado}', pero se encontró el final de la entrada.");

            var token = tokens[posicion];
            if (esperado != null && token.TokenName != esperado)
                throw new Exception($"Error en el análisis sintáctico: Se esperaba un token de tipo '{esperado}' pero se encontró '{token.TokenName}' (valor: {token.TokenValue}).");

            posicion++;
            return token;
        }

        private (string TokenName, string TokenValue) ConsumeActual()
        {
            return Consume();
        }

        private bool MiraToken(string esperado)
        {
            if (EsFin()) return false;
            return tokens[posicion].TokenName == esperado;
        }

        private bool EsFin()
        {
            return posicion >= tokens.Count;
        }
    }
}
