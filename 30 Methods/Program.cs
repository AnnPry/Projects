using System;

namespace _30_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Fall("September", "October", "November");
            Console.WriteLine($"The number of methods is {NumberOfMethodsInTheProgram()}");
            Console.WriteLine(Messages());
            Console.WriteLine($"5 * 12 = {Multiplication(5, 12)}");
            int[] arr = new int[2];
            Array(arr);
            Question();
            Info("Ann", 14);
            WhatAreYouLike(true);
            DateOfYourBirthday(12,12,2007);
            FavouriteColor("Yes");
            Console.WriteLine($"Where are you from? ---- {WhereAreYouFrom()}");
            TeaOrCoffee();
            Game(true);
            Console.WriteLine($"In the piano {HowManyNotes()} notes");
            Console.WriteLine($"26 : 2 = {Qweqwe(26)}");
            int f = 40, d = 16, r = 2;
            Subtraction(f, d);
            Subtraction(d, 7);
            Subtraction(d, r * 5);
            int number;
            Division(36, 4, out number);
            Console.WriteLine($"36 / 4 = {number}");
            Something("apple", "pen", "applepen");
            FavouriteFruit("kiwi");
            Klo("dfg",26,"cvg");
            Klo("dfg",26);
            Klo("dfg",j:"cvg");
            MeatOrFish();
            Anime("Клинок рассекающий демонов");
            Height(165);
            Height();
            int result;
            Sum(7, 66, out result);
            Console.WriteLine($"7 + 66 = {result}");
            Console.WriteLine($"What song stuck in your head? ---- {WhatSong("Last Christmas")}");
            Book("Пиши,сокращай");
            Console.WriteLine(Film());
            ChristmasOrNewYear("I like the New Year a little more");
            Console.WriteLine($"How many months in a year? ---- {MonthsInAYear()} months");
            Snow(false);
            Console.WriteLine(7 % 2);
        }
        static void Fall(string month1, string month2, string month3)
        {
            Console.WriteLine($"Fall:{month1},{month2},{month3}");
        }
        static int NumberOfMethodsInTheProgram()
        {
            return 30;
        }
        static string Messages()
        {
            return "Hallo, What'up? Can you hear me?";
        }
        static int Multiplication(int x, int y)
        {
            return x * y;
        }
        static void Array(int[] arr)
        {
            for (int i = 3; i < 5; i++)
            {
                Console.WriteLine(i);
            }
        }
        static void Question()
        {
            Console.Write("Write number 10: ");
            int num = int.Parse(Console.ReadLine());
            if (num == 10)
            {
                Console.WriteLine("Well done, you can read )");
            }
            else
            {
                Console.WriteLine("....*silence*....");
            }
        }
        static void Info(string name, int age)
        {
            Console.WriteLine($"Name: {name}, age: {age};");
        }
        static void WhatAreYouLike(bool answer)
        {
            Console.WriteLine($"Do you like pets? -- {answer}");
        }       
        static void DateOfYourBirthday(int d,int at,int e)
        {
            Console.WriteLine($"Date of my birthday: {d},{at},{e}");
        }
        static void FavouriteColor(string trueColor)
        {
            Console.WriteLine($"Is your favourite color purple? --- {trueColor}");
        }
        static string WhereAreYouFrom()
        {
            return "I'm from Ukraine, Kiev";
        }
        static void TeaOrCoffee()
        {
            Console.Write("What would you prefer, tea(1) or coffee(2): ");
            bool num1 = int.TryParse(Console.ReadLine(), out int num);
            if (num == 1 || num == 2)
            {
                Console.WriteLine("Both drinks are great");
            }
            else
            {
                Console.WriteLine("Wrote another symbol ");
            }
        }
        static void Game(bool g)
        {
            Console.WriteLine($"Do you have a mobile game, if yes, which one? ---- {g}, Now i play 'Genshin Impact'");
        }
        static int HowManyNotes()
        {
            return 7;
        }
        static int Qweqwe (int q)
        {
            return q / 2;
        }
        static void Subtraction(int x,int y)
        {
            Console.WriteLine($"{x} - {y} = {x - y}");
        }
        static void Division(int n, int m, out int result)
        {
            result = n / m;
        }
        static void Something(string apple, string pen, string applepen)
        {
            Console.WriteLine($"{apple} + {pen} = {applepen}");
        }
        static void FavouriteFruit(string fruit)
        {
            Console.WriteLine($"My favourite fruit is {fruit}");
        }
        static void Klo(string d, int f = 5, string j = "----")
        {
            Console.WriteLine($"Name: {d}, age: {f}, surname: {j}");
        }
        static void MeatOrFish()
        {
            Console.Write("Meat(5) or Fish(6): ");
            bool MeatAndFish = int.TryParse(Console.ReadLine(), out int maf);
           
            if (maf == 5 || maf == 6)
            {
                Console.WriteLine("Not bad");
            }
            else
            {
                Console.WriteLine("Wrote another symbol ");
            }
        }
        static void Anime(string a)
        {
            Console.WriteLine($"What anime are you whatcing? ---- {a}");
        }
        static void Height(int h = 0)
        {
            Console.WriteLine($"My height is {h} cm");
        }
        static void Sum(int z, int y, out int result)
        {
            result = z + y;
        }
        static string WhatSong(string song)
        {
            return song;
        }
        static void Book(string b)
        {
            Console.WriteLine($"Which book are you reading? ---- {b}");
        }
        static string Film()
        {
            return "Did you watch film recently? ---- Yes,'Клаустрофобия' ";
        }
        static void ChristmasOrNewYear(string answer)
        {
            Console.WriteLine($"What you like the mostly,Christmas or New Year? ---- {answer}");
        }
        static int MonthsInAYear()
        {
            return 12;            
        }
        static void Snow (bool s)
        {
            Console.WriteLine($"Do you like snow? ---- {s}");
        }
    }
}

