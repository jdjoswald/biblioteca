using Prestamos.core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Prestamos.Data
{
    public interface Iprestamos
    {
        IEnumerable<Prestams> GetPrestamosByname(string name);
        Prestams GetByid(int id);
        Prestams update(Prestams updateprestam);
        int commit();


    }
    public class InmemoryprestamoData : Iprestamos
    {
        readonly List<Prestams> prestamo;
        public InmemoryprestamoData()
        {
            prestamo = new List<Prestams>()
            {
                new Prestams{ ID_prestamos=1, ID_libro=1, ID_usuario=1, ID_Estado=1 },
                new Prestams{ ID_prestamos=2, ID_libro=3, ID_usuario=2, ID_Estado=1 },
                new Prestams{ ID_prestamos=3, ID_libro=2, ID_usuario=1, ID_Estado=1 }
            };
        }
        public Prestams GetByid(int id)
        {
            return prestamo.SingleOrDefault(k => k.ID_prestamos == id);
        }
        public Prestams update(Prestams updateprestam)
        {
            var prestamu = prestamo.SingleOrDefault(r => r.ID_prestamos == updateprestam.ID_prestamos);
            if (prestamu != null)
            {
                prestamu.ID_Estado = updateprestam.ID_Estado;
            }
            return prestamu;
        }
        public int commit()
        {
            return 0;
        }
        public IEnumerable<Prestams> GetPrestamosByname(string name = null)
        {
            return from k in prestamo
                   where k.ID_Estado!=2
                  //where string.IsNullOrEmpty(name) || k.ID_prestamos.StartsWith(name)
                   orderby k.ID_prestamos
                   select k;
        }
    }
}
