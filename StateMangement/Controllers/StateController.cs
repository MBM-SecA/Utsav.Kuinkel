using Microsoft.AspNetCore.Mvc;
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

        //1.2 Query String (Query Parameters)


        return View();
    }

    [HttpGet]
    public ViewResult Second(string name, int age)
    {
        return View();
    }

    [HttpPost]
    public bool Second(string collegeName)
    {
        return true;
    }
}