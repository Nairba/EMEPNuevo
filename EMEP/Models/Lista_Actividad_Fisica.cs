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

    public partial class Lista_Actividad_Fisica
    {
        [Key]
        public int id { get; set; }

        public int activo { get; set; }
        [Display(Name = "Estado")]
        [Required(ErrorMessage = "Seleccione el estado")]
        public string estado_String { get; set; }
        [Display(Name = "Nombre")]
        [Required(ErrorMessage = "Debe de escribir el nombre")]
        public string nombre { get; set; }
        [Display(Name = "Minutos")]
        [Required(ErrorMessage = "Debe digitar los minutos")]
        public int minutos { get; set; }
        [Display(Name = "Cantidad de veses")]
        [Required(ErrorMessage = "Debe digitar la cantidad de meses")]
        public int cant_veces { get; set; }
        [Display(Name = "Expediente")]
        [Required(ErrorMessage = "Seleccione el expediente")]
        public int ID_EXPEDIENTE { get; set; }
        [DataType(DataType.ImageUrl)]
        [Display(Name = "Imagen")]
        [Required(ErrorMessage = "Seleccione imegen")]
        public byte[] img { get; set; }

        [Display(Name = "Expediente")]
        public virtual Expediente Expediente { get; set; }
    }
}
