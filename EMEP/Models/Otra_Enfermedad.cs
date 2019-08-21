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

    public partial class Otra_Enfermedad
    {
        [Key]
        public int id { get; set; }
        [Display(Name = "Nombre")]
        [Required(ErrorMessage = "Debe de escribir el nombre")]
        public string descripciom { get; set; }
        [Display(Name = "Categoria")]
        [Required(ErrorMessage = "Seleccione la categoria")]
        public string categoria { get; set; }
        public int estado { get; set; }


        [Display(Name = "Estado")]
        [Required(ErrorMessage = "Seleccione el estado")]
        public string estado_String { get; set; }

        [DataType(DataType.ImageUrl)]
        [Display(Name = "Imagen")]
        [Required(ErrorMessage = "Seleccione imegen")]
        public byte[] img { get; set; }
        [Display(Name = "Expediente")]
        [Required(ErrorMessage = "Seleccione el expediente")]
        public int ID_EXPEDIENTE { get; set; }

        [Display(Name = "Expediente")]
        public virtual Expediente Expediente { get; set; }
    }
}
