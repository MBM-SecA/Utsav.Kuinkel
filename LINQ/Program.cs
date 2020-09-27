using System;
using System.Linq;
using System.Collections.Generic;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            var countries = Country.GetCountries();
            foreach (var country in countries)
            {
                if (country.IsInvaded)
                {
                    Console.WriteLine($"Name: {country.Name}\tContinent:{country.Continent}\tPopulation:{country.Population}\tArea:{country.Area}\tINVADED");
                }
                else if (!country.IsInvaded)
                {
                    Console.WriteLine($"Name: {country.Name}\tContinent:{country.Continent}\tPopulation:{country.Population}\tArea:{country.Area}\tNOT INVADED");
                }
            }
            Console.WriteLine("Asian Countries having population less than 30 millions");
            foreach (var country in countries)
            {
                if (country.Continent == "Asia" && country.Population < 30000000)
                {
                    Console.WriteLine($"Name: {country.Name}\tPopulation: {country.Population}");
                }
            }
        }



        void Basics()
        {
            // LINQ - Language Integrated Query
            // LINQ to object 

            int[] numbers = { 23, 34, 56, 12, 23, 89, 67, 10 };

            //Fetch numbers which are less than 50

            var numbersLessThan50 = numbers.Where(x => x < 50);

            // Using sql query syntax - query expression

            var numbersLessThanFifty = from num in numbers
                                       where num < 50
                                       select num;

            string[] names = { "utsav", "upasana", "sarala", "upendra", "millie", "pewdiepie", "elon", "gates", "ronaldo", "ram", "Ramsey", "Ramsaili" };

            var nameswithR = from name in names
                             where name.ToLower().StartsWith("r") && name.Length > 3
                             select name;

            var namesWithR2 = names.Where(name => name.Length > 3 && name.ToLower().StartsWith("r"));

            foreach (var item in namesWithR2)
            {
                Console.WriteLine(item);
            }


        }
    }
}
