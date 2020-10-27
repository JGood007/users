using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace testapi.Model
{
    public class UsersMockRepository : IUsers
    {
        private List<Users> _users;

        public UsersMockRepository()
        {
            _users = new List<Users>()
            {
                new Users()
                {
                    id=1,
                    name="Sancho James Inocencio",
                    emailaddress="sj@pwc.com"
                },
                new Users()
                {
                    id=2,
                    name="Menar Ten",
                    emailaddress="menar10@pwc.com"
                }
            };
        }

        public Users AddUser(Users users)
        {
            users.id = 1;
            if (_users.Count() != 0)
                users.id = _users.Max(e => e.id) + 1;
            _users.Add(users);
            return users;
        }

        public Users DeleteUser(int id)
        {
            Users deleteUser = _users.FirstOrDefault(e => e.id == id);
            _users.Remove(deleteUser);
            return deleteUser;
        }

        public IEnumerable<Users> GetAll()
        {
            return _users;
        }

        public Users GetUser(int id)
        {
            return _users.FirstOrDefault(e => e.id == id);
        }

        public Users UpdateUser(int id, Users users)
        {
            Users updateUser = _users.FirstOrDefault(e => e.id == id);
            updateUser.name = users.name;
            updateUser.emailaddress = users.emailaddress;
            return updateUser;
        }
    }
}
