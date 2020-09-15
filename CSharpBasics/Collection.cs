using System;
using System.Collections.Generic;

namespace LearnCollections
{
    public class Collection
    {
        public void LearnList()
        {
            List<byte> ages = new List<byte>();

            ages.Add(12);
            ages.Add(102);
            ages.Add(120);
            ages.Add(145);
            ages.Add(200);


            ages.Remove(12);

            List<Country> countries = new List<Country>();

            Country country = new Country();

            countries.Add(country);


        }

        internal void LearnDictionary()
        {
            Dictionary<string, string> countryCapitals = new Dictionary<string, string>();

            countryCapitals.Add("Nepal", "Kathmandu");
            countryCapitals.Add("Japan", "Tokyo");
            countryCapitals.Add("America", "New York");

            foreach (var country in countryCapitals)
            {
                Console.WriteLine($"Country: {country.Key} Capital city: {country.Value}");
            }

        }
    }

    public class Country
    {
        public string Name { get; set; }
    }
}