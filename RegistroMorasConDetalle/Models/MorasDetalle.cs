using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RegistroMorasConDetalle.Models
{
    public class MorasDetalle
    {
        [Key]
        public int Id { get; set; }

        public int MoraId { get; set; }

        [Required(ErrorMessage = "Debe introducir el id del prestamo")]
        public int PrestamoId { get; set; }

        [Required(ErrorMessage = "Es obligatorio introducir el valor")]
        public decimal Valor { get; set; }

        public MorasDetalle()
        {
            Id = 0;
            MoraId = 0;
            PrestamoId = 0;
            Valor = 0;
        }
    }
}
