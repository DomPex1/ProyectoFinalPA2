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
        [Required(ErrorMessage = "No puede estar vacio")]
        [StringLength(maximumLength: 40, ErrorMessage = "Esta fuera de rango")]
        public string Usuario { get; set; }
        [Required(ErrorMessage = "No puede estar vacio")]

        public string Clave { get; set; }
        [Required(ErrorMessage = "No puede estar vacio")]
        [StringLength(maximumLength: 40, ErrorMessage = "Esta fuera de rango")]
        public string NivelUsuario { get; set; }
        [Required(ErrorMessage = "No puede estar vacio")]
        [StringLength(maximumLength: 40, ErrorMessage = "Esta fuera de rango")]
        public string Nombres { get; set; }
        [Required(ErrorMessage = "No puede estar vacio")]
        [StringLength(maximumLength: 40, ErrorMessage = "Esta fuera de rango")]
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
