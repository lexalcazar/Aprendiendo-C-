using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concesionario
{
    internal class Concesionario
    {
        public List <Vehiculo> Vehiculos { get; set; }= new List <Vehiculo>();
   
    // metodo para agregar un vehiculo al concesionario
        public void AgregarVehiculo(Vehiculo vehiculo)
        {
            Vehiculos.Add(vehiculo);
        }
    }
}
