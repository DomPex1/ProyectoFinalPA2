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
        [Required(ErrorMessage = "El campo nombre no puede estar vacio")]
        [StringLength(maximumLength: 40, ErrorMessage = "Esta fuera de rango")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "El campo telefono no puede estar vacio")]
        public string Telefono { get; set; }

        [Required(ErrorMessage = "El campo email no puede estar vacio")]
        [StringLength(maximumLength: 40, ErrorMessage = "Esta fuera de rango")]
        public string Email { get; set; }
        [Required(ErrorMessage = "El campo Tipo de cliente no puede estar vacio")]
        [StringLength(maximumLength: 40, ErrorMessage = "Esta fuera de rango")]
        public string TipoCliente { get; set; }

        public Clientes()
        {
            ClienteId = 0;
            Nombre = string.Empty;
            Telefono = string.Empty;
            Email = string.Empty;
            TipoCliente= string.Empty;
        }
    }
}
