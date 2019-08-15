using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    public partial class tDetalleCompra
    {
        public int IdDetalleCompra { get; set; }
        public int IdCompra { get; set; }
        public int IdProducto { get; set; }
        [StringLength(30)]
        public string UnidadCompra { get; set; }
        public int? Cantidad { get; set; }
        public int? PeizasContenidas { get; set; }
        [Column(TypeName = "money")]
        public decimal? Precio { get; set; }

        [ForeignKey("IdCompra")]
        [InverseProperty("tDetalleCompra")]
        public virtual tCompras IdCompraNavigation { get; set; }
        [ForeignKey("IdProducto")]
        [InverseProperty("tDetalleCompra")]
        public virtual tProducto IdProductoNavigation { get; set; }
    }
}