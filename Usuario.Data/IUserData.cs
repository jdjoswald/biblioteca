using System.Collections.Generic;
using System.Text;
using Usuario.core;

namespace Usuario.Data
{
    public interface IUserData
     {
        IEnumerable<Users> GetUserBYName(string name);
        IEnumerable<Users> GetuserByCedula2(string name);
        Users GetuserByCedula(string ced);
        Users GetuserByid (int idu);
        Users update(Users updateuser);
        public Users update2(Users updateuser);
        Users Add(Users nuevouser);
        Users Delete(int id);
        int commit();
        
     }
    
}
