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
    
    public partial class detalle_empleado
    {
        public long evento_id_evento { get; set; }
        public Nullable<long> empleado_id_empleado { get; set; }
        public Nullable<double> calificacion { get; set; }
        public string estado { get; set; }
        public long id_detalle_empleado { get; set; }
    
        public virtual empleado empleado { get; set; }
    }
}
