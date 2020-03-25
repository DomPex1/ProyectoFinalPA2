using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoFinalPA2.Models
{
    public class CategoriaArticulos
    {
        [Key]
        public int CategoriaId { get; set; }
        [Required(ErrorMessage = "El campo descripcion no puede estar vacio")]
        [StringLength(maximumLength: 40, ErrorMessage = "Esta fuera de rango")]
        public string Descripcion { get; set; }

        public CategoriaArticulos()
        {
            CategoriaId = 0;
            Descripcion = string.Empty];
        }
    }
}
