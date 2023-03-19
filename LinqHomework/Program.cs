using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            static void Separator()
            {
                Console.WriteLine("----------------------------------------------------");
            }

            var countryList = new List<string>
            {
             "Ukraine",
             "USA",
             "Mexico",
             "Brasil",
             "Czech Rep.",
             "Poland"

            };

            var nameList = new List<string>
            {
             "Alex",
             "Ann",
             "Jane",
             "Grace",
             "Dmytro",
             "Ihor",
             "Kate",
             "Daria",
             "Marie",
             "George"
            };

            var lastNameList = new List<string>
            {
             "Clark",
             "Smith",
             "Daniels",
             "Potter",
             "Jameson",
             "Jameson",
             "Williams",
             "Brown",
             "Davis",
             "Garcia",
             "Lopez",
             "Taylor"
            };

            var random = new Random();
            var users = new List<User>();
            for (int i = 0; i < 100; i++)
            {
                users.Add(new User
                {
                    FirstName = nameList[random.Next(nameList.Count)],
                    LastName = lastNameList[random.Next(lastNameList.Count)],
                    Country = countryList[random.Next(countryList.Count)],
                    Age = random.Next(14, 74)
                });
            }
            users.Display();
            Separator();
            //users.GroupBy(x => x.Country)
            //     .OrderByDescending(x => x.Count())
            //     .Take(1)                
            //     .Display();
           
            

        }
    }
}
