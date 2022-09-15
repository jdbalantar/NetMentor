using System;

namespace CrearExcepciones
{
    internal class Repository
    {
        public bool ClienteYFacturaDuenoSonElMismo(Guid clienteId, Guid facturaId)
        {
            Guid cliente = GetClienteById(clienteId);
            Guid factura = GetClienteByFactyuraId(facturaId);
            return cliente.ToString() == factura.ToString();
        }

        private Guid GetClienteByFactyuraId(Guid facturaId)
        {
            return facturaId;
        }

        private Guid GetClienteById(Guid clienteId)
        {
            return clienteId;
        }
    }
}
