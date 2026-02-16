using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda_Instrumentos
{
    internal class Persona
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Dni { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Sexo { get; set; }
        public int Edad { get; set; }
        // metodo para mostrar los datos de la perona to string
        public override string ToString()
        {
            return $"Nombre: {Nombre} {Apellido}, Dni: {Dni}";
        }   
    }

}
