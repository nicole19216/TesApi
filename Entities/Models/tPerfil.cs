using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    public partial class tPerfil
    {
        public tPerfil()
        {
            tRolPerfil = new HashSet<tRolPerfil>();
        }

        [Key]
        public int IdPerfil { get; set; }
        [StringLength(30)]
        public string Nombre { get; set; }
        public bool? Estado { get; set; }
        public int? IdPrivilegio { get; set; }

        [ForeignKey("IdPrivilegio")]
        [InverseProperty("tPerfil")]
        public virtual tPrivilegio IdPrivilegioNavigation { get; set; }
        [InverseProperty("IdPerfilNavigation")]
        public virtual ICollection<tRolPerfil> tRolPerfil { get; set; }
    }
}