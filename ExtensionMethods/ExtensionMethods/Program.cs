using System;

namespace ExtensionMethods
{
    /// <summary>
    /// Los extensions methods se pueden implementar cuando vamos a reutilizar muchas veces una funcion
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hello world".PrimeraLetraMayuscula());
            Console.ReadKey();
        }
    }

    public static class StringExtension
    {
        public static string PrimeraLetraMayuscula(this string frase)
        {
            char primeraLetra = char.ToUpper(frase[0]);
            string restoFrase = frase.Substring(1);
            return primeraLetra + restoFrase;
        }
    }
}
