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
    
    public partial class LogProceso
    {
        public long IdLogProceso { get; set; }
        public string Proceso { get; set; }
        public string DescripcionError { get; set; }
        public System.DateTime FechaProceso { get; set; }
        public int ExecutionId { get; set; }
        public string Modulo { get; set; }
    }
}
