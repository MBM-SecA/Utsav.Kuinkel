using System;
using System.IO;
using System.Linq;
using LearnCollections;

namespace CSharpBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            // Square square = new Square(34.5);
            // square.Display();
            // Rectangle rectangle = new Rectangle(10, 20);
            // rectangle.Display();
            FileIO fileIO = new FileIO();
            // fileIO.LearnFileHandeling();
            // fileIO.LearnFileInfo();
            fileIO.LearnDirectories();

            var countriesText = File.ReadAllText("countries.txt");
            string[] countries = countriesText.Split("\r\n");
            var countriesWithNInitial = countries.Select(x => x.StartsWith("N"));
            Console.WriteLine("Countries starting from N are: ");
            foreach (var country in countriesWithNInitial)
                Console.WriteLine(country);
        }
    }
}
