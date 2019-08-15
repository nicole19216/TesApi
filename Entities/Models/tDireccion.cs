using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    public partial class tDireccion
    {
        [Key]
        public int IdDireccion { get; set; }
        public int? IdPersona { get; set; }
        [StringLength(30)]
        public string Pais { get; set; }
        [StringLength(30)]
        public string Departamento { get; set; }
        [StringLength(30)]
        public string Provincia { get; set; }
        [StringLength(30)]
        public string Municipio { get; set; }
        [StringLength(50)]
        public string Direccion { get; set; }

        [ForeignKey("IdPersona")]
        [InverseProperty("tDireccion")]
        public virtual tPersona IdPersonaNavigation { get; set; }
    }
}