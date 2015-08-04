using System;
using System.Collections.Generic;
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

            Console.Write(txt);

            var firstNumber = Console.ReadLine();
            double val1;
            if (double.TryParse(firstNumber, out val1))
                calc.FirstNumber = Convert.ToDouble(firstNumber);
           

            Console.Write("Islem ([+], [-], [*], [/]): ");
            calc.Process = Console.ReadLine();

            Console.Write(txt);

            var secondNumber = Console.ReadLine();
            double val2;
            if (double.TryParse(secondNumber, out val1))
                calc.SecondNumber = Convert.ToDouble(secondNumber);


            Console.Write(string.Format("Sonuc: {0}", calc.Calculate()));
            
            Console.ReadKey();
        }
    } 
}
