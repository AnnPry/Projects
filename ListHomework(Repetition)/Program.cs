using System;
using System.Collections.Generic;

namespace ListHomework_Repetition_
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = NumberOrNot();

            List<string> list = new List<string>();
           
            GetElements(list, num);
            PrintArray(list);

            static void GetElements(List<string> list, int num)
            {
                var elem = "";
                for (int i = 0; i < num; i++)
                {
                    Console.Write("List element: ");
                    elem = Console.ReadLine();
                    Console.WriteLine($"Element length = {elem.Length}");
                    list.Add(elem);
                }
            }
            static void PrintArray(List<string> list)
            {
                Console.WriteLine(string.Join(", ", list));
            }
            static int NumberOrNot()
            {
                bool qwe = false;
                int number = 0;

                while (!qwe)
                {
                    Console.Write("List length: ");
                    string input = Console.ReadLine();
                    qwe = int.TryParse(input, out number);

                    if (!qwe)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Input isn't a number! Plese try again!");
                        Console.ResetColor();
                    }
                }
                return number;
            }
        }
    }
}
