using Dominio;
using Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio
{
    public class CiudadesBLL
    {
        private CiudadRepositorio repositorio = new CiudadRepositorio();

        public bool InsertarCiudad(ciudad ciudad)
        {
           return repositorio.InsertarCiudad(ciudad);
        }

        public bool ActualizarCiudad(ciudad ciudad)
        {
            return repositorio.ActualizarCiudad(ciudad);
        }

        public bool EliminarCiudad(ciudad ciudad)
        {
            return repositorio.EliminarCiudad(ciudad);

        }

        public List<ciudad> ObtenerCiudades()
        {
            return repositorio.ObtenerCiudades();

        }

        public List<ciudad> FiltrarCiudades(int idCiudad, string nombreCiudad)
        {
            return repositorio.FiltrarCiudades(idCiudad,nombreCiudad);
        }
    }

}

