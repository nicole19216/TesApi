using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    public partial class tRolPerfil
    {
        public int IdRol { get; set; }
        public int IdPerfil { get; set; }

        [ForeignKey("IdPerfil")]
        [InverseProperty("tRolPerfil")]
        public virtual tPerfil IdPerfilNavigation { get; set; }
        [ForeignKey("IdRol")]
        [InverseProperty("tRolPerfil")]
        public virtual tRol IdRolNavigation { get; set; }
    }
}