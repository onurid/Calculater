using System;

namespace Calculator
{
    class CalculatorLogger  : ICalculatorLogger
    {
        public void CalculateLog(ICalculator calc)
        {
            Console.WriteLine("ilk sayi " + calc.FirstNumber);

            Console.WriteLine("ikinci sayi " + calc.SecondNumber);

            Console.WriteLine("sonuc " + calc.Result);

            Console.ReadKey();
        }
    }
}
