using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Compilador2
{
    public partial class Compilador : Form
    {
        public Compilador()
        {
            InitializeComponent();

        }
        private void btnAnalyze_Click(object sender, EventArgs e)
        {
            // Limpiar el TextBox de salida antes de mostrar los nuevos tokens
            txtBoxOutputL.Clear();
            txtBoxOutputSint.Clear();
            txtBoxOutputSem.Clear();
            txtBoxCI.Clear();
            try
            {
                // Obtener el texto de entrada desde el TxtBoxInput
                string inputCode = txtBoxInput.Text;
                //Análisis léxico
                // Crear una instancia del lexer
                Lexer lexer = new Lexer();
                // Tokenizar el texto de entrada
                var tokens = lexer.Tokenize(inputCode);

                // Mostrar los tokens generados en el TextBox de salida
                txtBoxOutputL.AppendText("Tokens generados:\r\n");
                foreach (var token in tokens)
                {
                    // Mostrar cada token en una nueva línea del TextBox
                    txtBoxOutputL.AppendText($"Token: {token.TokenName}, Valor: {token.TokenValue}\r\n");
                }
                
                //Análisis sintáctico
                // Crear una instancia del parser y realizar el análisis sintáctico
                Parser parser = new Parser(tokens);
                var programa = parser.Parse();
                var resultadoSintactico = parser.Parse();

                // Mostrar el resultado del análisis sintáctico
                txtBoxOutputSint.AppendText("Análisis sintáctico completado correctamente.\r\n");

                //Análisis semántico
                //Crear una nueva tabla de símbolos

                var tablaSimbolos = new TablaSimbolos();
                var analizadorSemantico = new AnalizadorSemantico(tablaSimbolos);

                analizadorSemantico.Analizar(programa);

                if (analizadorSemantico.Errores.Count > 0)
                {
                    txtBoxOutputSem.Text = string.Join(Environment.NewLine, analizadorSemantico.Errores);
                }
                else
                {
                    txtBoxOutputSem.Text = "Análisis semántico realizado correctamente.";
                }
                /*var analizadorSemantico = new AnalizadorSemantico();
                analizadorSemantico.Validar(programa);*/

                //Generación de código intermedio
                var generador = new GeneradorCI();
                generador.Generar(programa);
                txtBoxCI.Text = string.Join(Environment.NewLine, generador.CodigoIntermedio);
            }
            catch (Exception ex)
            {
                // En caso de error, mostrar el mensaje de error
                txtBoxOutputSint.AppendText("Error: " + ex.Message + "\r\n");
            }
        }

        private void txtBoxCI_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

