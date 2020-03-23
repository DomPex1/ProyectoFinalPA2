using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoFinalPA2.Models
{
    public class Pedidos
    {
        [Key]
        public int PedidosId { get; set; }
        public DateTime FechaPedido { get; set; }

        
        public int ClienteId { get; set; }

        [Required(ErrorMessage = "No puede estar vacio")]
        [StringLength(maximumLength: 40, ErrorMessage = "Esta fuera de rango")]
        public string FormaPedido { get; set; }

        public int ProductoId { get; set; }

        [Required(ErrorMessage = "No puede estar vacio")]
        [Range(minimum:1,maximum:1000000,ErrorMessage ="No puede pasar el limite")]
        public int Cantidad { get; set; }
        public decimal Total { get; set; }


        [ForeignKey("PedidosId")]
        public List<PedidosDetalle> Detalles { get; set; }

        public Pedidos()
        {
            PedidosId = 0;
            FechaPedido = DateTime.Now;
            ClienteId = 0;
            FormaPedido = string.Empty;
            ProductoId = 0;
            Total = 0;
            Detalles = new List<PedidosDetalle>();
        }
    }
}
