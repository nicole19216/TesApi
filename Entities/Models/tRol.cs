using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    public partial class tRol
    {
        public tRol()
        {
            tRolPerfil = new HashSet<tRolPerfil>();
            tUsuario = new HashSet<tUsuario>();
        }

        [Key]
        public int IdRol { get; set; }
        [StringLength(30)]
        public string Nombre { get; set; }
        public bool? Estado { get; set; }

        [InverseProperty("IdRolNavigation")]
        public virtual ICollection<tRolPerfil> tRolPerfil { get; set; }
        [InverseProperty("IdRolNavigation")]
        public virtual ICollection<tUsuario> tUsuario { get; set; }
    }
}