using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    public partial class tProducto
    {
        public tProducto()
        {
            tCategoriaProducto = new HashSet<tCategoriaProducto>();
            tDetalleCompra = new HashSet<tDetalleCompra>();
            tImagen = new HashSet<tImagen>();
            tLotes = new HashSet<tLotes>();
            tPresentacion = new HashSet<tPresentacion>();
        }

        public int IdProducto { get; set; }
        public bool? Estado { get; set; }
        [StringLength(30)]
        public string CodigoBarras { get; set; }
        [StringLength(20)]
        public string CodigoRapido { get; set; }
        [StringLength(30)]
        public string Nombre { get; set; }
        public long? StockMinimo { get; set; }
        public long? StockMaximo { get; set; }
        public int? IdMarca { get; set; }
        public int? IdUbicacion { get; set; }
        public int? IdImagen { get; set; }
        public long? StockActual { get; set; }

        [ForeignKey("IdImagen")]
        [InverseProperty("tProducto")]
        public virtual tImpuesto IdImagenNavigation { get; set; }
        [ForeignKey("IdMarca")]
        [InverseProperty("tProducto")]
        public virtual tMarca IdMarcaNavigation { get; set; }
        [ForeignKey("IdUbicacion")]
        [InverseProperty("tProducto")]
        public virtual tUbicacion IdUbicacionNavigation { get; set; }
        [InverseProperty("IdProductoNavigation")]
        public virtual ICollection<tCategoriaProducto> tCategoriaProducto { get; set; }
        [InverseProperty("IdProductoNavigation")]
        public virtual ICollection<tDetalleCompra> tDetalleCompra { get; set; }
        [InverseProperty("IdProductoNavigation")]
        public virtual ICollection<tImagen> tImagen { get; set; }
        [InverseProperty("IdProductoNavigation")]
        public virtual ICollection<tLotes> tLotes { get; set; }
        [InverseProperty("IdProductoNavigation")]
        public virtual ICollection<tPresentacion> tPresentacion { get; set; }
    }
}