using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    public partial class tRepresentante
    {
        [Key]
        public int IdRepresentate { get; set; }
        public int? IdPersona { get; set; }
        public int? IdProveedor { get; set; }
        public bool? Estado { get; set; }

        [ForeignKey("IdPersona")]
        [InverseProperty("tRepresentante")]
        public virtual tPersona IdPersonaNavigation { get; set; }
        [ForeignKey("IdProveedor")]
        [InverseProperty("tRepresentante")]
        public virtual tProveedor IdProveedorNavigation { get; set; }
    }
}