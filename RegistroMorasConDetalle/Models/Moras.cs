using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RegistroMorasConDetalle.Models
{
    public class Moras
    {
        [Key]
        public int MoraId { get; set; }
        public DateTime Fecha { get; set; }
        [Range(minimum: 1, maximum: 999999999, ErrorMessage = "Es obligatorio introducir una mora al detalle")]
        public decimal Total { get; set; }
        [ForeignKey("MoraId")]
        public virtual List<MorasDetalle> Detalle { get; set; } = new List<MorasDetalle>();

        public Moras(int moraId, DateTime fecha, decimal total, List<MorasDetalle> detalle)
        {
            MoraId = moraId;
            Fecha = fecha;
            Total = total;
            Detalle = new List<MorasDetalle>();
        }

        public Moras()
        {
            MoraId = 0;
            Fecha = DateTime.Now;
            Total = 0;
            Detalle = new List<MorasDetalle>();
        }
    }
}
