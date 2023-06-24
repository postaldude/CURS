using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRPOCUR
{
    class User
    {
        private static string _username;

        public string username { get { return _username; } set { if (username != "") _username = username; } }

        public User() { }
        public User(string user)
        {
            _username = user;
        }
    }
}
