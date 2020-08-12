using Prestamos.core;
using System.Collections.Generic;
using System.Text;


namespace Prestamos.Data
{
    public interface Iprestamos
    {
        IEnumerable<Prestams> GetPrestamosByname(string name);
        Prestams GetByid(int id);
        Prestams update(Prestams updateprestam);
        Prestams Delete(int id);
        Prestams Add(Prestams nuevoprestamo);
        int commit();


    }
}
