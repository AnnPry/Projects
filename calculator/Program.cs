using System;

namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator("Operation: ");      
        }
        static double GetDoubleFromUser(string GetNumber)
        {
            bool num = false;
            double number = 0;       

            while (!num)
            {
                Console.Write(GetNumber);
                string input = Console.ReadLine();
                num = double.TryParse(input, out number);

                if (!num)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Input isn't a number! Plese try again!");
                    Console.ResetColor();
                }
            }
            return number;
        }  
        static void Calculator(string GetOperation)
        {
            bool IsTrue = false;

            while(!IsTrue)
            {
                Console.Write(GetOperation);
                string oper = Console.ReadLine();

                if (oper == "/" || oper == "*" || oper == "+" || oper == "-" || oper == "%" || oper == "d")
                {
                    Operations(oper);

                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Press S to stop and exit");

                    if (Console.ReadKey().Key == ConsoleKey.S)
                    {
                        break;
                    }
                    Console.ResetColor();

                    Console.Clear();
                }
                else if (oper == "m")
                {
                    ModulOperation();  
  
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Press S to stop and exit");

                    if (Console.ReadKey().Key == ConsoleKey.S)
                    {
                        break;
                    }
                    Console.ResetColor();

                    Console.Clear();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Input isn't a symbol! Plese try again!");
                    Console.ResetColor();
                }
            }
        }         
        static void Operations(string oper)
        {
            double n1 = GetDoubleFromUser("Number 1: ");

            double n2 = GetDoubleFromUser("Number 2: ");

            string result = "Result: ";
            string Error = "";

            switch (oper)
            {
                case "+":
                    result += n1 + n2;
                    break;
                case "-":
                    result += n1 - n2;
                    break;
                case "/":
                    result += n1 / n2;
                    break;
                case "*":
                    result += n1 * n2;
                    break;
                case "%":
                    result += n1 % n2;
                    break;
                case "d":
                    result += Math.Pow(n1, n2);
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("It isn't possible in the program");
                    Console.ResetColor();
                    break;
            }

            if (Error.Length == 0)
            {
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine(result);
                RedErrorString();
            }
        }
        static void ModulOperation()
        {
            double n = GetDoubleFromUser("Number: ");

            if (n < 0 || n >= 0)
            {
                Console.WriteLine($"|{Math.Abs(n)}|");

            }
            else
            {
                RedErrorString();
            }
        }
        static void RedErrorString()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Error");
            Console.ResetColor();
        }
    }
}