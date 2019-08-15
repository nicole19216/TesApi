using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    public partial class tPersona
    {
        public tPersona()
        {
            tCliente = new HashSet<tCliente>();
            tDireccion = new HashSet<tDireccion>();
            tNumero = new HashSet<tNumero>();
            tProveedor = new HashSet<tProveedor>();
            tRepresentante = new HashSet<tRepresentante>();
            tUsuario = new HashSet<tUsuario>();
        }

        [Key]
        public int IdPersona { get; set; }
        [StringLength(50)]
        public string Nombre { get; set; }
        [StringLength(15)]
        public string Ci { get; set; }
        [StringLength(50)]
        public string Email { get; set; }
        [Column(TypeName = "date")]
        public DateTime? Fecha { get; set; }
        [StringLength(30)]
        public string Nit { get; set; }
        [Column(TypeName = "image")]
        public byte[] Imagen { get; set; }
        public long? Telefono { get; set; }
        public long? Celular { get; set; }

        [InverseProperty("IdPersonaNavigation")]
        public virtual ICollection<tCliente> tCliente { get; set; }
        [InverseProperty("IdPersonaNavigation")]
        public virtual ICollection<tDireccion> tDireccion { get; set; }
        [InverseProperty("IdPersonaNavigation")]
        public virtual ICollection<tNumero> tNumero { get; set; }
        [InverseProperty("IdPersonaNavigation")]
        public virtual ICollection<tProveedor> tProveedor { get; set; }
        [InverseProperty("IdPersonaNavigation")]
        public virtual ICollection<tRepresentante> tRepresentante { get; set; }
        [InverseProperty("IdPersonaNavigation")]
        public virtual ICollection<tUsuario> tUsuario { get; set; }
    }
}