using System.Linq;
using System;
class ComplexType
{
    public void LearnComplexTypes()
    {
        var countries = Country.GetCountries();

        var asianCountriesNotInvaded = from country in countries
                                       where country.Continent == "Asia" && country.IsInvaded == false
                                       select country;

        Console.WriteLine("Asian countries not invaded");
        foreach (var country in asianCountriesNotInvaded)
        {

            Console.WriteLine($"Name: {country.Name}");

        }
        Console.WriteLine("Asian Countries having population less than 30 millions");
        var asianCountries = from country in countries
                             where country.Continent == "Asia" && country.Population < 30000000
                             select country;
        foreach (var country in asianCountries)
        {

            Console.WriteLine($"Name: {country.Name}\tPopulation: {country.Population}");

        }

        // var asianCountriesAscrnding = 
    }
}