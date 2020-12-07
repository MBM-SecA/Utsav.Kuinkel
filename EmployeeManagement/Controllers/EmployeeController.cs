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
        var employee = db.People.Find(id);
        // var employee = from person in employees where person.Id == id select person;
        // Console.Write(employee.First());
        var requestedEmployee = employee;
        return View(requestedEmployee);
    }

    public ActionResult Add()
    {
        return View();
    }

    [HttpPost]
    public ActionResult<string> Add([FromForm] Person person)
    {
        db.People.Add(person);
        db.SaveChanges();
        return RedirectToAction(nameof(Index));
    }

    public ActionResult Edit(int id)
    {
        var employee = db.People.Find(id);
        return View(employee);
    }

    [HttpPost]
    public ActionResult<string> Edit([FromForm] Person person)
    {
        db.People.Attach(person);
        db.People.Update(person);
        db.SaveChanges();
        return RedirectToAction(nameof(Index));
    }

    public ActionResult Delete(int id)
    {
        var employee = db.People.Find(id);
        return View(employee);
    }

    [HttpPost]
    public ActionResult Delete(Person person)
    {
        db.People.Attach(person);
        db.People.Remove(person);
        db.SaveChanges();
        return RedirectToAction(nameof(Index));
    }
}