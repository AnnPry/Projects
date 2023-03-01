using System;

namespace Post_office
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] parcels = new int[5];
            GetParcels(parcels);
            int[] car1 = new int[NumberOrNot("Car1: ")];
            int[] car2 = new int[NumberOrNot("Car2: ")];

            if(parcels[0]+parcels[1]+parcels[2]+parcels[3]+parcels[4] > car1.Length && parcels[0] + parcels[1] + parcels[2] + parcels[3] + parcels[4] > car2.Length)
            {
                if (parcels[0] + parcels[1] + parcels[2] + parcels[3] + parcels[4] <= car1.Length + car2.Length)
                {
                    Console.WriteLine("They need to work together!");
                }
                else if(parcels[0] + parcels[1] + parcels[2] + parcels[3] + parcels[4] > car1.Length + car2.Length)
                {
                    Console.WriteLine("They can not do it!");
                }             
            }
            else if(parcels[0] + parcels[1] + parcels[2] + parcels[3] + parcels[4] <= car1.Length && parcels[0] + parcels[1] + parcels[2] + parcels[3] + parcels[4] <= car2.Length)
            {
                Console.WriteLine("They both can do it!");
            }
            else if(parcels[0] + parcels[1] + parcels[2] + parcels[3] + parcels[4] > car1.Length && parcels[0] + parcels[1] + parcels[2] + parcels[3] + parcels[4] <= car2.Length)
            {
                 Console.WriteLine("Petro can do it!");
            }
            else if(parcels[0] + parcels[1] + parcels[2] + parcels[3] + parcels[4] <= car1.Length && parcels[0] + parcels[1] + parcels[2] + parcels[3] + parcels[4] > car2.Length)
            {
                Console.WriteLine("Vasyl can do it!");
            }          

            static void GetParcels(int[] parcels)
            {
                int par = 0;
                for (int i = 0; i < parcels.Length; i++)
                {        
                    par = NumberOrNot("Parcel: ");
                    parcels[i] = par;
                }
            }
            static int NumberOrNot(string question)
            {
                bool qwe = false;
                int number = 0;

                while (!qwe)
                {
                    Console.Write(question);
                    string input = Console.ReadLine();
                    qwe = int.TryParse(input, out number);

                    if (!qwe)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Input isn't a number! Please try again!");
                        Console.ResetColor();
                    }
                    if (qwe && (number <= 0))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Input is out of bounds! Please try again!");
                        Console.ResetColor();
                        qwe = false;
                    }
                }
                return number;
            }

        }
    }
}
