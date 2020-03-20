using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Usuario.core;

namespace Usuario.Data
{
     public interface IUserData
    {
        IEnumerable<Users> GetUserBYName(string name);
        Users GetuserByCedula(string ced);
        Users GetuserByid (int idu);
        
    }
    public class InMemoryUserData : IUserData 
    {
        readonly List<Users> usuario;
        public InMemoryUserData() 
        {
            usuario = new List<Users>() 
            {
            new Users { ID_usuario = 1, Nombre="joswald", Cedula= "40214978987" },
            new Users { ID_usuario = 2, Nombre="Aylin", Cedula = "40214978988", tardanzas = 2}
            };
        }
        public Users GetuserByCedula(string ced) 
        { 
            return usuario.SingleOrDefault(b =>b.Cedula == ced);
        }
        public Users GetuserByid(int idu) 
        {
            return usuario.SingleOrDefault(b => b.ID_usuario == idu);
        }

        public IEnumerable<Users> GetUserBYName(string name = null) 
        {
            return from b in usuario
                   where string.IsNullOrEmpty(name) || b.Nombre.StartsWith(name)
                   orderby b.Nombre
                   select b;
        }
    }
}
