using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    public partial class tUbicacion
    {
        public tUbicacion()
        {
            tProducto = new HashSet<tProducto>();
        }

        [Key]
        public int IdUbicacion { get; set; }
        [StringLength(30)]
        public string Nombre { get; set; }

        [InverseProperty("IdUbicacionNavigation")]
        public virtual ICollection<tProducto> tProducto { get; set; }
    }
}