using System;
using System.IO;

namespace Calculator
{
    class Program
    {
        private const string txt = "Sayi: ";

        static void Main(string[] args)
        {
            //CalculateFromConsole();
            CalculateFromFile();
            Console.ReadKey();
        }

        static void CalculateFromConsole()
        {
            var calc = new Calculator();
            var utility = new Utility();
            Console.Write(txt);

            var firstNumber = Console.ReadLine();
            if (utility.IsNUmeric(firstNumber))
                calc.FirstNumber = Convert.ToDouble(firstNumber);


            Console.Write("Islem ([+], [-], [*], [/]): ");
            calc.Process = Console.ReadLine();

            Console.Write(txt);

            var secondNumber = Console.ReadLine();

            if (utility.IsNUmeric(secondNumber))
                calc.SecondNumber = Convert.ToDouble(secondNumber);

            Console.Write(string.Format("Sonuc: {0}", calc.Calculate()));
        }

        static void CalculateFromFile()
        {
            var calc = new Calculator();
            var utility = new Utility();

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

            Console.Write(string.Format("{0} {1} {2} = {3}",calc.FirstNumber, calc.Process, calc.SecondNumber, calc.Calculate()));

        }
    } 
}
