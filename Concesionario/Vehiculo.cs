using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concesionario
{
    internal class Vehiculo
    {
        public string Matricula { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Año { get; set; }
        public int Kilometraje { get; set; }
        public DateTime FechaDeMatriculacion { get; set; }

        // metodo to string para mostrar la informacion del vehiculo
        public override string ToString()
        {
            return $"Matricula: {Matricula}, Marca: {Marca}, Modelo: {Modelo}, Año: {Año}, Kilometraje: {Kilometraje}, Fecha de Matriculacion: {FechaDeMatriculacion.ToShortDateString()}";
        }
        // metodo para que la fecha de matriculacion no sea mayor a la fecha actual
        public bool ValidarFechaDeMatriculacion()
        {
            if (FechaDeMatriculacion > DateTime.Now)
            {
                return false;
            }
            return true;
        }
        // metodo para calcular la antiguedad del vehiculo
        public int CalcularAntiguedad(int Año)
        {
            return DateTime.Now.Year - Año;
        }
    }
}
