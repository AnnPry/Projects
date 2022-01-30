using System;

namespace Qweqwe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //string[] nnArray = new string[6];           
            
            //nnArray[0] = "ftg"; 
            //nnArray[1] = "red"; 
            //nnArray[2] = "jik"; 
            //nnArray[3] = "qwe";
            //nnArray[4] = "bhn";
            //nnArray[5] = "jfn";

            //for (int i = 0; i < nnArray.Length; i++)
            //{
            //    if (nnArray[i].Contains("e"))
            //    {
            //        Console.WriteLine(nnArray[i]);
            //    }
            //}

            //for (int i = 0; i < nnArray.Length; i++)
            //{
                              
            //    nnArray[i] = Console.ReadLine();

            //}

            //for (int i = 0; i < nnArray.Length; i++)
            //{
            //    Console.WriteLine(nnArray[i]);

            //}



            int[,] AnnArray = new int[5, 5];

            //for (int i = 0; i < AnnArray.GetLength(0); i++)
            //{
            //    for (int k = 0; k < AnnArray.GetLength(1); k++)
            //    {
            //        Random rnd = new Random();
            //        AnnArray[i,k] = rnd.Next(10, 100);
            //    }                           
            //}
            //for (int i = 0; i < AnnArray.GetLength(0); i++)
            //{
            //    for (int k = 0; k < AnnArray.GetLength(1); k++)
            //    {
            //        Console.Write(AnnArray[i,k] + "; ");
            //    }
            //    Console.WriteLine();
            //}

            //for (int i = 0; i < AnnArray.GetLength(0); i++)
            //{
            //    for (int k = 0; k < AnnArray.GetLength(1); k++)
            //    {
            //        Random rnd = new Random();
            //        AnnArray[i, k] = rnd.Next(-2147483647, 2147483647);                   
            //        AnnArray[i, k] = rnd.Next(int.MinValue,int.MaxValue);                   
            //    }
            //}
            //for (int i = 0; i < AnnArray.GetLength(0); i++)
            //{
            //    for (int k = 0; k < AnnArray.GetLength(1); k++)
            //    {
            //        Console.Write(AnnArray[i, k] + "; ");
            //    }
            //    Console.WriteLine();
            //}

            for (int i = 0; i < AnnArray.GetLength(0); i++)
            {
                for (int k = 0; k < AnnArray.GetLength(1); k++)
                {
                    Random rnd = new Random();
                    AnnArray[i, k] = rnd.Next(10, 100); // нэкст принимает два числа,одно мин. другое макс.Меньшее включительно,максимальное невключительно
                   
                }
            }
            for (int i = 0; i < AnnArray.GetLength(0); i++)
            {
                for (int k = 0; k < AnnArray.GetLength(1); k++)
                {
                    Console.Write(AnnArray[i, k] + "; ");
                }
                Console.WriteLine();
            }
            int max = 9;
            
            for (int i = 0; i < AnnArray.GetLength(0); i++)
            {               
                for (int k = 0; k < AnnArray.GetLength(1); k++)
                {
                    if (max < AnnArray[i, k])
                    {
                        max = AnnArray[i, k];
                    }
                }                
            }
            Console.WriteLine(max);
        }
    }
}
