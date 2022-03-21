using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionDemo
{
    public class PasswordRule1
    {
        string password = "12345678P";

        public void EnterPassword(string Number)
        {
            if (password == "12345678P")
            {
                throw (new FirstnameException("number found"));


            }
            else
            {
                Console.WriteLine("the email is " + Number);
            }

        }
    }
}
