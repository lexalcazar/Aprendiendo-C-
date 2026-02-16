using System.ComponentModel.DataAnnotations;

namespace primeraAppEnC_.Models
{
    public class Persona
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio")]
        public string Nombre { get; set; } = "";

        [Required(ErrorMessage = "Los apellidos son obligatorios")]
        public string Apellido { get; set; } = "";

        [Required(ErrorMessage = "El email es obligatorio")]
        public string Email { get; set; }= "";
    }
}
