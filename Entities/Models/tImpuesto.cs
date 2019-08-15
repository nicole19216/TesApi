using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    public partial class tImpuesto
    {
        public tImpuesto()
        {
            tProducto = new HashSet<tProducto>();
        }

        [Key]
        public int IdImpuesto { get; set; }
        [StringLength(30)]
        public string Nombre { get; set; }
        [Column(TypeName = "decimal(4, 2)")]
        public decimal? Valor { get; set; }

        [InverseProperty("IdImagenNavigation")]
        public virtual ICollection<tProducto> tProducto { get; set; }
    }
}