using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    public partial class tCliente
    {
        [Key]
        public int IdCliente { get; set; }
        public int? IdPersona { get; set; }
        [StringLength(10)]
        public string Tipo { get; set; }
        public bool? Estado { get; set; }

        [ForeignKey("IdPersona")]
        [InverseProperty("tCliente")]
        public virtual tPersona IdPersonaNavigation { get; set; }
    }
}