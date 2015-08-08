using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class CalculatorLogger  : Calculator, ICalculatorLogger
    {
        private static ICalculator _calc;

        public CalculatorLogger(ICalculator calc)
        {
            _calc = calc;
        }
        
        public void CalculateLog()
        {
            Console.WriteLine("ilk sayi " + _calc.FirstNumber);

            Console.WriteLine("ikinci sayi " + _calc.SecondNumber);

            Console.WriteLine("sonuc " + _calc.Result);

            Console.ReadKey();
        }
    }
}
