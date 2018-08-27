using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpartaRepositorio.Categoria
{
    interface ICategoriaRepositorio
    {
        string CrearCategoria(SpartaDominio.Categoria entidad);
        List<SpartaDominio.Categoria> TraerCategorias();
    }
}
