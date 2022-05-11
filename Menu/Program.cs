using System;

namespace Menu
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = GetUserName();
            Console.WriteLine(name);

            YourLocation("Menu");

            Console.WriteLine("1. Profile");
            Console.WriteLine("2. Contacts");
            Console.WriteLine("3. Settings");
            Console.WriteLine("4. Array");           

            Console.WriteLine();

            int number = GetNumberOfMenu();
            Console.WriteLine(number);
        }
        static string GetUserName()
        {
            string nam = "";
            string name;
            do
            {
                Console.Write("Enter your name: ");
                name = Console.ReadLine();

                if (name.Length >= 2 && int.TryParse(name, out int qwe) == false)
                {
                    Console.WriteLine($"Welcome, {name}");
                    Console.ReadLine();

                    Console.Clear();
                    break;
                }
                else 
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Error");
                    Console.ResetColor();

                    Console.ReadLine();
                    Console.Clear();
                }
            }
            while (true);

            return nam;
        }

        static int GetNumberOfMenu()
        {
            int n = 0;
            do
            {
                Console.Write("Enter number of Menu: ");
                bool number = int.TryParse(Console.ReadLine(), out int num);

                if (number == true && num == 1)
                {
                    Console.Clear();
                    YourLocation("Profile"); 
                    ComeBack();
                    break;
                }
                else if (number == true && num == 2)
                {
                    Console.Clear();
                    YourLocation("Contacts");
                    ComeBack();
                    break;
                }
                else if (number == true && num == 3)
                {
                    Console.Clear();
                    YourLocation("Settings");
                    ComeBack();
                    break;
                }
                else if (number == true && num == 4)
                {
                    Console.Clear();
                    YourLocation("Array");
                    Array();
                    ComeBack();
                    break;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Error");
                    Console.ResetColor();
                }
            }
            while (true);

            return n;
        }
        static void YourLocation(string something)
        {
            Console.WriteLine($"You hier: {something}");
            Console.WriteLine();
        }
        static void ComeBack()
        {
            Console.WriteLine("Press 'Enter' to return");

            if (Console.ReadKey().Key == ConsoleKey.Enter)
            {
                Console.Clear();
                YourLocation("Menu");

                Console.WriteLine("1. Profile");
                Console.WriteLine("2. Contacts");
                Console.WriteLine("3. Settings");
                Console.WriteLine("4. Array");

                Console.WriteLine();

                int number = GetNumberOfMenu();
                Console.WriteLine(number);
            }
        }
        static void Array()
        {
            int height = GetNumberFromUser("Enter height of array: ", 1,100);
            int width = GetNumberFromUser("Enter width of array: ", 1,100);

            int[,] Array = new int[height, width];
            Console.WriteLine();

            Random r = new Random();

            for (int i = 0; i < Array.GetLength(0); i++)
            {
                for (int k = 0; k < Array.GetLength(1); k++)
                {
                    Array[i, k] = r.Next(0, 101);
                    Console.Write(Array[i, k] + "; ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();

            if (height > 1 && width > 1)
            {
                Console.WriteLine("Do you want to swap values in array? ");

                if (Console.ReadKey().Key == ConsoleKey.Y)
                {
                    Console.ReadLine();
                    TransferArrayCell(Array);
                }
            }
        }
        static int GetNumberFromUser(string input, int min, int max = int.MaxValue)
        {
            bool qwe = false;
            int num = 0;

            while (!qwe)
            {
                Console.Write(input);
                string i = Console.ReadLine();
                qwe = int.TryParse(i, out num);

                if (!qwe)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Input isn't a number! Plese try again!");
                    Console.ResetColor();
                }

                if (qwe && (num < min || num > max))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Input is out of bounds! Plese try again!");
                    Console.ResetColor();
                    qwe = false;
                }
            }
            return num;
        }
        static void TransferArrayCell(int[,] array)
        {
            (array[0, 0], array[1, 1]) = (array[1, 1], array[0, 0]);

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int k = 0; k < array.GetLength(1); k++)
                {
                    Console.Write(array[i, k] + "; ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
