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
    
    public partial class Alcohol
    {
        public int id { get; set; }
        public int activo { get; set; }
        public Nullable<int> inicio { get; set; }
        public Nullable<int> frecuencia { get; set; }
        public string tipo { get; set; }
        public Nullable<int> cant_tipo { get; set; }
        public string observaciones { get; set; }
        public int ID_EXPEDIENTE { get; set; }
    
        public virtual Expediente Expediente { get; set; }
    }
}