using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoFinalPA2.Models
{
    public class Clientes
    {
        [Key]

        public int ClienteId { get; set; }
        [Required(ErrorMessage ="No puede estar vacio")]

        public string Nombre { get; set; }
        [Required(ErrorMessage = "No puede estar vacio")]
        public int Telefono { get; set; }

        [Required(ErrorMessage = "No puede estar vacio")]
        public string Email { get; set; }

        public Clientes()
        {
            ClienteId = 0;
            Nombre = string.Empty;
            Telefono = 0;
            Email = string.Empty;
        }
    }
}
