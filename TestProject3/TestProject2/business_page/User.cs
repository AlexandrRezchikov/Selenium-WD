using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestProject2.business_page
{
    class User
    {
        public User(string nameUser, string passwordUser)
        {
            this.nameUser = nameUser;
            this.passwordUser = passwordUser;
        }

        public string nameUser { get; set; }
        public string passwordUser { get; set; }
    }
}
