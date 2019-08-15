using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    public partial class tCategoriaProducto
    {
        public int IdCategoria { get; set; }
        public int IdProducto { get; set; }

        [ForeignKey("IdCategoria")]
        [InverseProperty("tCategoriaProducto")]
        public virtual tCategoria IdCategoriaNavigation { get; set; }
        [ForeignKey("IdProducto")]
        [InverseProperty("tCategoriaProducto")]
        public virtual tProducto IdProductoNavigation { get; set; }
    }
}