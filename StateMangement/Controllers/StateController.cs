using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

public class StateController: Controller
{
    public ViewResult First()
    {
        // StateManagement
        //1. Client Side
        //1.1 Cookies
        var name ="Utsav Kuinkel";
        //CookieOptions
        Response.Cookies.Append("user",name);

        // 1.2 Query String (Query Parameters)
        // 2. Server Side
        // 2.1 Session
        // 
        HttpContext.Session.SetString("Address","ktm");
        

        return View();
    }

    [HttpGet]
    public ViewResult Second(string name, int age)
    {
        var userAddress = HttpContext.Session.GetString("Address");

        // 2.2 Temp data
        TempData["Gaidada"]= "Nischal Upreeti";
        return View();
    }

    [HttpPost]
    public bool Second(string collegeName)
    {
        return true;
    }

    public ViewResult Third(string name, int age)
    {
        // 2.2 Temp data
        var gName = TempData["Gaidada"];
        byte value = 67;

        ViewData["Name1"] = "abc from viewdata";
        ViewBag.Name = "Gaidada";
        return View(value);
    }

}