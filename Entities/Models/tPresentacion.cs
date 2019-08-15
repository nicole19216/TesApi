using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    public partial class tPresentacion
    {
        [Key]
        public int IdPresentacion { get; set; }
        public int? IdProducto { get; set; }
        [StringLength(30)]
        public string Nombre { get; set; }
        public int? CantidadPieza { get; set; }
        [Column(TypeName = "money")]
        public decimal? PrecioPieza { get; set; }
        [Column(TypeName = "money")]
        public decimal? PrecioVenta { get; set; }

        [ForeignKey("IdProducto")]
        [InverseProperty("tPresentacion")]
        public virtual tProducto IdProductoNavigation { get; set; }
    }
}