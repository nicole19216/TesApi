using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    public partial class tCompras
    {
        public tCompras()
        {
            tDetalleCompra = new HashSet<tDetalleCompra>();
        }

        [Key]
        public int IdCompras { get; set; }
        public int? IdProveedor { get; set; }
        public int? IdUsuario { get; set; }
        [StringLength(30)]
        public string Factura { get; set; }
        [Column(TypeName = "date")]
        public DateTime? Fecha { get; set; }

        [ForeignKey("IdProveedor")]
        [InverseProperty("tCompras")]
        public virtual tProveedor IdProveedorNavigation { get; set; }
        [ForeignKey("IdUsuario")]
        [InverseProperty("tCompras")]
        public virtual tUsuario IdUsuarioNavigation { get; set; }
        [InverseProperty("IdCompraNavigation")]
        public virtual ICollection<tDetalleCompra> tDetalleCompra { get; set; }
    }
}