using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

public class EmployeeController : Controller
{
    public ActionResult Index()
    {

        Person empl1 = new Person()
        {
            FirstName = "Utsav",
            LastName = "Kuinkel",
            Address = "Mulpani",
            Gender = 'M',
            Salary = 100.0,
        };

        Person empl2 = new Person() { FirstName = "Utsav", LastName = "Kuinkel", Address = "Mulpani", Gender = 'M', Salary = 100.0 };
        Person empl3 = new Person() { FirstName = "Utsav", LastName = "Kuinkel", Address = "Mulpani", Gender = 'M', Salary = 100.0 };
        Person empl4 = new Person() { FirstName = "Utsav", LastName = "Kuinkel", Address = "Mulpani", Gender = 'M', Salary = 100.0 };
        Person empl5 = new Person() { FirstName = "Utsav", LastName = "Kuinkel", Address = "Mulpani", Gender = 'M', Salary = 100.0 };
        Person empl6 = new Person() { FirstName = "Utsav", LastName = "Kuinkel", Address = "Mulpani", Gender = 'M', Salary = 100.0 };
        Person empl7 = new Person() { FirstName = "Utsav", LastName = "Kuinkel", Address = "Mulpani", Gender = 'M', Salary = 100.0 };
        Person empl8 = new Person() { FirstName = "Utsav", LastName = "Kuinkel", Address = "Mulpani", Gender = 'M', Salary = 100.0 };
        List<Person> employees = new List<Person>() { empl1, empl2, empl3, empl4, empl5, empl6, empl7, empl8 };
        return View(employees);
    }

    public ActionResult Detail(string firstName)
    {
        return View();
    }


}