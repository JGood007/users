using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace testapi.Model
{
    public interface IUsers
    {
        IEnumerable<Users> GetAll();
        Users GetUser(int id);
        Users AddUser(Users users);
        Users UpdateUser(int id, Users users);
        Users DeleteUser(int id);
    }
}
