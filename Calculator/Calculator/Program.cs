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
        public static int baseValue = 0;
        public static int userInput = 0;
        public static int calcType = 0;

        static void Main(string[] args)
        {
            Console.WriteLine("Console Calculator: Your trusted source for second-grade mathematics!\n");
            Console.WriteLine("Current functionality: \n-Addition\n-Subtraction\n");

            baseValue = GetFirstNumber();

            Calculator doCalc = new Calculator();

            while (calcType != null)
                {
                calcType = SelectCalculationType().Value;
                userInput = Calculator.GetInput();

                int userInputParsed = 0;

                if (calcType == 1)
                    baseValue = doCalc.Addition(baseValue, userInputParsed);

                else if (calcType == 2)
                    baseValue = doCalc.Subtraction(baseValue, userInputParsed);
                }
        }

        private static int GetFirstNumber()
        {
            string input;
            int inputParsed;

            Console.WriteLine("Input the first number: ");
            input = Console.ReadLine();
            while (!Calculator.Validate(input))
            {
                input = Console.ReadLine();
            }

            int.TryParse(input, out inputParsed);

            return inputParsed;
        }

        private static int? SelectCalculationType()
        {
            string input;

            Console.WriteLine("\nSelect a calculation to perform or press <enter> to exit:\n");
            Console.WriteLine("(1) Add\n(2) Subtract\n");
            input = Console.ReadLine();

            if (input == "")
                return null;

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

        public static int GetInput()
        {
            //If input is an empty string, return null immediately
            //else tryparse and return the value
            //note: above in the while check, need to check for null!
            //to get the int value, use .value
            int output;

            Console.WriteLine("\nInput the next number:");
            string input = Console.ReadLine();

            while (!Calculator.Validate(input))
            {
                input = Console.ReadLine();
            }

                int.TryParse(input, out output);
                return output;
        }

        public int Addition(int baseValue, int userInput)
        {
            int Sum;

            Sum = baseValue + userInput;
            Console.WriteLine("\nEquals: {0}", Sum);
            baseValue = Sum;
            return baseValue;
        }

        public int Subtraction(int baseValue, int userInput)
        {
            int Sum;

            Sum = baseValue - userInput;
            Console.WriteLine("\nEquals: {0}", Sum);
            baseValue = Sum;
            return baseValue;
        }
    }
}
