using System;

namespace X_and_0
{
    class Program
    {
        static void Main(string[] args)
        {

            int[,] xAnd0 = new int[3, 3];

            for (int i = 0; i < xAnd0.GetLength(0); i++)
            {
                for (int k = 0; k < xAnd0.GetLength(1); k++)
                {
                    Console.Write(xAnd0[i, k] + "; ");
                }
                Console.WriteLine();
            }

            while (Has0(xAnd0))            
            {

                Console.Write("Vertical coordinate: ");
                bool vertical = int.TryParse(Console.ReadLine(), out int vrt);

                Console.Write("Horizontal coordinate: ");
                bool horizontal = int.TryParse(Console.ReadLine(), out int hzt);


                if (vertical == true && horizontal == true)
                {

                    for (int i = 0; i < xAnd0.GetLength(0); i++)
                    {
                        for (int k = 0; k < xAnd0.GetLength(1); k++)
                        {
                            int x = 1;
                            xAnd0[vrt, hzt] = x;
                        }
                    }
                    for (int i = 0; i < xAnd0.GetLength(0); i++)
                    {
                        for (int k = 0; k < xAnd0.GetLength(1); k++)
                        {
                            Console.Write(xAnd0[i, k] + "; ");
                        }
                        Console.WriteLine();
                    }
                }
                Console.Write("Vertical coordinate: ");
                bool vertical2 = int.TryParse(Console.ReadLine(), out int vrt2);

                Console.Write("Horizontal coordinate: ");
                bool horizontal2 = int.TryParse(Console.ReadLine(), out int hzt2);

                if (vertical2 == true && horizontal2 == true)
                {
                    for (int l = 0; l < xAnd0.GetLength(0); l++)
                    {
                        for (int n = 0; n < xAnd0.GetLength(1); n++)
                        {
                            for (int m = 0; m < 3; m++)
                            {
                                int O = 2;
                                xAnd0[vrt2, hzt2] = O;
                            }
                        }
                    }

                    for (int l = 0; l < xAnd0.GetLength(0); l++)
                    {
                        for (int n = 0; n < xAnd0.GetLength(1); n++)
                        {
                            Console.Write(xAnd0[l, n] + "; ");
                        }
                        Console.WriteLine();
                    }
                }

                else
                {
                    Console.WriteLine("ERROR");

                //    bool inputIsNumber = false;
                //    int number = 0;

                //    do
                //    {
                //        string question;
                //        Console.Write(question);
                //        string input = Console.ReadLine();
                //        inputIsNumber = int.TryParse(input, out number);

                //        if (!inputIsNumber)
                //        {
                //            Console.ForegroundColor = ConsoleColor.Red;
                //            Console.WriteLine("Input is not a number! Plese try again!");
                //            Console.ResetColor();
                //        }

                //        if (inputIsNumber)
                //        {
                //            Console.ForegroundColor = ConsoleColor.Red;
                //            Console.WriteLine("Input is out of bounds! Plese try again!");
                //            Console.ResetColor();
                //            inputIsNumber = false;
                //        }
                //    }
                //    while (!inputIsNumber);

                //    return number;
                //}
                
                }
            }
            
        }
        static bool Has0(int[,] qwe)
        {
            for (int i = 0; i < qwe.GetLength(0); i++)
            {
                for (int k = 0; k < qwe.GetLength(1); k++)
                {
                    if (qwe[i, k] == 0)
                    {
                        return true;

                    }
                }
            }
            return false;
        }
    }
}
