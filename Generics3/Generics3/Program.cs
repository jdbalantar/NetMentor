using System;

namespace GenericsWithRestrictions
{
    internal class Program
    {
        private static void Main()
        {
            AlmacenEmpleados<Director> director = new AlmacenEmpleados<Director>(5);
            director.Agregar(new Director(5000));
            director.Agregar(new Director(4000));
            director.Agregar(new Director(3000));
            director.Agregar(new Director(2000));
            director.Agregar(new Director(1000));

            AlmacenEmpleados<Electricista> electricista = new AlmacenEmpleados<Electricista>(5);
            electricista.Agregar(new Electricista(2535));
            electricista.Agregar(new Electricista(25355));
            electricista.Agregar(new Electricista(25355));
            electricista.Agregar(new Electricista(25356));
            electricista.Agregar(new Electricista(255635));

            AlmacenEmpleados<Secretaria> secretaria = new AlmacenEmpleados<Secretaria>(5);
            secretaria.Agregar(new Secretaria(2545646));
            secretaria.Agregar(new Secretaria(25456));
            secretaria.Agregar(new Secretaria(254665646));
            secretaria.Agregar(new Secretaria(27646));
            secretaria.Agregar(new Secretaria(945648));

            //No deja almacenar el estudiante porque no es un empleado con método (GetSalario)
            // Descomenta la línea de abajo para que veas
            //AlmacenEmpleados<Estudiante> estudiante = new AlmacenEmpleados<Estudiante>(5);

            Console.ReadKey();
        }
    }

    class AlmacenEmpleados<T> where T : IParaEmpleados
    {
        public AlmacenEmpleados(int z)
        {
            datosEmpleado = new T[z];
        }

        public void Agregar(T obj)
        {
            datosEmpleado[i] = obj;
        }

        public T GetEmpleado(int index) => datosEmpleado[index];

        private int i = 0;
        private T[] datosEmpleado;
    }

    class Director : IParaEmpleados
    {
        private double _salario;

        public Director(double salario)
        {
            _salario = salario;
        }

        public double GetSalario()
        {
            throw new NotImplementedException();
        }
    }

    class Secretaria : IParaEmpleados
    {
        private double _salario;

        public Secretaria(double salario)
        {
            _salario = salario;
        }

        public double GetSalario()
        {
            throw new NotImplementedException();
        }
    }

    class Electricista : IParaEmpleados
    {
        private double _salario;

        public Electricista(double salario)
        {
            _salario = salario;
        }

        public double GetSalario()
        {
            throw new NotImplementedException();
        }
    }

    class Estudiante
    {
        public Estudiante(double edad)
        {
            this.edad = edad;
        }
        private double edad;
    }

    interface IParaEmpleados
    {
        double GetSalario();
    }

}