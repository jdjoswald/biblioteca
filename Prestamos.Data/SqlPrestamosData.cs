using Biblioteca.Data;
using Microsoft.EntityFrameworkCore;
using Prestamos.core;
using System.Collections.Generic;
using System.Linq;
namespace Prestamos.Data
{
    public class SqlPrestamosData : Iprestamos
    {
        private readonly bibliotecaDBContext db;

        public SqlPrestamosData(bibliotecaDBContext db)
        {
            this.db = db;
        }

        public Prestams Add(Prestams nuevoprestamo)
        {
            System.Console.WriteLine("anadio");
            db.Add(nuevoprestamo);
            return nuevoprestamo;
        }

        public int commit()
        {
            return db.SaveChanges();
        }

        public Prestams Delete(int id)
        {
            var prestam = GetByid(id);
            if (prestam != null)
            {
                db.Prestams.Remove(prestam);
            }
            return prestam;
        }

        public Prestams GetByid(int id)
        {
            return db.Prestams.Find(id);
            
        }

        public IEnumerable<Prestams> GetPrestamosByname(string name)
        {
            var query = from r in db.Prestams
                        where r.ID_Estado != 2
                        orderby r.ID_prestamos
                        select r;
            return query;

        }

        public Prestams update(Prestams updateprestam)
        {
            var entity = db.Prestams.Attach(updateprestam);
            entity.State = EntityState.Modified;
            return updateprestam;
        }
    }
}
