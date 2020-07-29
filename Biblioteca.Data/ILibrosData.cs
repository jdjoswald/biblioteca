using Biblioteca.core;
using System.Collections.Generic;
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
        Liibros Delete(int id);

        int Commit();
 
    }
}
