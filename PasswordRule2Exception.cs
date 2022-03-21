using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptiondemo
{
    public class PasswordRule2Exception:Exception
    {
        public PasswordRule2Exception(string message) : base(message)
        {


        }

    }
}
