using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    public partial class tImagen
    {
        [Key]
        public int IdImagen { get; set; }
        public int? IdProducto { get; set; }
        [Column(TypeName = "image")]
        public byte[] Imagen { get; set; }

        [ForeignKey("IdProducto")]
        [InverseProperty("tImagen")]
        public virtual tProducto IdProductoNavigation { get; set; }
    }
}