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
    
    public partial class cliente
    {
        public long id_cliente { get; set; }
        public string n_identificacion { get; set; }
        public int tipo_documento { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string telefono { get; set; }
        public string celular { get; set; }
        public string direccion { get; set; }
        public Nullable<int> ciudad { get; set; }
        public string correo { get; set; }
        public string estado { get; set; }
    
        public virtual ciudad ciudad1 { get; set; }
        public virtual tipo_documento tipo_documento1 { get; set; }
    }
}