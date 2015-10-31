using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BreakingBread.Service
{
    public class UsersController : ApiController
    {
        // GET api/values
        [HttpGet]
        public IEnumerable<User> GetAllUsers()
        {
            return new User[] { new User("Adhar","11.adhar@gmail.com", 8886781736), 
                                new User("Yaduraj","yaduragarwal@gmail.com", 87377378993)};
        }

        [HttpPost]
        public User CreateUser(User user)
        {
            var service = new UserService();
            return service.CreateUser(user);
        }
        
    }
}
