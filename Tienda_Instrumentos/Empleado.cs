using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda_Instrumentos
{
    internal class Empleado : Persona
    {
        public string numeroEmpleado { get; set; }
        public string departamento { get; set; }
        public string categoria { get; set; }
        public string puesto { get; set; }
        public DateTime fechaContratacion { get; set; }
        // sobrescribir el metodo to string para mostrar los datos del empleado
        public override string ToString()
        {
            return $"Nombre: {Nombre} {Apellido}, Numero Empleado: {numeroEmpleado}, Departamento: {departamento}, Categoria: {categoria}, Puesto: {puesto}, Fecha Contratacion: {fechaContratacion.ToShortDateString()}";
        }
    }
}
