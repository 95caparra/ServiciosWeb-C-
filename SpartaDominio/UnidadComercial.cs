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
    
    public partial class UnidadComercial
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public UnidadComercial()
        {
            this.Persona = new HashSet<Persona>();
        }
    
        public int IdUnidadComercial { get; set; }
        public string DescripcionUnidadComercial { get; set; }
        public int FKSucursal { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Persona> Persona { get; set; }
        public virtual Sucursal Sucursal { get; set; }
    }
}