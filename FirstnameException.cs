﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionDemo
{
    public class FirstnameException:Exception
    {
        public FirstnameException(string message) : base(message)
        { 
        
        
        }
    }
}
