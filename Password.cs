using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionDemo
{
    public class Password
    {
        float password = 12345678;

        public void EnterPassword(float Number)
        {
            if (password == 12345678)
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
