using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concesionario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Concesionario miConcesionario = new Concesionario();
            Vehiculo miVehiculo = new Vehiculo();
            int opcion = 0;
            Console.WriteLine("Bienvenido al concesionario");
            do
            {
                Console.WriteLine("1. Agregar un vehiculo");
                Console.WriteLine("2. Mostrar los vehiculos");
                Console.WriteLine("3. Salir");
                Console.WriteLine("Ingrese una opcion: ");
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        DateTime fechaInsertada;
                        int anio;
                        int mes;
                        int dia;
                        Console.WriteLine("Ingrese la matricula del vehiculo: ");
                        miVehiculo.Matricula = Console.ReadLine();
                        Console.WriteLine("Ingrese la marca del vehiculo: ");
                        miVehiculo.Marca = Console.ReadLine();
                        Console.WriteLine("Ingrese el modelo del vehiculo: ");
                        miVehiculo.Modelo = Console.ReadLine();
                        try
                        {
                            Console.WriteLine("Ingrese el año del vehiculo: ");
                            anio = int.Parse(Console.ReadLine());
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("El año ingresado no es valido, se asignara el año actual");
                            anio = DateTime.Now.Year;
                        }
                        try
                        {
                            Console.WriteLine("Ingrese el mes del vehiculo: ");
                            mes = int.Parse(Console.ReadLine());
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("El mes ingresado no es valido, se asignara el mes actual");
                            mes = DateTime.Now.Month;
                        }
                        try { 
                        Console.WriteLine("Ingrese el dia del vehiculo: ");
                        dia = int.Parse(Console.ReadLine());
                            }
                        catch (FormatException)
                        {
                            Console.WriteLine("El dia ingresado no es valido, se asignara el dia actual");
                            dia = DateTime.Now.Day;
                        }
                        fechaInsertada = new DateTime(anio, mes, dia);
                        miVehiculo.FechaDeMatriculacion = fechaInsertada;
                        if(miVehiculo.ValidarFechaDeMatriculacion())
                        {
                            Console.WriteLine("La fecha de matriculacion es valida");
                        }
                        else
                        {
                            Console.WriteLine("La fecha de matriculacion no es valida");
                            
                        }
                        miConcesionario.AgregarVehiculo(miVehiculo);
                        break;

                        case 2:
                        Console.WriteLine("--------------------------------------------------");
                        Console.WriteLine("Lista de vehiculos del concesionario:");
                        Console.WriteLine("--------------------------------------------------");
                        foreach (var vehiculo in miConcesionario.Vehiculos)
                        {
                           
                            Console.WriteLine(vehiculo.ToString());
                        }
                        break;

                }


            }while (opcion != 3) ;
            Console.WriteLine("Gracias por usar el concesionario");
          
        }
    }
}
