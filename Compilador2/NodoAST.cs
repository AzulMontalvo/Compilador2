using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compilador2
{
    //define las propiedades y comportamientos comunes de sus clases derivadas, pero no puede ser instanciada directamente.
    public abstract class NodoAST { }

    public class NodoPrograma : NodoAST
    {
        public List<NodoAST> Declaraciones { get; set; } = new List<NodoAST>();
    }

    public class NodoInicio : NodoAST
    {
        public string IniciarPrograma { get; set; } 
    }

    public class NodoDeclaracionVariable : NodoAST
    {
        public string Identificador { get; set; }
        public string Tipo { get; set; }
        public NodoAST Valor { get; set; }

        //Temporal
        //public string Termino { get; set; }

        //public string TerminaInstruccion { get; set; }

    }

    public class NodoOperacion : NodoAST
    {
        public NodoAST Izquierda { get; set; }
        public string Operador { get; set; }
        public NodoAST Derecha { get; set; }
        //public string TerminaInstruccion { get; set; }
    }
    /*public class NodoWhile : NodoAST
    {
        public NodoAST Izquierda { get; set; }
        public string Operador { get; set; }
        public NodoAST Derecha { get; set; }
        public List<NodoAST> Instrucciones { get; set; } = new List<NodoAST>();
    }*/

    public class NodoLiteral : NodoAST
    {
        public object Valor { get; set; }
    }

    public class NodoIdentificador : NodoAST
    {
        public string Nombre { get; set; }
    }

    public class NodoInstruccion : NodoAST
    {
        public string Instruccion { get; set; }

        /*public NodoInstruccion(string instruccion)
        {
            Instruccion = instruccion;
        }*/
    }

    public class NodoFinal : NodoAST
    {
        public string Final    { get; set; }
    }


}
