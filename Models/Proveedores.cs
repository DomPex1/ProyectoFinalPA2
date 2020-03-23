using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoFinalPA2.Models
{
    public class Proveedores
    {
        [Key]
        public int ProveedorId { get; set; }
        [Required(ErrorMessage = "No puede estar vacio")]
        [StringLength(maximumLength: 40, ErrorMessage = "Esta fuera de rango")]
        public string Nombres { get; set; }
        [Required(ErrorMessage = "No puede estar vacio")]
        [StringLength(maximumLength: 40, ErrorMessage = "Esta fuera de rango")]
        public string Direccion { get; set; }
        [Required(ErrorMessage = "No puede estar vacio")]
        [StringLength(maximumLength: 15, ErrorMessage = "Esta fuera de rango")]
        public string Telefono { get; set; }

        public Proveedores()
        {
            ProveedorId = 0;
            Nombres = string.Empty;
            Direccion = string.Empty;
            Telefono = string.Empty;
        }
    }
}
