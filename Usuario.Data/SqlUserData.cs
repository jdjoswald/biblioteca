using Biblioteca.Data;
using System.Collections.Generic;
using Usuario.core;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Usuario.Data
{
    public class SqlUserData : IUserData
    {
        private readonly bibliotecaDBContext db;

        public SqlUserData(bibliotecaDBContext db)
        {
            this.db = db;
        }

        public Users Add(Users nuevouser)
        {
            db.Add(nuevouser);
            return nuevouser;
        }

        public int commit()
        {
            
            return db.SaveChanges();
        }

        public Users Delete(int id)
        {
            var usuario = GetuserByid(id);
            if (usuario!= null) 
            {
                db.Users.Remove(usuario);
            }
            return usuario;
        }

        public Users GetuserByCedula(string ced)
        {
            Users usuario = db.Users.SingleOrDefault(Users => Users.Cedula==ced);
            return usuario;
        }

        public IEnumerable<Users> GetuserByCedula2(string name)
        {
            var query = from r in db.Users
                        where r.Nombre.StartsWith(name) || string.IsNullOrEmpty(name)
                        orderby r.Nombre
                        select r;
            return query;
        }

        public Users GetuserByid(int idu)
        {
            return db.Users.Find(idu);
        }

        public IEnumerable<Users> GetUserBYName(string name)
        {
            var query = from r in db.Users
                        where r.Nombre.StartsWith(name) || string.IsNullOrEmpty(name)
                        orderby r.Nombre
                        select r;
            return query;
        }

        public Users update(Users updateuser)
        {
            var entity = db.Users.Attach(updateuser);
            entity.State = EntityState.Modified;
            return updateuser;
        }

        public Users update2(Users updateuser)
        {
            var entity = db.Users.Attach(updateuser);
            entity.State = EntityState.Modified;
            return updateuser;
        }
    }

}
