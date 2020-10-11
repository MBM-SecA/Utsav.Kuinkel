using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;


public class EmployeeController : Controller
{
    public ActionResult Index()
    {
        List<Person> employees = Person.GetPerson();
        return View(employees);
    }

    public ActionResult Detail(int id)
    {
        List<Person> employees = Person.GetPerson();
        var employee = from person in employees where person.Id == id select person;
        Console.Write(employee.First());
        var requiredEmployee = employee.ToList();
        return View(requiredEmployee);
    }


}