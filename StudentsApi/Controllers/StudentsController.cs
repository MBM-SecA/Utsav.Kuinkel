using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using System.Linq;


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

    [HttpGet]
    [Route("{name}")]
    public ActionResult GetStudentsById(string name)
    {
        var students = new string[] {"Utsav", "Kusum", "Pandey"};

        var student = students.Where(x => x == name).FirstOrDefault();
        if(student == null){
            return BadRequest();
        }
        return Ok(student);
    }


    [HttpPost]
    [Route("add")]
    public ActionResult CreateStudent(Student student)
    {
        if(student == null){
            return BadRequest();
        }
        return Created("", student);
    }
}