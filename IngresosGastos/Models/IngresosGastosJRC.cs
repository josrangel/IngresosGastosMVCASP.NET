using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace IngresosGastos.Models
{
    public class IngresosGastosJRC
    {
        [Key]
        private int Id { get; set; }

        [Required]
        [StringLength (60, MinimumLength = 3)]
        private string Descripcion { get; set; }

        [Required]
        private bool EsIngreso { get; set; }
        
        [Required]
        private double Valor { get; set; }

    }
}