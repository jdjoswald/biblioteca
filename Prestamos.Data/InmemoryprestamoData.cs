using Prestamos.core;
using System;
using System.Collections.Generic;
using System.Linq;


namespace Prestamos.Data
{
    public class InmemoryprestamoData : Iprestamos
    {
        readonly List<Prestams> prestamo;
        public InmemoryprestamoData()
        {
            prestamo = new List<Prestams>()
            {
                
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
        public Prestams Add(Prestams nuevoprestamo)
        {

            prestamo.Add(nuevoprestamo);
            nuevoprestamo.ID_prestamos = prestamo.Max(r => r.ID_prestamos) + 1;
            nuevoprestamo.ID_Estado = 1;
            //nuevoprestamo.ID_usuario = 1;
            nuevoprestamo.Fecha_prestamo = DateTime.Now;
            
            
            
            return nuevoprestamo;
        }

        public Prestams Delete(int id)
        {
            var prestam = prestamo.FirstOrDefault(r => r.ID_prestamos == id);
            if (prestam != null)
            {
                prestamo.Remove(prestam);


            }
            return prestam;
        }
    }
}
