using System;

namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AlmacenObjetos archivos = new AlmacenObjetos(4);
            /*
            archivos.Agregar("Juan");
            archivos.Agregar("David");
            archivos.Agregar("Balanta");
            archivos.Agregar("Rentería");

            String nombrePersona = (string)archivos.GetElemento(3);
            Console.WriteLine(nombrePersona);
            */

            archivos.Agregar(new Empleado(1500));
            archivos.Agregar(new Empleado(2000));
            archivos.Agregar(new Empleado(2500));
            archivos.Agregar(new Empleado(3000));

            Empleado nombrePersona = (Empleado)archivos.GetElemento(3);
            Console.WriteLine(nombrePersona.GetSalario);

            Console.ReadKey();
        }
    }

    class AlmacenObjetos
    {
        public AlmacenObjetos(int z)
        {
            datosElemento = new object[z];
        }

        public void Agregar(object obj)
        {
            datosElemento[i] = obj;
            i++;
        }

        public object GetElemento(int i) => datosElemento[i];

        private object[] datosElemento;
        private int i = 0;
    }

    class Empleado
    {
        public Empleado(double salario)
        {
            _salario = salario;
        }

        public double GetSalario => _salario;

        private double _salario;
    }
}
