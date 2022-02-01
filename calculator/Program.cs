using System;

namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Press M to change the number to modul");

                if (Console.ReadKey().Key == ConsoleKey.M)
                {                    
                    Console.ReadLine();

                    Console.Write("Number: ");
                    bool num = double.TryParse(Console.ReadLine(), out double n);

                    if(n < 0)
                    {
                        double res = n + -(n + n);
                        Console.WriteLine($"|{res}|");
                    }
                    else if(n >= 0)
                    {
                        Console.WriteLine($"Result: |{n}|");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Error");
                        Console.ResetColor();
                    }
                }
                else
                {
                    Console.Clear();
                }
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Press D to do degree of number");

                if (Console.ReadKey().Key == ConsoleKey.D)
                {
                    Console.ReadLine();

                    Console.Write("Number: ");
                    bool num3 = double.TryParse(Console.ReadLine(), out double n3);

                    Console.Write("Degree of number: ");
                    bool num4 = int.TryParse(Console.ReadLine(), out int n4);

                    if (num3 == true && num4 == true)
                    {
                        Console.WriteLine($"Result: {Math.Pow(n3, n4)}");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Error");
                        Console.ResetColor();      
                    }
                }
                else
                {
                    Console.Clear();
                }
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Number 1: ");
                bool num1 = double.TryParse(Console.ReadLine(), out double n1);

                Console.Write("Number 2: ");
                bool num2 = double.TryParse(Console.ReadLine(), out double n2);

                Console.Write("Operation: ");
                string oper = Console.ReadLine();

                string result = "Result: ";
                string Error = "";

                if (num1 == false && num2 == false)
                {
                    Error += "Error";
                }

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
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Error");
                        Console.ResetColor();
                        break;
                }
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.White;
                if (Error.Length == 0)
                {
                    Console.WriteLine(result);
                }
                else
                {
                    Console.WriteLine(result);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(Error);
                    Console.ResetColor();

                }
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Press S to stop and exit");

                if (Console.ReadKey().Key == ConsoleKey.S)
                {
                    break;
                }
                Console.ResetColor();

                Console.Clear();                
            }           
        }
    }
}

