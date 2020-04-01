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
        [Required(ErrorMessage = "El campo usuario no puede estar vacio")]
        [StringLength(maximumLength: 40, ErrorMessage = "Esta fuera de rango")]
        public string Usuario { get; set; }
        [RegularExpression(@"^.{8,}$", ErrorMessage = "La contraseña debe contar con al menos 8 carácteres"), Required(ErrorMessage = "Tienes que introducir una contraseña")]

        public string Clave { get; set; }
        [Required(ErrorMessage = "El campo nivelUsuario no puede estar vacio")]
        [StringLength(maximumLength: 40, ErrorMessage = "Esta fuera de rango")]
        public string NivelUsuario { get; set; }
        [Required(ErrorMessage = "El campo nombres no puede estar vacio")]
        [StringLength(maximumLength: 40, ErrorMessage = "Esta fuera de rango")]
        public string Nombres { get; set; }
        [Required(ErrorMessage = "El Email es obligatorio")]
        [EmailAddress(ErrorMessage = "Debe ingresar un Email valido.")]
        [MaxLength(40, ErrorMessage = "Este correo es muy largo.")]
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
