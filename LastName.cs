using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionDemo
{
    public class LastName
    {
        string lastname = "Chitruk";

        public void EnterLastName(string name)
        {
            if (lastname == "Chitruk")
            {
                throw (new LastNameException("name found"));


            }
            else
            {
                Console.WriteLine("the name is " + name);
            }

        }
    }
}
