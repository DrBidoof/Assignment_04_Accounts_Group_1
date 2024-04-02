using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_04_Accounts_Group_1
{
    public class Person
    {
        private string password;
        public event EventHandler<LoginEventArgs> Onlogin;

        public string Sin { get; set; }
        public string Name { get; set; }
        public bool IsAuthenticated { get; private set; }


        public Person(string name, string sin)
        {
            Name = name;
            Sin = sin;
            password = Sin.Substring(0, 3);
        }

        public void Login(string passwordS)
        {
            if (passwordS != password)
            {
                IsAuthenticated = false;
                Onlogin?.Invoke(this, new LoginEventArgs(this.Name, false));
                AccountException passwordIncorrect = new AccountException(ExceptionType.PASSWORD_INCORRECT);
                throw (passwordIncorrect);
            }
            else
            {
                IsAuthenticated = true;
                Onlogin?.Invoke(this, new LoginEventArgs(this.Name, true));
            }
        }
        public void Logout()
        {
            IsAuthenticated = false;
        }

        public override string ToString()
        {
            return $"{Name} - Authenticated: {IsAuthenticated}";
        }
    }
}
