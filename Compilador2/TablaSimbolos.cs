using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compilador2
{
    internal class TablaSimbolos
    {
        //Para el análisis semántico
        private Dictionary<string, string> simbolos;

        public TablaSimbolos()
        {
            simbolos = new Dictionary<string, string>();
        }

        public void AgregarSimbolo(string nombre, string tipo)
        {
            if (simbolos.ContainsKey(nombre))
            {
                throw new Exception($"La variable '{nombre}' ya ha sido declarada.");
            }
            simbolos[nombre] = tipo;
        }

        public string ObtenerTipo(string nombre)
        {
            if (!simbolos.ContainsKey(nombre))
            {
                throw new Exception($"La variable '{nombre}' no está declarada.");
            }
            return simbolos[nombre];
        }

        public bool EsDeclarada(string nombre)
        {
            return simbolos.ContainsKey(nombre);
        }
    }
}
