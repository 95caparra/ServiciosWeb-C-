//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SpartaDominio
{
    using System;
    using System.Collections.Generic;
    
    public partial class ParticipantePremio
    {
        public long IdParticipantePremio { get; set; }
        public long FKPremio { get; set; }
        public Nullable<int> Sucursal { get; set; }
        public Nullable<int> Ciudad { get; set; }
        public Nullable<int> PuntoVenta { get; set; }
        public Nullable<int> Categoria { get; set; }
    
        public virtual Premio Premio { get; set; }
    }
}
