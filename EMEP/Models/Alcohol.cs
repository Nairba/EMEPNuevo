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
