using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace helpers.Models
{
    public class Persona
    {
        [Required]
        [MaxLength(13)]
        [DataType(DataType.Text)]
        public string cedula { get; set; }

        [Required]
        [MaxLength(30)]
        [DataType(DataType.Text)]
        public string nombre { get; set; }

        [Required]
        [MaxLength(30)]
        [DataType(DataType.Text)]
        public string apellido { get; set; }

        [Required]
        public int edad { get; set; }

        [Required]
        [MaxLength(10)]
        [DataType(DataType.PhoneNumber)]
        public string telefono { get; set; }

        [Required]
        [MaxLength(50)]
        [DataType(DataType.EmailAddress)]
        public string correo { get; set; }

        [Required]
        public string genero { get; set; }

        [Required]
        [MaxLength(30)]
        public string estado { get; set; }

        [Required]
        public string hobbys { get; set; }
    }
}
