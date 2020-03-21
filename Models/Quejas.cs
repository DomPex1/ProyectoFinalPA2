using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoFinalPA2.Models
{
    public class Quejas
    {
        [Key]
        public int QuejasId { get; set; }

        public string Descripcion { get; set; }

        public DateTime Fecha { get; set; }
        [Required(ErrorMessage = "No puede estar vacio")]
        public int ClienteId { get; set; }


        [ForeignKey("QuejasId")]
        public List<QuejasDetalle> Detalles { get; set; }

        public Quejas()
        {
            QuejasId = 0;
            Descripcion = string.Empty;
            Fecha = DateTime.Now;
            ClienteId = 0;
            Detalles = new List<QuejasDetalle>();
        }
    }
}
