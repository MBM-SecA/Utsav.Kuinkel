using Microsoft.AspNetCore.Mvc;


[Route("students")]
[ApiController]
public class StudentController: ControllerBase
{
    [HttpGet]
    [Route("all")]
    public ActionResult GetAllStudents()
    {
        var students = new string[] {"Utsav", "Kusum", "Pandey"};

        students = null;
        if(students == null){
            return BadRequest();
        }
        return Ok(students);
    }
}