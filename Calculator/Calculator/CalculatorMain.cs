using System;
using System.IO;

namespace Calculator
{
    class CalculatorMain
    {
        private ProxyCalculator proxyCalc;
        public CalculatorMain ()
        {
            proxyCalc = new ProxyCalculator();
        }
        public void Start()
        {
            CalculateFromConsole(proxyCalc, new Utility());
        }

        void CalculateFromConsole(ICalculator calc, IUtility utility)
        {
            var firstNumber = Console.ReadLine();
            if (utility.IsNUmeric(firstNumber))
                calc.FirstNumber = Convert.ToDouble(firstNumber);

            calc.Process = Console.ReadLine();

            var secondNumber = Console.ReadLine();

            if (utility.IsNUmeric(secondNumber))
                calc.SecondNumber = Convert.ToDouble(secondNumber);

            calc.Calculate();
        }

        void CalculateFromFile(ICalculator calc, IUtility utility)
        {
            var read = File.OpenText(@"c:\Calculate_Log.txt");

            string txt;
            var counter = 0;

            while ((txt = read.ReadLine()) != null)
            {
                if (counter == 0)
                    calc.Process = txt;

                if (counter == 1)
                {
                    if (utility.IsNUmeric(txt))
                        calc.FirstNumber = Convert.ToDouble(txt);
                }
                if (counter == 2)
                {
                    if (utility.IsNUmeric(txt))
                        calc.SecondNumber = Convert.ToDouble(txt);
                }
                counter++;
            }

            read.Close();

            calc.Calculate();
        }

        static void SalaryCalculateFromConsole(ISalaryCalculator salarycalc)
        {
            var numberOfDays = Console.ReadLine();

            salarycalc.NumberOfDays = Convert.ToInt32(numberOfDays);

            var dailyWages = Console.ReadLine();

            salarycalc.DailyWages = Convert.ToInt32(dailyWages);

            salarycalc.SalaryCalculate();
        }
    }
}
