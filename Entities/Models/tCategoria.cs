using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    public partial class tCategoria
    {
        public tCategoria()
        {
            tCategoriaProducto = new HashSet<tCategoriaProducto>();
        }

        [Key]
        public int IdCategoria { get; set; }
        [StringLength(30)]
        public string Nombre { get; set; }

        [InverseProperty("IdCategoriaNavigation")]
        public virtual ICollection<tCategoriaProducto> tCategoriaProducto { get; set; }
    }
}