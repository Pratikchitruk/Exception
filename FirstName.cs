using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionDemo
{
   public class FirstName
    {
        string firstname = "Pratik";

        public void EnterFirstName(string name)
        {
            if (firstname == "Pratik")
            {
                throw (new FirstnameException("name found"));


            }
            else
            { 
            Console.WriteLine("the name is "+name);
            }
        
        }
        
        
        
        
        
    }
}
