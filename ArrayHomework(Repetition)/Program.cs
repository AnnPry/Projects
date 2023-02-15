using System;

namespace ArrayHomework_Repetition_
{
    class Program
    {
        static void Main(string[] args)
        {          
            int num = NumberOrNot();
                       
            string[] array = new string[num];
            GetElements(array);
            PrintArray(array);
          
            static void GetElements(string[] array)
            {
                var elem = "";
                for (int i = 0; i < array.Length; i++)
                {
                    Console.Write("Array element: ");
                    elem = Console.ReadLine();
                    Console.WriteLine($"Element lenght = {elem.Length}");
                    array[i] = elem;                   
                }             
            }
            static void PrintArray(string[] array)
            {
                Console.WriteLine(string.Join(", ", array));
            }
            static int NumberOrNot()
            {
                bool qwe = false;
                int number = 0;

                while (!qwe)
                {
                    Console.Write("Array length: ");
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
