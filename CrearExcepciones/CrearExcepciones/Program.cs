using System;

namespace CrearExcepciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Repository repo = new Repository();

            Guid clienteId = Guid.NewGuid();
            Guid facturaId = Guid.NewGuid();

            if (!repo.ClienteYFacturaDuenoSonElMismo(clienteId, facturaId))
            {
                throw new DiferenteClienteAlFacturaException($"El cliente {clienteId} está intentando acceder a la factura {facturaId} que no le corresponde");
            }
        }
    }
}
