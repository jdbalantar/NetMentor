using System;

namespace Recursividad
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"{EjemploRecursividad(10)}");
            Console.ReadKey();
        }

        public static int EjemploRecursividad(int numero)
        {
            if (numero == 0) return 1;
            return numero * EjemploRecursividad(numero - 1);
        }
    }
}
