using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    public partial class tLotes
    {
        [Key]
        public int IdLotes { get; set; }
        [StringLength(30)]
        public string Nombre { get; set; }
        public long? Cantidad { get; set; }
        [Column(TypeName = "date")]
        public DateTime? Fabricacion { get; set; }
        [Column(TypeName = "date")]
        public DateTime? Vencimiento { get; set; }
        public int? IdProducto { get; set; }

        [ForeignKey("IdProducto")]
        [InverseProperty("tLotes")]
        public virtual tProducto IdProductoNavigation { get; set; }
    }
}