using System;

namespace Generics2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AlmacenObjetos<String> archivos = new AlmacenObjetos<String>(4);
            archivos.Agregar("Juan");
            archivos.Agregar("David");
            archivos.Agregar("Balanta");
            archivos.Agregar("Rentería");

            AlmacenObjetos<Empleado> archivos2 = new AlmacenObjetos<Empleado>(4);
            archivos2.Agregar(new Empleado(1500));
            archivos2.Agregar(new Empleado(2000));
            archivos2.Agregar(new Empleado(2500));
            archivos2.Agregar(new Empleado(3000));


            AlmacenObjetos<DateTime> archivos3 = new AlmacenObjetos<DateTime>(4);
            archivos3.Agregar(new DateTime());
            archivos3.Agregar(new DateTime());
            archivos3.Agregar(new DateTime());
            archivos3.Agregar(new DateTime());

            String nombrePersona = archivos.GetElemento(3);
            Console.WriteLine($"Nombre persona: {nombrePersona}");
            Empleado nombreEmpleado = archivos2.GetElemento(3);
            Console.WriteLine($"Sueldo empleado: {nombreEmpleado.GetSalario}");
            DateTime fecha = archivos3.GetElemento(3);
            Console.WriteLine($"Fecha: {archivos3.GetElemento(3)}");

            Console.ReadKey();
        }
    }

    internal class AlmacenObjetos<T>
    {
        public AlmacenObjetos(int z)
        {
            datosElemento = new T[z];
        }

        public void Agregar(T obj)
        {
            datosElemento[i] = obj;
            i++;
        }

        public T GetElemento(int i) => datosElemento[i];

        private T[] datosElemento;
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