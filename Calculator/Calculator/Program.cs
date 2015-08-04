using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        private const string txt = "Sayi: ";

        static void Main(string[] args)
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
            
            Console.ReadKey();
        }
    } 
}
