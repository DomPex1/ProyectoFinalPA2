using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoFinalPA2.Models
{
    public class Usuarios
    {
        [Key]
        public int UsuarioId { get; set; }
        [Required(ErrorMessage = "No puede estar vacio1")]
        public string Usuario { get; set; }
        [Required(ErrorMessage = "No puede estar vacio2")]

        public string Clave { get; set; }
        [Required(ErrorMessage = "No puede estar vacio3")]
        public string NivelUsuario { get; set; }
        [Required(ErrorMessage = "No puede estar vacio4")]
        public string Nombres { get; set; }
        [Required(ErrorMessage = "No puede estar vacio5")]
        public string Email { get; set; }
        public DateTime FechaCreacion { get; set; }

        public Usuarios()
        {
            UsuarioId = 0;
            Usuario = string.Empty;
            Clave = string.Empty;
            NivelUsuario = string.Empty;
            Nombres = string.Empty;
            Email = string.Empty;
            FechaCreacion = DateTime.Now;
        }
    }
}
