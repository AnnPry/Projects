using System;

namespace Menu
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = GetUserName();
            Console.WriteLine(name);

            Console.WriteLine("Menu");
            Console.WriteLine();

            Console.WriteLine("1. Profile");
            Console.WriteLine("2. Contacts");
            Console.WriteLine("3. Settings");

            Console.WriteLine();

            int number = GetNumberOfUser();
            Console.WriteLine(number);
        }
        static string GetUserName()
        {
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
                    Console.WriteLine("Error");
                    Console.ReadLine();

                    Console.Clear();
                }
            }
            while (true);

            return name;
        }

        static int GetNumberOfUser()
        {
            int n = 0;
            do
            {
                Console.Write("Enter number of Menu: ");
                bool number = int.TryParse(Console.ReadLine(), out int num);

                if (number == true && num == 1)
                {
                    Console.Clear();
                    Console.WriteLine("You chose Profile");
                    break;
                }
                else if (number == true && num == 2)
                {
                    Console.Clear();
                    Console.WriteLine("You chose Contacts");
                    break;
                }
                else if (number == true && num == 3)
                {
                    Console.Clear();
                    Console.WriteLine("You chose Settings");
                    break;
                }
                else
                {
                    Console.WriteLine("Error");
                }

            }
            while (true);

            return n;
        }
    }
}
