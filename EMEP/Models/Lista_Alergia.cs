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
    
    public partial class Lista_Alergia
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Lista_Alergia()
        {
            this.Expediente_Alergia = new HashSet<Expediente_Alergia>();
        }
    
        public int id { get; set; }
        public string descripcion { get; set; }
        public int ID_CATEGORIA { get; set; }
        public int estado { get; set; }
        public string reaccion { get; set; }
        public string observaciones { get; set; }
        public Nullable<int> ID_EXPEDIENTE { get; set; }
        public string img { get; set; }
    
        public virtual Categoria_Alergia Categoria_Alergia { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Expediente_Alergia> Expediente_Alergia { get; set; }
    }
}
