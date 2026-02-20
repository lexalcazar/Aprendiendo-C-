using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace MiApi.Models
{
    public class Libro
    {
        
        public int id { get; set; }
        [Required(ErrorMessage = "El nombre del libro es obligatorio.")]
        [MaxLength(50)]
        public string nombre { get; set; } = "";
        [Required(ErrorMessage = "El autor del libro es obligatorio.")]
        [MaxLength(50)]
        public string autor { get; set; } = "";
        [Required(ErrorMessage = "El año de publicación del libro es obligatorio.")]
        [Range(1000, 2026, ErrorMessage = "El año de publicación debe estar entre 0 y 2026.")]
        public int anio { get; set; }


    }
}
