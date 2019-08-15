using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    public partial class tMarca
    {
        public tMarca()
        {
            tProducto = new HashSet<tProducto>();
        }

        [Key]
        public int IdMarca { get; set; }
        [StringLength(30)]
        public string Nombre { get; set; }

        [InverseProperty("IdMarcaNavigation")]
        public virtual ICollection<tProducto> tProducto { get; set; }
    }
}