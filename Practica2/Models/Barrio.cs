using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Practica2.Models
{
    public class Barrio
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(30, ErrorMessage = "El campo {0} debe contener al menos un caracter")]
        public string Nombre { get; set; }

        public ICollection<Alumno> Alumnos { get; set; }
        [DisplayName("Alumnos Number")]
        public int AlumnosNumber => Alumnos == null ? 0 : Alumnos.Count;
    }
}
