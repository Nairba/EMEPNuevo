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
    
    public partial class Otra_Enfermedad
    {
        public int id { get; set; }
        public string descripciom { get; set; }
        public string categoria { get; set; }
        public Nullable<int> estado { get; set; }
        public string img { get; set; }
        public Nullable<int> ID_EXPEDIENTE { get; set; }

        public string estado_String { get; set; }
        public virtual Expediente Expediente { get; set; }
    }
}
