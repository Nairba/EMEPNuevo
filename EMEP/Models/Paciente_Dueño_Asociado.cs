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
    
    public partial class Paciente_Dueño_Asociado
    {
        public int id { get; set; }
        public string ID_PACIENTE_DUE { get; set; }
        public string ID_PACIENTE_ASO { get; set; }
    
        public virtual Paciente Paciente { get; set; }
        public virtual Paciente_Asociado Paciente_Asociado { get; set; }
    }
}
