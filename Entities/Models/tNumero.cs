using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    public partial class tNumero
    {
        [Key]
        public int IdNumero { get; set; }
        public int? IdPersona { get; set; }
        public long? Celular { get; set; }
        public long? Telefono { get; set; }

        [ForeignKey("IdPersona")]
        [InverseProperty("tNumero")]
        public virtual tPersona IdPersonaNavigation { get; set; }
    }
}