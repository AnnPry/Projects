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
                int vertical = GetCoordinatesFromUser("Vertical coordinate: ");
                //Console.Write("Vertical coordinate: ");
                //bool vertical = int.TryParse(Console.ReadLine(), out int vrt);

                int horizontal = GetCoordinatesFromUser("Horizontal coordinate: ");
                //Console.Write("Horizontal coordinate: ");
                //bool horizontal = int.TryParse(Console.ReadLine(), out int hzt);

                //int min = 0;
                //int max = 2;

                //if (vrt < min || vrt > max && hzt < min || hzt > max)
                //{
                //    Console.ForegroundColor = ConsoleColor.Red;
                //    Console.WriteLine("ERROR");
                //    Console.ResetColor();
                //}

                //if (vertical == true && horizontal == true)
                //{

                    for (int i = 0; i < xAnd0.GetLength(0); i++)
                    {
                        for (int k = 0; k < xAnd0.GetLength(1); k++)
                        {
                            int x = 1;
                            xAnd0[vertical, horizontal] = x;
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
                //}
                //else 
                //{
                //    //if (vertical == false || horizontal == false)
                //    //{
                //        Console.ForegroundColor = ConsoleColor.Red;
                //        Console.WriteLine("ERROR");
                //        Console.ResetColor();
                //    //}
                //}

                int vertical2 = GetCoordinatesFromUser("Vertical coordinate: ");

                int horizontal2 = GetCoordinatesFromUser("Horizontal coordinate: ");
                //Console.Write("Vertical coordinate: ");
                //bool vertical2 = int.TryParse(Console.ReadLine(), out int vrt2);

                //Console.Write("Horizontal coordinate: ");
                //bool horizontal2 = int.TryParse(Console.ReadLine(), out int hzt2);

                //int min2 = 0;
                //int max2 = 2;

                //if (vrt2 < min2 || vrt2 > max2 || hzt2 < min2 || hzt2 > max2)
                //{
                //    Console.ForegroundColor = ConsoleColor.Red;
                //    Console.WriteLine("Error");
                //    Console.ResetColor();                   
                //}

                //if (vertical2 == true && horizontal2 == true)
                //{
                    for (int l = 0; l < xAnd0.GetLength(0); l++)
                    {
                        for (int n = 0; n < xAnd0.GetLength(1); n++)
                        {
                            for (int m = 0; m < 3; m++)
                            {
                                int O = 2;
                                xAnd0[vertical2, horizontal2] = O;
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
                //}
                //else
                //{
                //    if( vertical2 == false || horizontal2 == false)
                //    {
                //        Console.ForegroundColor = ConsoleColor.Red;
                //        Console.WriteLine("ERROR");
                //        Console.ResetColor();
                //    }
                //}
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
        static int GetCoordinatesFromUser(string TextLine)
        {
            bool something = false;
            int number = 0;

            while (!something )
            {
                Console.Write(TextLine);
                string input = Console.ReadLine();
                something = int.TryParse(input, out number);

                if (!something)
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
