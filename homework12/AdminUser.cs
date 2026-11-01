using System;
using System.Collections.Generic;
using System.Text;

namespace homework12
{
    internal class Admin : User
    {
        public Admin(string name, string password, string email) : base(name, password, email)
        {
        }

        public override bool Authorize(string email, string password)
        {
            return Email == email && Password == password;
        }
    }
}
