using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Console Calculator: Your trusted source for second-grade mathematics!\n");
            Console.WriteLine("Current functionality: \n-Add two numbers together\n");

            Calculator doCalc = new Calculator();

            Console.WriteLine("Input the first number:");
            doCalc.Input1 = Console.ReadLine();

            Console.WriteLine("\nInput the next number:");
            doCalc.Input2 = Console.ReadLine();


            Console.WriteLine("\nEquals: {0}", doCalc.Addition());

            Console.ReadLine();
        }
    }

    class Calculator
    {
        public string Input1 { get; set; }
        public string Input2 { get; set; }

        public int Addition()
        {
            int Sum = 0;
            int Input1Parsed;
            int Input2Parsed;

            int.TryParse(this.Input1, out Input1Parsed);
            int.TryParse(this.Input2, out Input2Parsed);

            Sum = Input1Parsed + Input2Parsed;
            return Sum;
        }
    }
}
