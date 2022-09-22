using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Class1 MyInfo = new Class1();         
            //Console.WriteLine($"Name: {MyInfo.Name}, Age: {MyInfo.Age}");

            //Class2 TeacherInfo = new Class2("Alex", 23);
            //Console.WriteLine($"Name: {TeacherInfo.Name2}, Age: {TeacherInfo.Age2}");

            //Class3 EasyMath = new Class3(93, 8);
            //Console.WriteLine($"{EasyMath.Number1} * {EasyMath.Number2} = {EasyMath.Result}");

            //Class4 SomePractice = new Class4();
            //Console.Write("Your name: ");
            //SomePractice.WordCheck = Console.ReadLine();
            //Console.WriteLine(SomePractice.WordCheck);

            //Console.Write("How well do you know C# (twelve point system): ");
            //bool number = int.TryParse(Console.ReadLine(),out int num);
            //if(number == true)
            //{
            //    SomePractice.Knowledge("You are good in it)", SomePractice.answer2, num);
            //}
            //else
            //{
            //    Console.ForegroundColor = ConsoleColor.Red;
            //    Console.WriteLine("Error");
            //    Console.ResetColor();
            //}

            int year1 = 2018;
            Console.WriteLine(year1);

            string model1 = "X5";
            Console.WriteLine(model1);

            Engine eng1 = new Engine("KQR165165", 132456798, 1.5f);
            Console.WriteLine(eng1);

            Wheels whe1 = new Wheels("winter tires", 14.5, 65);
            Console.WriteLine(whe1);

            Glass gla1 = new Glass("tinted glass", 2200);
            Console.WriteLine(gla1);

            Car car1 = new Car(year1, "BMW", model1, eng1, whe1, gla1);
            Console.WriteLine(car1);

        }
    }
}
