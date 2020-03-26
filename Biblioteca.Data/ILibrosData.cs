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
        Liibros Upadate(Liibros updatedlibro);
        Liibros Upadateest(Liibros updatedlibro);
        Liibros Add(Liibros nuevolibro);

        int Commit();
        
       
        
    }
    public class InMemoryLibrosData : ILibrosData
    {
        readonly List<Liibros> libros;
        public InMemoryLibrosData()
        {
            libros = new List<Liibros>()
            {
                new Liibros {Titulo="astro fisica para tarados",ID_libro=1, ID_idioma=1 ,ID_estado=1,  pais=pais.republica_dominicana},
                new Liibros {Titulo="klk ",ID_libro=2,ID_idioma=1, ID_estado=1,  pais=pais.republica_dominicana},
                 new Liibros {Titulo="klk wawa",ID_libro=3,ID_idioma=1, ID_estado=1, ID_país=1, Serie="volumen 1", pais=pais.republica_dominicana},
                 new Liibros {Titulo="klk wa2wa",ID_libro=4,ID_idioma=1, ID_estado=2, ID_país=1, Serie="volumen 1", pais=pais.republica_dominicana}
             };

        }
        public Liibros Upadate(Liibros updatedlibro) 
        {
            var libro = libros.SingleOrDefault(r => r.ID_libro == updatedlibro.ID_libro);
            if(libro != null) 
            {
                libro.Ubicación_física = updatedlibro.Ubicación_física;
                libro.Titulo = updatedlibro.Titulo;
                libro.Paginas = updatedlibro.Paginas;
                libro.Idioma = updatedlibro.Idioma;
                
                libro.pais = updatedlibro.pais;
                libro.Resumen_del_documento = updatedlibro.Resumen_del_documento;
                libro.Publicación = updatedlibro.Publicación;
                libro.Serie = updatedlibro.Serie;
                libro.Notas = updatedlibro.Notas;
            }

            return libro;
        }
        public Liibros Add(Liibros nuevolibro) 
        {
            libros.Add(nuevolibro);
            nuevolibro.ID_libro = libros.Max(r => r.ID_libro)+1;
            nuevolibro.ID_estado = 2;
            return nuevolibro;
        }
        public Liibros Upadateest(Liibros updatedlibro)
        {
            var libro = libros.SingleOrDefault(r => r.ID_libro == updatedlibro.ID_libro);
            if (libro != null)
            {

                libro.ID_estado = updatedlibro.ID_estado;

            }

            return libro;
        }
        public int Commit() 
        {
            return 0;
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
