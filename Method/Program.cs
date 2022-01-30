using System;

namespace Method
{
    class Program
    {
        static void Main(string[] args)
        {
            string cfv = Console.ReadLine();                     
            Console.WriteLine(cfv);

            Method();
            int[,] huj = new int[5, 3];
            for (int i = 0; i < huj.GetLength(0); i++)
            {
                for (int k = 0; k < huj.GetLength(1); k++)
                {
                    Random kmn = new Random();
                    huj[i, k] = kmn.Next(0, 10);
                }
            }
            Render(huj);
            Console.ReadLine();

            int[,] rnd = new int[5, 3];
            RandomFill(rnd);
            Render(rnd);

            int[,] hjk = new int[3, 3];
            //FillNumber();
            //Array(hjk);


            int arraySize1 = GetIntFromUser("Input array height: ", 1, 15);
            int arraySize2 = GetIntFromUser("Input array width: ", 1, 15);

            int[,] intArray = new int[arraySize1, arraySize2];

            // fill array (random)
            FillArrayRandoms(intArray);

            // render array
            PrintArray(intArray);

            // fill array (user)
            //FillArrayUser(intArray);

            // render array
            //PrintArray(intArray);

            ModifyArray(intArray);
        }
        static void Method()
        {
            Console.WriteLine("Hello World");

        }
        static void Render(int[,] dft)
        {
            for (int i = 0; i < dft.GetLength(0); i++)
            {
                for (int k = 0; k < dft.GetLength(1); k++)
                {
                    Console.Write(dft[i, k] + "  ");
                }
                Console.WriteLine();
            }
        }
        static void RandomFill(int[,] fill)
        {          
            for (int i = 0; i < fill.GetLength(0); i++)
            {
                for (int k = 0; k < fill.GetLength(1); k++)
                {
                    Random kmn = new Random();
                    fill[i, k] = kmn.Next(0, 10);
                }
            }
            
        }
        static void ModifyArray(int[,] array)
        {
            bool needModification = false;
            do
            {
                Console.Write("Want to modify array (p for Print)? ");
                ConsoleKeyInfo key = Console.ReadKey();
                Console.WriteLine();

                if (key.KeyChar == 'n')
                {
                    needModification = false;
                    continue;
                }
                else if (key.KeyChar == 'p')
                {
                    needModification = true;
                    PrintArray(array);
                    continue;
                }

                needModification = true;
                int row = GetIntFromUser("Choose row, please! ", 0, array.GetLength(0) - 1);
                int col = GetIntFromUser("Choose col, please! ", 0, array.GetLength(1) - 1);

                int oldValue = array[row, col];

                array[row, col] = GetIntFromUser($"Array[{row}, {col}] new value = ", 10);

                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine($"Array[{row}, {col}]: {oldValue} => {array[row, col]}");
                Console.ResetColor();
            }
            while (needModification);
        }

        static void FillArrayRandoms(int[,] array)
            {
                Random random = new Random((int)DateTime.Now.Ticks);

                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int k = 0; k < array.GetLength(1); k++)
                    {
                        array[i, k] = random.Next(10, 100);
                    }
                }
            }

            static void FillArrayUser(int[,] array)
            {
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int k = 0; k < array.GetLength(1); k++)
                    {
                        // get int from user
                        array[i, k] = GetIntFromUser($"Set [{i}, {k}] element: ", 10);
                    }
                }
            }

            static void PrintArray(int[,] array)
            {
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    Console.Write("\t");
                    for (int k = 0; k < array.GetLength(1); k++)
                    {
                        Console.Write($"{array[i, k]}\t");
                    }
                    Console.WriteLine();
                }
            }

            static int GetIntFromUser(string question, int min, int max = int.MaxValue)
            {
                bool inputIsNumber = false;
                int number = 0;

                do
                {
                    Console.Write(question);
                    string input = Console.ReadLine();
                    inputIsNumber = int.TryParse(input, out number);

                    if (!inputIsNumber)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Input is not a number! Plese try again!");
                        Console.ResetColor();
                    }

                    if (inputIsNumber && (number < min || number > max))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Input is out of bounds! Plese try again!");
                        Console.ResetColor();
                        inputIsNumber = false;
                    }
                }
                while (!inputIsNumber);

                return number;
            }
    }
}
