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
    
    public partial class PersonaPoliza
    {
        public long FKPersona { get; set; }
        public long FKPoliza { get; set; }
        public Nullable<int> TipoCliente { get; set; }
    
        public virtual Persona Persona { get; set; }
        public virtual Poliza Poliza { get; set; }
    }
}