using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_04_Accounts_Group_1
{
    public class LoginEventArgs : EventArgs
    {
        public string PersonName { get; set; }
        public bool Success { get; set; }

        public LoginEventArgs(string personName, bool success)
        {
            PersonName = personName;
            Success = success;
        }
    }

}
