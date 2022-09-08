using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 MyInfo = new Class1();         
            Console.WriteLine($"Name: {MyInfo.Name}, Age: {MyInfo.Age}");

            Class2 TeacherInfo = new Class2("Alex", 23);
            Console.WriteLine($"Name: {TeacherInfo.Name2}, Age: {TeacherInfo.Age2}");

            Class3 EasyMath = new Class3(93, 8);
            Console.WriteLine($"{EasyMath.Number1} * {EasyMath.Number2} = {EasyMath.Result}");

            Class4 SomePractice = new Class4();
            Console.Write("Your name: ");
            SomePractice.WordCheck = Console.ReadLine();
            Console.WriteLine(SomePractice.WordCheck);

            Console.Write("How well do you know C# (twelve point system): ");
            bool number = int.TryParse(Console.ReadLine(),out int num);
            if(number == true)
            {
                SomePractice.Knowledge("You are good in it)", SomePractice.answer2, num);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error");
                Console.ResetColor();
            }
        }
    }
}
