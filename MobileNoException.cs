using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionDemo
{
    public class MobileNoException:Exception
    {
        public MobileNoException(string message) : base(message)
        {


        }

    }
}
