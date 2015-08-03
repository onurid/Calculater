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
            calc.FirstNumber = Console.ReadLine();

            Console.Write("Islem ([+], [-], [*], [/]): ");
            calc.Process = Console.ReadLine();

            Console.Write(txt);
            calc.SecondNumber = Console.ReadLine();

            Console.Write(string.Format("Sonuc: {0}", calc.Calculate()));
            
            Console.ReadKey();
        }
    } 
}
