using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionDemo
{
    public class LastNameException:Exception
    {
        public LastNameException(string message) : base(message)
        {


        }

    }
}
