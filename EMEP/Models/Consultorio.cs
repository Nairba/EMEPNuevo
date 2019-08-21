//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EMEP.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Consultorio
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Consultorio()
        {
            this.Consulta = new HashSet<Consulta>();
        }

        [Key]
        public int id { get; set; }
        [Display(Name = "Descripci�n")]
        [Required(ErrorMessage = "Debe escribir la descripci�n de consultorio")]
        public string descripcion { get; set; }
        [Display(Name = "N�mero")]
        [Required(ErrorMessage = "Debe escribir el numero de consultorio")]
        public string numero { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Consulta> Consulta { get; set; }
    }
}
