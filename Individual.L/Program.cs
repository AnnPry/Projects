using System;

namespace Individual.L
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //for (int i = 1; i < 11; i++)//выводит от 10 до 1
            //{
            //    Console.WriteLine(11 - i);
            //}

            //for (int i = -10; i < 0; i++)//выводит от -10 до -1
            //{
            //    Console.WriteLine(i);
            //}

            //for (int i = 10; i >= 1; i--)//выводит от 10 до 1
            //{
            //    Console.WriteLine(i);
            //}

            //Console.Write("Enter number 1 : ");
            //bool t1 = uint.TryParse(Console.ReadLine(),out uint number1);

            //Console.Write("Enter number 2 : ");
            //bool t2 = uint.TryParse(Console.ReadLine(),out uint number2);

            //if(t1 == false || t2 == false)
            //{
            //    Console.WriteLine("Error");
            //    return;
            //}

            //if (number1 <= number2)
            //{
            //    for (uint i = number1; i <= number2; i++)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Incorrect input");
            //}
            //string Ann = int.Parse(Console.ReadLine());

            string name = "Ann";
            string surname = "Prydybailo";
            double age = 13.5;
            float height = 165;
            Console.WriteLine($"Hallo,Name:{name},Age:{age},Height:{height}sm,Surname:{surname} ");

            bool age1 = byte.TryParse(Console.ReadLine(),out byte num1);
            bool age2 = short.TryParse(Console.ReadLine(),out short num2 );

            if(num1 > num2)
            {
                Console.WriteLine(num1 - num2);
            }

            sbyte side1 = 5;
            decimal side2 = 5;
            int side3 = 8;
            uint side4 = 8;
            var r = side1 + side2 + side3 + side4;
            Console.WriteLine($"P ={side1 + side2 + side3 + side4}sm ");

            long SomeLongNumber = 985678954164589522;
            double numberPi = 3.1415926535;

            ushort m = 7;
            ulong c = 4200;
            byte dt = 55;
            string Q = "cm∆t";
            Console.WriteLine($"Q ={c * m * dt }Dj ");

            float c1= 500;
            double m1 = 0.2;
            int c2 = 4200;
            double m2 = 0.25;
            uint t = 25;
            sbyte t2= 15;
            string t1 = "?";
            string Q1 = "Q2";
            Console.WriteLine($"t1 =(c2*m2*10 + c1*m1*t) / c1*m1 = 130°C ");

            string paint1 = "blue";
            dynamic paint2 = "pink";
            var paint3 = "purpule";
            Console.WriteLine($"if,{paint1} mix {paint2} = {paint3} ");

            float a = 12 ;
            byte b = 17;
            Console.WriteLine($"S ={a * b}m2 ");

            bool apple = byte.TryParse(Console.ReadLine(), out byte app);
            bool orange = byte.TryParse(Console.ReadLine(), out byte oran);

            if (apple == true || orange == true)
            {
                Console.WriteLine("Apple and orange cool fruits");
            }
            else 
            {
                Console.WriteLine("Something went wrong... ");
            }
        }
    }
}