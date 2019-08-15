using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    public partial class tProveedor
    {
        public tProveedor()
        {
            tCompras = new HashSet<tCompras>();
            tRepresentante = new HashSet<tRepresentante>();
        }

        [Key]
        public int IdProveedor { get; set; }
        public int? IdPersona { get; set; }
        public bool? Estado { get; set; }
        [StringLength(80)]
        public string Descripcion { get; set; }

        [ForeignKey("IdPersona")]
        [InverseProperty("tProveedor")]
        public virtual tPersona IdPersonaNavigation { get; set; }
        [InverseProperty("IdProveedorNavigation")]
        public virtual ICollection<tCompras> tCompras { get; set; }
        [InverseProperty("IdProveedorNavigation")]
        public virtual ICollection<tRepresentante> tRepresentante { get; set; }
    }
}