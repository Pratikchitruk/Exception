using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionDemo
{
    public class MobileNo
    {
        float mobileno = 8208508814;

        public void EnterNumber(float Number)
        {
            if (mobileno == 8208508814)
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
