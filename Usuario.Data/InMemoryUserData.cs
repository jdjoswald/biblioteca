using System;
using System.Collections.Generic;
using System.Linq;
using Usuario.core;

namespace Usuario.Data
{
    public class InMemoryUserData : IUserData 
    {
        readonly List<Users> usuario;

        public InMemoryUserData() 
        {
            usuario = new List<Users>() 
            {
            new Users { ID_usuario = 1, Nombre="joswald", Cedula= "40214978987" },
            new Users { ID_usuario = 3, Nombre="joswald2", Cedula= "40214968787" },
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
        public Users update(Users updateuser) 
        {
            var persona = usuario.SingleOrDefault(r => r.ID_usuario == updateuser.ID_usuario);
            if (persona != null) 
            {
                persona.tardanzas = updateuser.tardanzas;
            }
            return persona;
        }
        public Users update2(Users updateuser)
        {
            var persona = usuario.SingleOrDefault(r => r.ID_usuario == updateuser.ID_usuario);
            if (persona != null)
            {
                persona.tardanzas++;
            }
            return persona;
        }
        public int commit() 
        { 
            return 0; 
        }

        public IEnumerable<Users> GetUserBYName(string name = null) 
        {
            return from b in usuario
                   where string.IsNullOrEmpty(name) || b.Nombre.StartsWith(name)
                   orderby b.Nombre
                   select b;
        }
        public Users Add(Users nuevouser) 
        {

            usuario.Add(nuevouser);
            nuevouser.ID_usuario = usuario.Max(r => r.ID_usuario)+1;
            return nuevouser;
        }
        public IEnumerable<Users> GetuserByCedula2(string name = null)
        {
            return from b in usuario
                   where string.IsNullOrEmpty(name) || b.Cedula.StartsWith(name)
                   orderby b.Nombre
                   select b;
        }

        public Users delete(Users up)
        {
            return null;
        }

        public Users Delete(int id)
        {
            var user = usuario.FirstOrDefault(r => r.ID_usuario == id);
            if (user != null) 
            {
                usuario.Remove(user);
            }
            return user;
        }
    }
}
