using System;

namespace Ravlyk
{
    class Program
    {
        static void Main(string[] args)
        {
            int k = GetIntFromUser();
            if (k == 1)
            {
                Console.WriteLine(1 + 1 + 4 * k + 5);
            }
            else
            {
                Console.WriteLine(4 * k - 4 + 1 + 4 * k + 5);
            }

            static int GetIntFromUser()
            {
                bool inputIsANumber = false;
                int number = 0;

                while (!inputIsANumber)
                {
                    Console.Write("Input number: ");
                    string input = Console.ReadLine();
                    inputIsANumber = int.TryParse(input, out number);

                    if (!inputIsANumber)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Input isn't a number! Please try again!");
                        Console.ResetColor();
                    }

                    if (inputIsANumber && (number <= 0))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Input is out of bounds! Please try again!");
                        Console.ResetColor();
                        inputIsANumber = false;
                    }                    
                }
                return number;           
            }


            //Console.Write("Input number: ");
            //int k = int.Parse(Console.ReadLine());

            //if (k == 1)
            //{
            //    Console.WriteLine(1 + 1 + 4 * k + 5);
            //}
            //else
            //{
            //    Console.WriteLine(4 * k - 4 + 1 + 4 * k + 5);
            //}
        }
    }
}
