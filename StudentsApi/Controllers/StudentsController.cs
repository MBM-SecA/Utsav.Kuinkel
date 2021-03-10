using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using System.Linq;


[Route("students")]
[ApiController]
public class StudentController: ControllerBase
{
    private readonly StudentsContext db;
     public StudentController(StudentsContext _db){

            db = _db;
        }

    [HttpGet]
    [Route("all")]
    public ActionResult GetAllStudents()
    {
        var students = db.Student.ToList();
        return Ok(students);
    }

    [HttpGet]
    [Route("{name}")]
    public ActionResult GetStudentsById(string name)
    {
        var students = db.Student.ToList();

        var student = students.Where(x => x.Name == name).FirstOrDefault();
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