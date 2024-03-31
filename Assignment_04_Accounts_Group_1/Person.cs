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
        private bool isAuthenticated;

        public string Password { get => password; set => password = value; }
        public string Sin { get; set; }
        public string Name { get; set; }

        public event EventHandler<LoginEventArgs> Onlogin;

        public bool IsAuthenticated { get => isAuthenticated; private set => isAuthenticated = value; }

        public Person(string name, string sin)
        {
            Name = name;
            Sin = sin;
            password = Sin.Substring(0, 4);
        }

        public void Login(string passwordS)
        {
            if (passwordS != password)
            {
                IsAuthenticated = false;
                Onlogin?.Invoke(this, new LoginEventArgs(this.Name,false)); 
                throw new Exception((ExceptionType.PASSWORD_INCORRECT).ToString());
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
