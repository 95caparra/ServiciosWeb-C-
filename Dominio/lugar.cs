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
    
    public partial class lugar
    {
        public int id_lugar { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public Nullable<int> cantidad_persona_max { get; set; }
        public string direccion { get; set; }
        public string ubicacion { get; set; }
        public string contacto { get; set; }
        public string telefono_contacto { get; set; }
        public Nullable<int> id_ciudad { get; set; }
    
        public virtual ciudad ciudad { get; set; }
    }
}
