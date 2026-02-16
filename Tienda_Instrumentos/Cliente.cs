using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda_Instrumentos
{
    internal class Cliente : Persona
    {
        public string numeroCliente { get; set; }
            public string direccion { get; set; }
            public string telefono { get; set; }
            public string email { get; set; }
            public DateTime fechaRegistro { get; set; }
        // sobrescribir el metodo to string para mostrar los datos del cliente
        public override string ToString()
        {
            return $"Nombre: {Nombre} {Apellido}, Numero Cliente: {numeroCliente}, Direccion: {direccion}, Telefono: {telefono}, Email: {email}, Fecha Registro: {fechaRegistro.ToShortDateString()}";
        }
    }
}
