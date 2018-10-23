using Dominio;
using Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio
{
    public class EstadoEventoBLL
    {
        private EstadoEventoRepositorio repositorio = new EstadoEventoRepositorio();

        public bool InsertarEstadoEvento(estado_evento estadoEvento)
        {
            return repositorio.InsertarEstadoEvento(estadoEvento);
        }

        public bool ActualizarEstadoEvento(estado_evento estadoEvento)
        {
            return repositorio.ActualizareEstadoEvento(estadoEvento);

        }

        public bool EliminarEstadoEvento(estado_evento estadoEvento)
        {
            return repositorio.EliminarEstadoEvento(estadoEvento);

        }

        public List<estado_evento> ObtenerEstadoEventoes()
        {
            return repositorio.ObtenerEstadoEventos();

        }

        public List<estado_evento> FiltrarEstadoEventos(int idEstadoEvento, string nombreEstadoEvento)
        {
            return repositorio.FiltrarEstadosEventos(idEstadoEvento, nombreEstadoEvento);
        }
    }
}
