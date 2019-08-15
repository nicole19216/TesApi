using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    public partial class tUsuario
    {
        public tUsuario()
        {
            tCompras = new HashSet<tCompras>();
        }

        [Key]
        public int IdUsuario { get; set; }
        public int? IdPersona { get; set; }
        [StringLength(20)]
        public string Usuario { get; set; }
        [StringLength(20)]
        public string Contraseña { get; set; }
        public bool? Estado { get; set; }
        public int? IdRol { get; set; }

        [ForeignKey("IdPersona")]
        [InverseProperty("tUsuario")]
        public virtual tPersona IdPersonaNavigation { get; set; }
        [ForeignKey("IdRol")]
        [InverseProperty("tUsuario")]
        public virtual tRol IdRolNavigation { get; set; }
        [InverseProperty("IdUsuarioNavigation")]
        public virtual ICollection<tCompras> tCompras { get; set; }
    }
}