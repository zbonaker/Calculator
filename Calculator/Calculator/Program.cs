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
        public static string baseValue = "0";
        public static string userInput = "0";

        static void Main(string[] args)
        {
            Console.WriteLine("Console Calculator: Your trusted source for second-grade mathematics!\n");
            Console.WriteLine("Current functionality: \n-Add multiple numbers\n");

            baseValue = GetFirstNumber();

            //Here I envison a menu to allow the user to select the type of calcuation
            //e.g., Addition, Subtraction

            Calculator doCalc = new Calculator();

            while (userInput != "")
                {
                    userInput = Calculator.GetInput();
                    baseValue = doCalc.Addition(baseValue, userInput);
                }
        }

        private static string GetFirstNumber()
        {
            string input;
            Console.WriteLine("Input the first number: ");
            input = Console.ReadLine();
            while (!Calculator.Validate(input))
            {
                input = Console.ReadLine();
            }

            return input;
        }
    }

    class Calculator
    {
        public static bool Validate(string input)
        {
            int parsed;
            if (!int.TryParse(input, out parsed))
                Console.WriteLine("\nInput is not an integer! Please input the number again: ");
            return int.TryParse(input, out parsed);
        }

        public static string GetInput()
        {
            Console.WriteLine("\nInput the next number to add, or press <enter> to exit:");
            string input = Console.ReadLine();

            if (input == "")
                Environment.Exit(0);

            while (!Calculator.Validate(input))
            {
                input = Console.ReadLine();
            }

            return input;
        }

        public string Addition(string baseValue, string userInput)
        {
            int Sum;
            int baseValueParsed;
            int inputParsed;

            int.TryParse(baseValue, out baseValueParsed);
            int.TryParse(userInput, out inputParsed);

            Sum = baseValueParsed + inputParsed;
            Console.WriteLine("\nEquals: {0}", Sum);
            baseValue = Sum.ToString();
            return baseValue;
        }
    }
}
