
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
    
public partial class Cirugia
{

    public int id { get; set; }

    public string nombre { get; set; }

    public System.DateTime fecha { get; set; }

    public string donde { get; set; }

    public int ID_EXPEDIENTE { get; set; }



    public virtual Expediente Expediente { get; set; }

}

}
