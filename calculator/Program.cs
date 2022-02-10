using System;

namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                GetOperationFromUser();
                string oper = Console.ReadLine();
                
                //if(oper == "m" || oper == "d")
                //{

                //}

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
                #region calculator 1
                //if (Console.ReadKey().Key == ConsoleKey.M)
                //{                    
                //    Console.ReadLine();

                //    Console.Write("Number: ");
                //    bool num = double.TryParse(Console.ReadLine(), out double n);

                //    if(n < 0)
                //    {
                //        double res = n + -(n + n);
                //        Console.WriteLine($"|{res}|");
                //    }
                //    else if(n >= 0)
                //    {
                //        Console.WriteLine($"Result: |{n}|");
                //    }
                //    else
                //    {
                //        Console.ForegroundColor = ConsoleColor.Red;
                //        Console.WriteLine("Error");
                //        Console.ResetColor();
                //    }
                //}
                //else
                //{
                //    Console.Clear();
                //}
                //Console.ResetColor();

                //Console.ForegroundColor = ConsoleColor.Magenta;
                //Console.WriteLine("Press D to do degree of number");

                //if (Console.ReadKey().Key == ConsoleKey.D)
                //{
                //    Console.ReadLine();

                //    Console.Write("Number: ");
                //    bool num3 = double.TryParse(Console.ReadLine(), out double n3);

                //    Console.Write("Degree of number: ");
                //    bool num4 = int.TryParse(Console.ReadLine(), out int n4);

                //    if (num3 == true && num4 == true)
                //    {
                //        Console.WriteLine($"Result: {Math.Pow(n3, n4)}");
                //    }
                //    else
                //    {
                //        Console.ForegroundColor = ConsoleColor.Red;
                //        Console.WriteLine("Error");
                //        Console.ResetColor();      
                //    }
                //}
                //else
                //{
                //    Console.Clear();
                //}
                //Console.ResetColor();

                //Console.ForegroundColor = ConsoleColor.White;
                //Console.Write("Number 1: ");
                //bool num1 = double.TryParse(Console.ReadLine(), out double n1);

                //Console.Write("Number 2: ");
                //bool num2 = double.TryParse(Console.ReadLine(), out double n2);

                //Console.Write("Operation: ");
                //string oper = Console.ReadLine();

                //string result = "Result: ";
                //string Error = "";

                //if (num1 == false && num2 == false)
                //{
                //    Error += "Error";
                //}

                //switch (oper)
                //{
                //    case "+":
                //        result += n1 + n2;
                //        break;
                //    case "-":
                //        result += n1 - n2;
                //        break;
                //    case "/":
                //        result += n1 / n2;
                //        break;
                //    case "*":
                //        result += n1 * n2;
                //        break;
                //    case "%":
                //        result += n1 % n2;
                //        break;
                //    default:
                //        Console.ForegroundColor = ConsoleColor.Red;
                //        Console.WriteLine("Error");
                //        Console.ResetColor();
                //        break;
                //}
                //Console.ResetColor();

                //Console.ForegroundColor = ConsoleColor.White;
                //if (Error.Length == 0)
                //{
                //    Console.WriteLine(result);
                //}
                //else
                //{
                //    Console.WriteLine(result);
                //    Console.ForegroundColor = ConsoleColor.Red;
                //    Console.WriteLine(Error);
                //    Console.ResetColor();

                //}
                //Console.ResetColor();
                #endregion

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
        static double GetDoubleFromUser(string question)
        {
            bool num = false;
            double number = 0;       

            while (!num)
            {
                Console.Write(question);
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
        static void GetOperationFromUser()
        {
            Console.Write("Operation: ");

            switch (Console.ReadKey().Key)
            {
                case ConsoleKey.M:
                    Console.ReadLine();

                    double n = GetDoubleFromUser("Number: ");

                    if (n < 0 || n >= 0)
                    {
                        Console.WriteLine($"|{Math.Abs(n)}|");

                    }
                    else
                    {
                        RedErrorString();
                    }
                    break;
                case ConsoleKey.D:
                    Console.ReadLine();

                    double n1 = GetDoubleFromUser("Number: ");

                    Console.Write("Degree of number: ");
                    bool num2 = int.TryParse(Console.ReadLine(), out int n2);

                    Console.WriteLine($"Result: {Math.Pow(n1, n2)}");

                    if (num2 == false)
                    {
                        RedErrorString();
                    }
                    break;
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


