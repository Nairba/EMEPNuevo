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

    public partial class Administrador
    {
        [Key]
        public int id { get; set; }


        [Display(Name = "Correo electrónico")]
        [Required(ErrorMessage = "Digite el correo electrónico")]
        public string correo { get; set; }

        [Display(Name = "Contraseña")]
        [Required(ErrorMessage = "Digite la contraseña")]
        [RegularExpression(@"^(?=.*\d)(?=.*[a-z])(?=.*[A-Z]).{4,8}$",
            ErrorMessage = "Formato invalido: La contraseña debe tener al menos 4 " + "\n" +
            "caracteres, no más de 8 caracteres y debe" + "\n" +
            "incluir al menos una letra mayúscula, una" + "\n" +
            "letra minúscula y un dígito numérico.")]
        public string contraseña { get; set; }


        public int estado { get; set; }

        [Display(Name = "Tipo de usuario")]
        [Required(ErrorMessage = "Seleccione el tipo de usuario")]
        public int ID_TIPO_USUARIO { get; set; }

        [Display(Name = "Tipo de usuario")]
        public virtual Tipo_Usuario Tipo_Usuario { get; set; }
        
        [Display(Name = "Estado")]
        [Required(ErrorMessage = "Seleccione el estado")]
        public string estado_String { get; set; }
    }
}
