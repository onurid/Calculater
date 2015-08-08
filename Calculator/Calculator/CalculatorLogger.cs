﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class CalculatorLogger
    {
        public CalculatorLogger()
        {
            ICalculator calc = new Calculator();


            CalculateFromConsole(calc, new Utility());

            Console.WriteLine("ilk sayi " + calc.FirstNumber);

            Console.WriteLine("ikinci sayi " + calc.SecondNumber);

            Console.WriteLine("sonuc " + calc.Result);


            CalculateFromFile(calc, new Utility());


            Console.WriteLine("ilk sayi " + calc.FirstNumber);

            Console.WriteLine("ikinci sayi " + calc.SecondNumber);

            Console.WriteLine("sonuc " + calc.Result);


            ISalaryCalculator salarycalc = new SalaryCalculator();

            SalaryCalculateFromConsole(salarycalc);

            Console.WriteLine("calistigi gun sayisi " + salarycalc.NumberOfDays);

            Console.WriteLine("gunluk yevmiye " + salarycalc.DailyWages);

            Console.WriteLine("maasi " + salarycalc.Salary);

            Console.ReadKey();
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
