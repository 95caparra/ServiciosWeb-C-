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
    
    public partial class detalle_proveedor
    {
        public int Id { get; set; }
        public Nullable<int> proveedor_id_proveedor { get; set; }
        public Nullable<int> producto_id_suministro { get; set; }
        public string estado { get; set; }
    
        public virtual proveedor proveedor { get; set; }
        public virtual suministro suministro { get; set; }
    }
}
