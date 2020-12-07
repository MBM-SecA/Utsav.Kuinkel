using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;


public class DepartmentController : Controller
{
    private readonly EMSContext db;

    public DepartmentController(EMSContext _db) => db = _db;
    public ActionResult Index()
    {
        var department = db.Departments.ToList();
        return View(department);
    }

    public ActionResult Add()
    {
        return View();
    }

    [HttpPost]
    public ActionResult Add([FromForm] Department department)
    {
        db.Departments.Add(department);
        db.SaveChanges();
        return RedirectToAction(nameof(Index));
    }

    public ActionResult Edit(int id)
    {
        var department = db.Departments.Find(id);
        return View(department);
    }

    [HttpPost]
    public ActionResult Edit([FromForm] Department department)
    {
        db.Departments.Attach(department);
        db.Departments.Update(department);
        db.SaveChanges();
        return RedirectToAction(nameof(Index));
    }

    public ActionResult Delete(int id)
    {
        var department = db.Departments.Find(id);
        return View(department);
    }

    [HttpPost]
    public ActionResult Delete(Department department)
    {
        db.Departments.Attach(department);
        db.Departments.Remove(department);
        db.SaveChanges();
        return RedirectToAction(nameof(Index));
    }

}