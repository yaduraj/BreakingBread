using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BreakingBread.Service
{
    public class UserService
    {

        public IEnumerable<User> GetAllUsers()
        {

            List<User> users = new List<User>();
            return users;
        }

        public User CreateUser(User user)
        {
            var component = new UserComponent();
            component.AddUser(user);
            return user;
        }

    }
}