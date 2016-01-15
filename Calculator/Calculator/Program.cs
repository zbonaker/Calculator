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
        public static int calcType = 0;

        static void Main(string[] args)
        {
            Console.WriteLine("Console Calculator: Your trusted source for second-grade mathematics!\n");
            Console.WriteLine("Current functionality: \n-Addition\n-Subtraction\n");

            baseValue = GetFirstNumber();

            Calculator doCalc = new Calculator();

            while (userInput != "")
                {
                calcType = SelectCalculationType();
                userInput = Calculator.GetInput();

                if (calcType == 1)
                    baseValue = doCalc.Addition(baseValue, userInput);

                else if (calcType == 2)
                    baseValue = doCalc.Subtraction(baseValue, userInput);
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

        private static int SelectCalculationType()
        {
            string input;

            Console.WriteLine("\nSelect a calculation to perform or press <enter> to exit:\n");
            Console.WriteLine("(1) Add\n(2) Subtract\n");
            input = Console.ReadLine();

            if (input == "")
                Environment.Exit(0);

            while (!Calculator.Validate(input))
            {
                input = Console.ReadLine();
            }

            int.TryParse(input, out calcType);

            return calcType;
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
            Console.WriteLine("\nInput the next number:");
            string input = Console.ReadLine();

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

        public string Subtraction(string baseValue, string userInput)
        {
            int Sum;
            int baseValueParsed;
            int inputParsed;

            int.TryParse(baseValue, out baseValueParsed);
            int.TryParse(userInput, out inputParsed);

            Sum = baseValueParsed - inputParsed;
            Console.WriteLine("\nEquals: {0}", Sum);
            baseValue = Sum.ToString();
            return baseValue;
        }
    }
}
