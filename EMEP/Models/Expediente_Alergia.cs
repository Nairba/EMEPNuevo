//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EMEP.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Expediente_Alergia
    {
        [Key]
        public int id { get; set; }

        [Display(Name = "Expediente")]
        [Required(ErrorMessage = "Seleccione el Expediente")]
        public int ID_EXPEDIENTE { get; set; }
        [Display(Name = "Alergia")]
        [Required(ErrorMessage = "Seleccione la Alergia")]
        public int ID_ALERGIA { get; set; }

        [Display(Name = "Expediente")]
        public virtual Expediente Expediente { get; set; }
        [Display(Name = "Alergia")]
        public virtual Lista_Alergia Lista_Alergia { get; set; }
    }
}
