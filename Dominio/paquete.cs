//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Dominio
{
    using System;
    using System.Collections.Generic;
    
    public partial class paquete
    {
        public int id_paquete { get; set; }
        public string nombre { get; set; }
        public Nullable<int> clasificacion_id_clasificacion { get; set; }
        public string descripcion { get; set; }
        public Nullable<int> id_lugar { get; set; }
        public Nullable<int> cantidad_personas { get; set; }
        public Nullable<decimal> precio { get; set; }
        public string pdf { get; set; }
        public string foto { get; set; }
        public string estado { get; set; }
    
        public virtual clasificacion clasificacion { get; set; }
        public virtual lugar lugar { get; set; }
    }
}
