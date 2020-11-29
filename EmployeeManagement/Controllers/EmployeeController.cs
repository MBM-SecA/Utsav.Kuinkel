using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;


public class EmployeeController : Controller
{
    private readonly EMSContext db;

    public EmployeeController(EMSContext _db) => db = _db;
    public ActionResult Index()
    {
        var employees = db.People.ToList();
        return View(employees);
    }

    public ActionResult CardList()
    {
        var employees = db.People.ToList();
        return View(employees);
    }

    public ActionResult Detail(int id)
    {
        var employees = db.People.ToList();
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