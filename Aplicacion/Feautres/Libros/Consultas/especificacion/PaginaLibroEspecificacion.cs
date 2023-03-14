using Ardalis.Specification;
using Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.Feautres.Libros.Consultas.especificacion
{
    public class PaginaLibroEspecificacion : Specification<Libro>
    {
        public PaginaLibroEspecificacion(int tamanioPagina, int numeroPagina, string TituloLibro)
        {
            Query.Skip((numeroPagina - 1) * tamanioPagina).Take(tamanioPagina);
            if (!string.IsNullOrEmpty(TituloLibro))
            {
                Query.Search(x => x.TituloLibro, "%" + TituloLibro + "%");

            }
        }
    }
}
