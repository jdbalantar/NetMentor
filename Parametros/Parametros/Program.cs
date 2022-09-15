using System;

namespace Parametros
{
    //Parámetros por referencia
    internal class Program
    {
        static void Main(string[] args)
        {
            int valorActual = 10;
            Console.WriteLine($"Valor antes de ser modificado: {valorActual}");
            ActualizarRef(ref valorActual);
            Console.WriteLine($"Valor luego de modificarse: {valorActual}");

            int valorActual2;
            ActualizarOut(out valorActual2);
            Console.WriteLine($"El valor es {valorActual2}");

            ObjEjemplo ejemploValor = new ObjEjemplo(10);
            ActualizarObj(ejemploValor);
            Console.WriteLine($"El valor es {ejemploValor.Entero}");
            
            

            Console.ReadKey();
        }



        public static void ActualizarObj(ObjEjemplo obj)
        {
            obj.Entero = 25;
        }

        /// <summary>
        /// Se usa para poder instanciar el valor de una variable;
        /// </summary>
        /// <param name="valor"></param>
        private static void ActualizarOut(out int valor)
        {
            valor = 13;
        }

        /// <summary>
        /// Método para cambiar el valor de una variable pasada por referencia (Direccion
        /// de memoria)
        /// </summary>
        /// <param name="valor"></param>
        private static void ActualizarRef(ref int valor)
        {
            valor += 5;
        }
    }

    public class ObjEjemplo
    {
        public int Entero { get; set; }

        public ObjEjemplo(int entero)
        {
            Entero = entero;
        }
    }
}
