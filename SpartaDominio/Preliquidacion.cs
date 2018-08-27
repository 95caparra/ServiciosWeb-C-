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
    
    public partial class Preliquidacion
    {
        public long IdPreliquidacion { get; set; }
        public Nullable<long> FKUsuario { get; set; }
        public Nullable<long> FKDocumento { get; set; }
        public Nullable<int> Estado { get; set; }
        public System.DateTime FechaPreliquidacion { get; set; }
        public Nullable<int> FrecuenciaEmision { get; set; }
        public System.TimeSpan HoraEmision { get; set; }
        public decimal ValorMinimoEmision { get; set; }
        public System.DateTime TiempoMaxEmision { get; set; }
        public System.DateTime TiempoMaxVigencia { get; set; }
        public System.DateTime TiempoMaxConsultaRecaudo { get; set; }
        public System.DateTime TiempoActNotEmision { get; set; }
        public System.DateTime TiempoActNotVencimiento { get; set; }
        public int DiasBotonCargue { get; set; }
    
        public virtual Documento Documento { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}
