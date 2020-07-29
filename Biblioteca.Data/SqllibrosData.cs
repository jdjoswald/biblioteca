using Biblioteca.core;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Biblioteca.Data
{
    public class SqllibrosData : ILibrosData
    {
        private readonly bibliotecaDBContext db;

        public SqllibrosData(bibliotecaDBContext db)
        {
            this.db = db;
        }

        public bibliotecaDBContext Db { get; }

        public Liibros Add(Liibros nuevolibro)
        {
            db.Add(nuevolibro);
            return nuevolibro;
        }

        public int Commit()
        {
           return db.SaveChanges();
        }

        public Liibros Delete(int id)
        {
            var libro = GetByid(id);
            if (libro != null)
            {
                db.Liibros.Remove(libro);

            }
            return libro;

        }

        public Liibros GetByid(int id)
        {
            return db.Liibros.Find(id);
        }

        public IEnumerable<Liibros> GetLibrosByName(string name)
        {
            var query = from r in db.Liibros
                        where r.Titulo.StartsWith(name) || string.IsNullOrEmpty(name)
                        orderby r.Titulo
                        select r;
            return query;
        }

        public Liibros Upadate(Liibros updatedlibro)
        {
            var entity = db.Liibros.Attach(updatedlibro);
            entity.State = EntityState.Modified;
            return updatedlibro;
        }

        public Liibros Upadateest(Liibros updatedlibro)
        {
            var entity = db.Liibros.Attach(updatedlibro);
            entity.State = EntityState.Modified;
            return updatedlibro;
        }
    }
}
