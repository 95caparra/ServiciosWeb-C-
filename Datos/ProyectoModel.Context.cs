﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Datos
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using Dominio;
    
    public partial class ProyectoGradoEntities : DbContext
    {
        public ProyectoGradoEntities()
            : base("name=ProyectoGradoEntities")
        {
    		Configuration.ProxyCreationEnabled = false;
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ciudad> ciudad { get; set; }
        public virtual DbSet<clasificacion> clasificacion { get; set; }
        public virtual DbSet<cliente> cliente { get; set; }
        public virtual DbSet<detalle_empleado> detalle_empleado { get; set; }
        public virtual DbSet<detalle_producto_suministro> detalle_producto_suministro { get; set; }
        public virtual DbSet<detalle_proveedor> detalle_proveedor { get; set; }
        public virtual DbSet<empleado> empleado { get; set; }
        public virtual DbSet<estado_evento> estado_evento { get; set; }
        public virtual DbSet<evento> evento { get; set; }
        public virtual DbSet<lugar> lugar { get; set; }
        public virtual DbSet<medida_producto> medida_producto { get; set; }
        public virtual DbSet<paquete> paquete { get; set; }
        public virtual DbSet<producto> producto { get; set; }
        public virtual DbSet<proveedor> proveedor { get; set; }
        public virtual DbSet<rol> rol { get; set; }
        public virtual DbSet<solicitud> solicitud { get; set; }
        public virtual DbSet<suministro> suministro { get; set; }
        public virtual DbSet<tipo_documento> tipo_documento { get; set; }
        public virtual DbSet<tipo_evento> tipo_evento { get; set; }
        public virtual DbSet<tipo_producto> tipo_producto { get; set; }
        public virtual DbSet<usuario> usuario { get; set; }
        public virtual DbSet<pedido> pedido { get; set; }
    }
}