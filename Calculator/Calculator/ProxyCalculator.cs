using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class ProxyCalculator : CalculatorLogger
    {
        public ProxyCalculator(ICalculator calc)
        {
            this._calc  = calc;
        }

        public void Doit()
        {
            CalculateLog();
        }

    }
}
