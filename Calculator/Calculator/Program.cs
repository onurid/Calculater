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
            Console.Write(txt);
            Calculator.Val1 = Console.ReadLine();

            Console.Write("Islem ([+], [-], [*], [/]): ");
            Calculator.Process = Console.ReadLine();   
            
            Console.Write(txt);
            Calculator.Val2 = Console.ReadLine();
            
            Console.Write(string.Format("Sonuc: {0}",Calculator.Calculate()));
            
            Console.ReadKey();
        }
    } 
}
