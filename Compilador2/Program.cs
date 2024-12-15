using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Compilador2
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Compilador());
            /*string code = @"
            KABOOM myVar NUM-NUM 42 PLOP
            BAM 10 PLOP
            ";

            Lexer lexer = new Lexer();
            var tokens = lexer.Tokenize(code);

            foreach (var token in tokens)
            {
                Console.WriteLine($"Token: {token.TokenName}, Valor: {token.TokenValue}");
            }*/

        }
        
    }
}
