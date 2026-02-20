using System.Text.Json.Serialization;

namespace MiApi.Models
{
    public class Libro
    {
        
        public int id { get; set; }

        public string nombre { get; set; } = "";
        public string autor { get; set; } = "";
        public int anio { get; set; }


    }
}
