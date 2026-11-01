using System;
using System.Collections.Generic;
using System.Text;

namespace homework12
{
    internal abstract class User
    {

        public User()
        {
        }
        protected User(string name, string password, string email)
        {
            Name = name;
            Password = password;
            Email = email;
        }

        public string Name { get; set; }

        public string Password { get; set; }

        private string _email;

        public string Email
        {
            get { return _email; }
            set
            {
                if (value.Contains("@"))
                {
                    _email = value;
                }
                else
                {
                    Console.WriteLine("Invalid email");

                }

            }
        }

        public abstract bool Authorize(string email, string password);


    }
}
