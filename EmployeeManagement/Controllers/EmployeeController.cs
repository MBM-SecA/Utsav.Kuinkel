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

    public ActionResult CardList()
    {
        List<Person> employees = Person.GetPerson();
        return View(employees);
    }

    public ActionResult Detail([FromQuery] int id)
    {
        List<Person> employees = Person.GetPerson();
        var employee = from person in employees where person.Id == id select person;
        // Console.Write(employee.First());
        var requestedEmployee = employee.First();
        return View(requestedEmployee);
    }

    public ActionResult Add()
    {
        return View();
    }

    [HttpPost]
    public ActionResult<string> Add([FromForm] Person person)
    {
        return "Recorded Successfully!!!";
    }



}