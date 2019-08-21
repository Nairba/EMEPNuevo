
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
    
public partial class Lista_Enfermedad
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public Lista_Enfermedad()
    {

        this.Enfermedad_Expediente = new HashSet<Enfermedad_Expediente>();

        this.Enfermedad_Familiar = new HashSet<Enfermedad_Familiar>();

    }


    public int id { get; set; }

    public string descripcion { get; set; }

    public int ID_CATEGORIA { get; set; }

    public int estado { get; set; }

    public Nullable<int> ID_EXPEDIENTE { get; set; }

    public byte[] img { get; set; }



    public virtual Categoria Categoria { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<Enfermedad_Expediente> Enfermedad_Expediente { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<Enfermedad_Familiar> Enfermedad_Familiar { get; set; }

}

}
