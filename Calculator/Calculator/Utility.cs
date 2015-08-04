using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Utility
    {
        public bool IsNUmeric(string value)
        {
            double number;
            return double.TryParse(value, out number);
        }
    }
}
