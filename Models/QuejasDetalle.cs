using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoFinalPA2.Models
{
    public class QuejasDetalle
    {
        [Key]
        public int QuejasDetalleId { get; set; }
        public int QuejasId { get; set; }
        public string Problema { get; set; }

        public string Solucion { get; set; }

        public QuejasDetalle()
        {
            QuejasDetalleId = 0;
            QuejasId = 0;
            Problema = string.Empty;
            Solucion = string.Empty;
        }
    }
}
