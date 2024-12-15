using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Compilador2
{
    internal class Lexer
    {
        private static readonly List<(string Name, string Pattern)> TokenDefinitions = new List<(string Name, string Pattern)>
    {
        ("OperadorSuma", @"\bBAM\b"),
        ("OperadorResta", @"\bPUM\b"),
        ("OperadorMultiplica", @"\bBOOM\b"),
        ("Declaracion", @"\bKABOOM\b"),
        ("OperadorDivide", @"\bZAP\b"),
        ("TipoDato", @"\bNUM-NUM\b"),
        ("TipoDato", @"\bTIKI\b"),
        ("Asignacion", @"\bTA-DA\b"),
        ("Iniciar", @"\bALOHA\b"),
        ("FinPrograma", @"\bBING\b"),
        ("TerminaInstruccion", @"\bPLOP\b"),
        ("Identificador", @"[a-zA-Z_][a-zA-Z0-9_]*"),
        ("Numero", @"\d+"),
        ("Cadena", "\".*?\""),
        ("Espacios", @"\s+")
        //("FinInstruccion", @"\bBING\b"),
        //("While", @"\bLOOP\b"),
        //("Condicion", @"[<>=]"),
    };

        public List<(string TokenName, string TokenValue)> Tokenize(string input)
        {
            var tokens = new List<(string, string)>();
            int position = 0;

            while (position < input.Length)
            {
                bool match = false;

                foreach (var (name, pattern) in TokenDefinitions)
                {
                    var regex = new Regex($"^{pattern}");
                    var matchResult = regex.Match(input.Substring(position));

                    if (matchResult.Success)
                    {
                        if (name != "Espacios") // Ignorar espacios
                            tokens.Add((name, matchResult.Value));

                        position += matchResult.Length;
                        match = true;
                        break;
                    }
                }

                if (!match)
                    throw new Exception($"Token no reconocido en posición {position}: '{input[position]}'");
            }

            return tokens;
        }
    }
}

