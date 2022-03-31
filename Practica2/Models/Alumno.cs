using System.ComponentModel.DataAnnotations;

namespace Practica2.Models
{
    public class Alumno
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(30, ErrorMessage = "El campo {0} debe contener al menos un caracter")]
        public string Nombres { get; set; }

        [MaxLength(30, ErrorMessage = "El campo {0} debe contener al menos un caracter")]
        public string Apellidos { get; set; }

        [MaxLength(12, ErrorMessage = "El campo {0} debe contener al menos un caracter")]
        public string Documento { get; set; }

        [MaxLength(12, ErrorMessage = "El campo {0} debe contener al menos un caracter")]
        public string Direccion { get; set; }

        [MaxLength(12, ErrorMessage = "El campo {0} debe contener al menos un caracter")]
        public string Telefono { get; set; }

        [MaxLength(12, ErrorMessage = "El campo {0} debe contener al menos un caracter")]
        public string Correo { get; set; }

        [MaxLength(12, ErrorMessage = "El campo {0} debe contener al menos un caracter")]
        public string Grado { get; set; }

        [MaxLength(12, ErrorMessage = "El campo {0} debe contener al menos un caracter")]
        public string Edad { get; set; }

    }
}
