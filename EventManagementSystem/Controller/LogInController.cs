using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManagementSystem.Controller
{
    class LogInController
    {

        private int typeofUser;
        public int TypeOfUser {
            set { typeofUser = value; }
            get { return typeofUser; }
        }

        private string userName;
        public string UserName
        {
            set { userName = value; }
            get { return userName; }
        }

        private string password;
        public string Password {
            set { password = value; }
            get { return password; }
        }
        
            
    }
}
