using System.Collections.Generic;

public class Person
{
    public double Salary { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Address { get; set; }
    public char Gender { get; set; }
    public int Id { get; set; }

    public static List<Person> GetPerson()
    {
        Person empl1 = new Person() { FirstName = "Utsav", LastName = "Kuinkel", Address = "Mulpani", Gender = 'M', Salary = 100.0, Id = 1 };
        Person empl2 = new Person() { FirstName = "Utsav", LastName = "Kuinkel", Address = "Mulpani", Gender = 'M', Salary = 100.0, Id = 2 };
        Person empl3 = new Person() { FirstName = "Utsav", LastName = "Kuinkel", Address = "Mulpani", Gender = 'M', Salary = 100.0, Id = 3 };
        Person empl4 = new Person() { FirstName = "Utsav", LastName = "Kuinkel", Address = "Mulpani", Gender = 'M', Salary = 100.0, Id = 4 };
        Person empl5 = new Person() { FirstName = "Utsav", LastName = "Kuinkel", Address = "Mulpani", Gender = 'M', Salary = 100.0, Id = 5 };
        Person empl6 = new Person() { FirstName = "Utsav", LastName = "Kuinkel", Address = "Mulpani", Gender = 'M', Salary = 100.0, Id = 6 };
        Person empl7 = new Person() { FirstName = "Utsav", LastName = "Kuinkel", Address = "Mulpani", Gender = 'M', Salary = 100.0, Id = 7 };
        Person empl8 = new Person() { FirstName = "Utsav", LastName = "Kuinkel", Address = "Mulpani", Gender = 'M', Salary = 100.0, Id = 8 };

        return new List<Person>() { empl1, empl2, empl3, empl4, empl5, empl6, empl7, empl8 };
    }

}