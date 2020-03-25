using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoFinalPA2.Models
{
    public class TipoCliente
    {

        [Key]

        public int TipoClienteId { get; set; }

        [Required(ErrorMessage = "El campo Descripcion no puede estar vacio")]
        [StringLength(maximumLength: 40, ErrorMessage = "Esta fuera de rango")]
        public string Descripcion { get; set; }

        public TipoCliente()
        {
            TipoClienteId = 0;
            Descripcion = string.Empty;
        }
    }
}
