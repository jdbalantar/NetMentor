using System;

namespace TiposAnonimos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var equipo = new { Nombre = "Barcelona FC", Ligas = "" };
            var nombreEquipo = equipo.Nombre;
            Test(equipo);
            Console.ReadKey();
        }

        public static void Test(dynamic equipo)
        {
            Console.WriteLine(equipo.Nombre);
        }
    }
}
