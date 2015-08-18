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

            var calcLog = new CalculatorLogger();
            calcLog.CalculateLog(calc);
        }
    }
}
