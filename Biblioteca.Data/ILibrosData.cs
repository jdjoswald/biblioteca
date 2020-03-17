using Biblioteca.core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Biblioteca.Data
{
    public interface ILibrosData
    {
        IEnumerable<Liibros> GetLibrosByName(string name);
        Liibros GetByid(int id);
    }
    public class InMemoryLibrosData : ILibrosData
    {
        readonly List<Liibros> libros;
        public InMemoryLibrosData()
        {
            libros = new List<Liibros>()
            {
                new Liibros {Titulo="astro fisica para tarados",ID_libro=1, ID_idioma=1 ,ID_estado=2,  pais=pais.republica_dominicana},
                new Liibros {Titulo="klk wawa",ID_libro=2,ID_idioma=1,  pais=pais.republica_dominicana},
                 new Liibros {Titulo="klk wawa",ID_libro=3,ID_idioma=1, ID_país=1, Serie="volumen 1", pais=pais.republica_dominicana}
             };

        }
        public Liibros GetByid(int id)
        {
            return libros.SingleOrDefault(r => r.ID_libro == id);
        }
        public IEnumerable<Liibros> GetLibrosByName(string name = null)
        {
            return from r in libros
                   where string.IsNullOrEmpty(name)|| r.Titulo.StartsWith(name) 
                   select r;


        }
    }
}
