﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleNumber.Library
{
    public class MultipleResult
    {
        public string GetValue_OfMultipleNumber(int n)
        {
            if (n % 3 == 0 && n % 5 == 0)
                return "FizzBuzz";
            else if (n % 5 == 0)
                return "Buzz";
            else if (n % 3 == 0)
                return "Fizz";
            else
                return n.ToString();
        }
    }
}
