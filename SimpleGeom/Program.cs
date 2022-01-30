using System;

namespace SimpleGeom
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Длина: ");
            //byte ftg = byte.Parse(Console.ReadLine());

            //Console.Write("Ширина: ");
            //byte ia = byte.Parse(Console.ReadLine());

            //Console.Write("Высота: ");
            //byte qwe = byte.Parse(Console.ReadLine());

            //Console.WriteLine($"V = {ftg * ia * qwe}");
            //Console.WriteLine(Math.PI);

            //Console.Write("Высота цилиндра: ");
            //double height = double.Parse(Console.ReadLine());

            //Console.WriteLine("Радиус цилиндра");
            //double radius = double.Parse(Console.ReadLine());

            Console.WriteLine("Чему равно V цилиндрa?");         

            double pi = Math.PI;
            Console.WriteLine($"Пи = {Math.PI}");
            
            Console.Write("Высота цилиндра: ");
            bool isHeightNumber = double.TryParse(Console.ReadLine(), out double height);

            Console.Write("Радиус цилиндра: ");
            bool isRadiusNumber = double.TryParse(Console.ReadLine(), out double radius);

            if (isHeightNumber == false || isRadiusNumber == false)
            {
                Console.WriteLine("Error");
            }
            else
            {
                Console.WriteLine($"V = {pi * height * (Math.Pow(radius, 2))}");
            }
        }
    }
}