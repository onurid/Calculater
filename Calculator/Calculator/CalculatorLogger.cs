using System;

namespace Calculator
{
    class CalculatorLogger  : Calculator, ICalculatorLogger
    {
        public ICalculator _calc;

        public CalculatorLogger(ICalculator calc)
        {
            _calc = calc;
        }

        public CalculatorLogger()
        {

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
