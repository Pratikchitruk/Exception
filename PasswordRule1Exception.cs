using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionDemo
{
    public class PasswordRule1Exception:Exception
    {
        public PasswordRule1Exception(string message) : base(message)
        {


        }
    }
}
