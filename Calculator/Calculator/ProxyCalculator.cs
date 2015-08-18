using System;
using System.CodeDom;

namespace Calculator
{
    class ProxyCalculator : ICalculator
    {
        private Calculator calc;
        public ProxyCalculator()
        {
            calc = new Calculator();
        }

        public double FirstNumber { get; set; }
        public double SecondNumber { get; set; }
        public double Result { get; set; }
        public string Process { get; set; }

        public void Calculate()
        {
            calc.FirstNumber = this.FirstNumber;
            calc.SecondNumber = this.SecondNumber;
            calc.Process = this.Process;
            calc.Calculate();
            
            CalculateLog(calc);
        }

        public void CalculateLog(ICalculator calc)
        {
            Console.WriteLine("ilk sayi " + calc.FirstNumber);

            Console.WriteLine("ikinci sayi " + calc.SecondNumber);

            Console.WriteLine("sonuc " + calc.Result);

            Console.ReadKey();
        }
    }
}
