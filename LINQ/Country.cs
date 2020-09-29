using System;
using System.Collections.Generic;

public class Country
{
    public string Name { get; set; }

    public string Continent { get; set; }

    public long Population { get; set; }

    public double Area { get; set; }

    public bool IsInvaded { get; set; }
    public DateTime IndependenceDay { get; set; }

    public Country(string name, string continent, long population, double area, bool isInvaded = true)
    {
        Name = name;
        Continent = continent;
        Area = area;
        Population = population;
        IsInvaded = isInvaded;
    }

    // public Country(string name, string continent, long population, double area)
    // {
    //     bool isInvaded = true;
    //     new Country(name, continent, population, area, isInvaded);
    // }

    public static List<Country> GetCountries()
    {
        Country c1 = new Country("Nepal", "Asia", 29136808, 123467.33, false);
        Country c2 = new Country("India", "Asia", 1380004385, 12348867.33);
        Country c3 = new Country("Bhutan", "Asia", 760000, 123467.33, false);
        Country c4 = new Country("Qatar", "Asia", 2100000, 8303.49);
        Country c5 = new Country("Syria", "Asia", 17500658, 3827.46);
        Country c6 = new Country("Lebanon", "Asia", 6825445, 8890.42);
        Country c7 = new Country("Japan", "Asia", 126476461, 64343.345, false);
        Country c8 = new Country("Pakisthan", "Asia", 220892340, 35674263.43);
        Country c9 = new Country("Saudi Arabia", "Asia", 34813871, 3632473.72, false);
        Country c10 = new Country("Vietnam", "Asia", 97338579, 918326.3);
        Country c11 = new Country("Sri Lanka", "Asia", 21413249, 1827.364);
        Country c12 = new Country("Iraq", "Asia", 40222493, 887273.46);
        Country c13 = new Country("England", "Europe", 30000000, 123467.33, false);
        Country c14 = new Country("France", "Europe", 30000000, 123467.33, false);
        Country c15 = new Country("Italy", "Europe", 300000, 123467.33, false);
        Country c16 = new Country("Spain", "Europe", 84000000, 948434.5, false);
        Country c17 = new Country("Ukraine", "Europe", 70000, 36462);
        Country c18 = new Country("Germany", "Europe", 87345345, 98273, false);
        Country c19 = new Country("Canada", "North America", 7345336452, 765432.21);
        Country c20 = new Country("USA", "North America", 30000000, 123467.33);
        Country c21 = new Country("Argentina", "South America", 6000000, 58387.263);
        Country c22 = new Country("Kenya", "Africa", 8000000, 484.734);
        Country c23 = new Country("Sudan", "Africa", 990000, 383473);
        Country c24 = new Country("Ethiopia", "Africa", 900000, 29435.768, false);
        Country c25 = new Country("Egypt", "Africa", 7000000, 36462.345, false);
        Country c26 = new Country("Camoroon", "Africa", 7000000, 36462.345, false);
        Country c27 = new Country("New Zealand", "Australia", 7000000, 36462.345, false);
        Country c28 = new Country("Australia", "Australia", 7000000, 36462.345, false);
        var countries = new List<Country> { c1, c2, c3, c4, c5, c5, c6, c7, c8, c9, c10, c11, c12, c13, c14, c15, c16, c17, c18, c19, c20, c21, c22, c23, c24, c25, c26, c27, c28 };


        return countries;
    }

}