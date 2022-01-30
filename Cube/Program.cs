using System;

namespace Cube
{
    class Program
    {
        static void Main(string[] args)
        {
            Qwe();
            //начало инициализации
            string[,,] cube = new string[3,3,3];
            //конец
            //начало заполнение
            for (int i = 0; i < cube.GetLength(0); i++)
            {
                for (int k = 0; k < cube.GetLength(1); k++)
                {
                    for (int g = 0; g < cube.GetLength(2); g++)
                    {
                        cube[i, k, g] = $"{i},{k},{g}";
                        
                    }
                }
            }
            //конец
            for (int i = 0; i < cube.GetLength(0); i++)
            {
                for (int k = 0; k < cube.GetLength(1); k++)
                {
                    for (int g = 0; g < cube.GetLength(2); g++)
                    {
                        Console.Write(" [" + cube[k, g, i] + "] ");

                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
           

            string a = "0,0,2";           
            Console.Write(a);
        }       
        static void Qwe()
        {
            Console.WriteLine("Hello World!");
        }
        
          
    }
}
