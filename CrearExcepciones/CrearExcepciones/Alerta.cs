using System;

namespace CrearExcepciones
{
    internal class Alerta
    {
        public static void EnviarEmailAlerta(string subject, string contenido)
        {
            Console.WriteLine($"Email alerta: {contenido}");
            return;
        }
    }
}
