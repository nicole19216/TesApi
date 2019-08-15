using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    public partial class tPrivilegio
    {
        public tPrivilegio()
        {
            tPerfil = new HashSet<tPerfil>();
        }

        [Key]
        public int IdPrivilegio { get; set; }
        [StringLength(30)]
        public string Nombre { get; set; }
        public int IdModulo { get; set; }

        [InverseProperty("IdPrivilegioNavigation")]
        public virtual ICollection<tPerfil> tPerfil { get; set; }
    }
}