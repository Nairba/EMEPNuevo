
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
