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
    
    public partial class Paciente
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Paciente()
        {
            this.Compartir_Expediente = new HashSet<Compartir_Expediente>();
            this.Expediente = new HashSet<Expediente>();
            this.Paciente_Paciente_Asociado = new HashSet<Paciente_Paciente_Asociado>();
        }
    
        public string correo { get; set; }
        public string cedula { get; set; }
        public string nombre { get; set; }
        public string p_Apellido { get; set; }
        public string s_Apellido { get; set; }
        public string contrasenna { get; set; }
        public string sexo { get; set; }
        public int estado { get; set; }
        public int ID_TIPO_USUARIO { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Compartir_Expediente> Compartir_Expediente { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Expediente> Expediente { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Paciente_Paciente_Asociado> Paciente_Paciente_Asociado { get; set; }
        public virtual Tipo_Usuario Tipo_Usuario { get; set; }
    }
}
