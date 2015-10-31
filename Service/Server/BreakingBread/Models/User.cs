using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BreakingBread.Service
{
    public class User
    {

        #region Constructor

        public User() { 
        
        }

        public User(string name, string email, long mobile)
        {
            Name = name;
            UserId = email;
            MobileNumber = mobile;
        }

        #endregion

        #region properties

        /// <summary>
        /// The Name of User
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Email id of User
        /// </summary>
        public string UserId { get; set; }

        /// <summary>
        /// Mobile number of user
        /// </summary>
        public long MobileNumber { get; set; }

        #endregion

    }
}