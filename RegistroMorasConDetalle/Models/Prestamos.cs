using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RegistroMorasConDetalle.Models
{
    public class Prestamos
    {
        [Key]
        public int PrestamoId { get; set; }
        public DateTime Fecha { get; set; }
        [Required(ErrorMessage = "Es obligatorio introducir el nombre de la persona")]
        public string Persona { get; set; }
        [Required(ErrorMessage = "Es obligatorio introducir el concepto del prestamo")]
        public string Concepto { get; set; }
        [Required(ErrorMessage = "Es obligatorio introducir el monto")]
        [Range(minimum:1,maximum:999999999,ErrorMessage ="El monto no puede ser menor o igual que 0")]
        public decimal Monto { get; set; }
        public Prestamos(int prestamoId, DateTime fecha, string persona, string concepto, decimal monto)
        {
            PrestamoId = prestamoId;
            Fecha = fecha;
            Persona = persona;
            Concepto = concepto;
            Monto = monto;
        }

        public Prestamos()
        {
        }
    }
}
