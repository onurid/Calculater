using System;
using System.IO;

namespace Calculator
{
    class Program
    {
        private const string txt = "Sayi: ";

        static void Main(string[] args)
        {
            var calc = new Calculator();
            var utility = new Utility();

            CalculateFromConsole(calc,utility);

            CalculateFromFile(calc, utility);
            
            Console.ReadKey();
        }

        static void CalculateFromConsole(ICalculator calc, IUtility utility)
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

        static void CalculateFromFile(ICalculator calc, IUtility utility)
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
    } 
}
