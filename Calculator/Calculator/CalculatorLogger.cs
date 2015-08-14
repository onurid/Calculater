using System;

namespace Calculator
{
    class CalculatorLogger  : Calculator, ICalculatorLogger
    {
        public void CalculateLog()
        {
            Console.WriteLine("ilk sayi " + base.FirstNumber);

            Console.WriteLine("ikinci sayi " + base.SecondNumber);

            Console.WriteLine("sonuc " + base.Result);

            Console.ReadKey();
        }
    }
}
