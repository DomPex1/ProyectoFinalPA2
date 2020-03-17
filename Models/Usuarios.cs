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
        public string Usuario { get; set; }

        public string Clave { get; set; }
        public string NivelUsuario { get; set; }
        public string Nombres { get; set; }
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
