using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoFinalPA2.Models
{
    public class Productos
    {
        [Key]
        public int ProductoId { get; set; }
        [Required(ErrorMessage = "No puede estar vacio")]
        [StringLength(maximumLength: 40, ErrorMessage = "Esta fuera de rango")]
        public string Descripcion { get; set; }
        public DateTime FechaIngreso { get; set; }
        [Required(ErrorMessage = "No puede estar vacio")]
        [Range(minimum: 1, maximum: 10000000, ErrorMessage = "No puede pasar el limite")]
        public decimal Precio { get; set; }
        [Required(ErrorMessage = "No puede estar vacio")]
        [Range(minimum: 1, maximum: 1000000, ErrorMessage = "No puede pasar el limite")]
        public int Cantidad { get; set; }
        [Required(ErrorMessage = "No puede estar vacio")]
        [Range(minimum: 1, maximum: 1000000, ErrorMessage = "No puede pasar el limite")]
        public decimal Costo { get; set; }
        [Required(ErrorMessage = "No puede estar vacio")]
        [Range(minimum: 1, maximum: 1000000, ErrorMessage = "No puede pasar el limite")]
        public decimal Ganancia { get; set; }
        



        public int ProveedoresId { get; set; }

        public Productos()
        {
            ProductoId = 0;
            Descripcion = string.Empty;
            FechaIngreso = DateTime.Now;
            Precio = 0;
            Cantidad = 0;
            Costo = 0;
            Ganancia = 0;
            ProveedoresId = 0;

        }
    }
}
