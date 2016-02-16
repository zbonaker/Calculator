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
        public static decimal baseValue = 0;
        public static decimal userInput = 0;

        static void Main(string[] args)
        {
            Console.WriteLine("Console Calculator: Your trusted source for second-grade mathematics!\n");

            Calculator doCalc = new Calculator();

            baseValue = GetFirstNumber();

            int? calcType = SelectCalculationType();

            while (calcType != null)
                {
                userInput = Calculator.GetInput();

                if (calcType == 1)
                    baseValue = doCalc.Addition(baseValue, userInput);

                else if (calcType == 2)
                    baseValue = doCalc.Subtraction(baseValue, userInput);

                else if (calcType == 3)
                    baseValue = doCalc.Multiplication(baseValue, userInput);

                else if (calcType == 4)
                    baseValue = doCalc.Division(baseValue, userInput);

                calcType = SelectCalculationType();
                }
        }

        private static decimal GetFirstNumber()
        {
            string input;
            decimal inputParsed;

            Console.WriteLine("Input the first number: ");
            input = Console.ReadLine();
            while (!Calculator.Validate(input))
            {
                input = Console.ReadLine();
            }

            decimal.TryParse(input, out inputParsed);

            return inputParsed;
        }

        private static int? SelectCalculationType()
        {
            string input;
            int i;

            Console.WriteLine("\nSelect a calculation to perform or press <enter> to exit:\n");
            Console.WriteLine("(1) Add\n(2) Subtract\n(3) Multiply\n(4) Divide\n");
            input = Console.ReadLine();

            if (input == "")
                return null;

            while (!Calculator.Validate(input))
            {
                input = Console.ReadLine();
            }

            int.TryParse(input, out i);

            return i;
        }
    }

    class Calculator
    {
        public static bool Validate(string input)
        {
            decimal parsed;
            if (!decimal.TryParse(input, out parsed))
                Console.WriteLine("\nInput is not numeric! Please input the number again: ");
            return decimal.TryParse(input, out parsed);
        }

        public static decimal GetInput()
        {
            decimal output;

            Console.WriteLine("\nInput the next number:");
            string input = Console.ReadLine();

            while (!Calculator.Validate(input))
            {
                input = Console.ReadLine();
            }

                decimal.TryParse(input, out output);
                return output;
        }

        public decimal Addition(decimal baseValue, decimal userInput)
        {
            decimal Sum;

            Sum = baseValue + userInput;
            Console.WriteLine("\nEquals: {0}", Sum);
            baseValue = Sum;
            return baseValue;
        }

        public decimal Subtraction(decimal baseValue, decimal userInput)
        {
            decimal Sum;

            Sum = baseValue - userInput;
            Console.WriteLine("\nEquals: {0}", Sum);
            baseValue = Sum;
            return baseValue;
        }

        public decimal Multiplication(decimal baseValue, decimal userInput)
        {
            decimal Sum;

            Sum = baseValue * userInput;
            Console.WriteLine("Equals: {0}", Sum);
            baseValue = Sum;
            return baseValue;
        }

        public decimal Division(decimal baseValue, decimal userInput)
        {
            decimal Sum;

            Sum = baseValue / userInput;
            Console.WriteLine("Equals: {0}", Sum);
            baseValue = Sum;
            return baseValue;
        }
    }
}
