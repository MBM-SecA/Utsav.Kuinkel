using System;
using System.Linq;
using System.Collections.Generic;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            // LINQ - Language Integrated Query
            // LINQ to object 

            int[] numbers = { 23, 34, 56, 12, 23, 89, 67, 10, 55, 46, 26, 79, 54, 58, 15, 7 };

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

            // foreach (var item in namesWithR2)
            // {
            //     Console.WriteLine(item);
            // }

            //Projections
            var squaredNumbers = numbers.Select(x => x * x);

            //Ordering
            var ascendingOrder = from num in numbers
                                 orderby num
                                 select num;

            var decendingOrder = from num in numbers
                                 orderby num descending
                                 select num;

            //Partitioning
            var skip5 = numbers.Skip(5).Take(5);
            var takefirst5 = numbers.Take(5);

            //Quantifiers
            var anyEvenNumbers = numbers.Any(x => x % 2 == 0);
            var allEvenNumbers = numbers.All(x => x % 2 == 0);
            var containsElement = numbers.Contains(23);
            var repeat = Enumerable.Repeat("Hello World", 10);
            var range = Enumerable.Range(1, 1000);
            Console.WriteLine($"{anyEvenNumbers} {allEvenNumbers}");

            foreach (var number in range)
            {
                Console.WriteLine(number);
            }
            foreach (var word in repeat)
            {
                Console.WriteLine(word);
            }

            //HW - Is there any african country in country collection
            //HW - print first two asian country in ascending order that are 

        }
    }
}
