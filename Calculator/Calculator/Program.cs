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
        public static string baseValue;

        static void Main(string[] args)
        {
            Console.WriteLine("Console Calculator: Your trusted source for second-grade mathematics!\n");
            Console.WriteLine("Current functionality: \n-Add multiple numbers\n");

            Calculator doCalc = new Calculator();

            Console.WriteLine("Input the first number: ");
            baseValue = Console.ReadLine();
            while (!Calculator.Validate(baseValue))
            {
                baseValue = Console.ReadLine();
            }

            Console.WriteLine("\nInput the next number:");
            doCalc.Input = Console.ReadLine();
            while (!Calculator.Validate(doCalc.Input))
            {
                doCalc.Input = Console.ReadLine();
            }

            Console.WriteLine("\nEquals: {0}", doCalc.Addition(baseValue));
            baseValue = doCalc.Addition(baseValue);
          
            Console.ReadLine();
        }
    }

    class Calculator
    {
        public string Input { get; set; }

        public static bool Validate(string input)
        {
            int parsed;
            if (!int.TryParse(input, out parsed))
                Console.WriteLine("\nInput is not an integer! Please input the number again: ");
            return int.TryParse(input, out parsed);
        }

        public string Addition(string baseValue)
        {
            int Sum;
            int baseValueParsed;
            int inputParsed;

            int.TryParse(baseValue, out baseValueParsed);
            int.TryParse(this.Input, out inputParsed);

            Sum = baseValueParsed + inputParsed;
            return Sum.ToString();
        }
    }
}
