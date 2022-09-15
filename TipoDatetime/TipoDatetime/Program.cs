using System;
using System.Globalization;

namespace TipoDatetime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CultureInfo cultureInfoCol = new CultureInfo("es-CO");


            DateTime simulacionFechaSistema = new DateTime(2019, 01, 06, 17, 30, 12);

            CultureInfo cultureInfoUS = new CultureInfo("en-us");
            DateTime ejemploFecha = Convert.ToDateTime("10/22/2015 12:10:15 PM", cultureInfoUS);

            Console.WriteLine($"El tiempo del sistema es: {simulacionFechaSistema:yyyy-MM-ddThh:mm:ss.ms}");
            Console.WriteLine(simulacionFechaSistema.ToString("ddddd dd"));
            Console.WriteLine(ejemploFecha);
            Console.ReadKey();
        }
    }
}
