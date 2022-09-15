using System;

namespace CrearExcepciones
{
    internal class DiferenteClienteAlFacturaException :Exception
    {
        public DiferenteClienteAlFacturaException(string mensaje) : base(mensaje)
        {
            Alerta.EnviarEmailAlerta("INTENTO DE HACKEO!!!", mensaje);
        }
    }
}
