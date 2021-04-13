using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Practice2_vscode.Controllers
{
    [ApiController]
    [Route("/api/students")]
    public class StudentsController : ControllerBase
    {
        public StudentsController(ILogger<StudentsController> logger)
        {
        }

        [HttpGet]
        public List<Student> GetStudents()
        {
            List<Student> lista = new List<Student>();
            lista.Add(new Student { Name = "Jorge Martinez" });
            lista.Add(new Student { Name = "Luisa Castor" });
            lista.Add(new Student { Name = "Amanda Ramirez" });
            lista.Add(new Student { Name = "Julio Paredes" });
            lista.Add(new Student { Name = "Ernesto Morales" });
            lista.Add(new Student { Name = "Paolo Villavicencio" });
            lista.Add(new Student { Name = "Carola Claros" });
            return lista;
        }

        [HttpPost]
        public Student CreateStudent([FromBody]string studentName)
        {
            return new Student()
            { 
                Name = studentName 
            };
        }

        [HttpPut]
        public Student UpdateStudent([FromBody] Student student)
        {
            student.Name = "updated";
            return student;
        }

        [HttpDelete]
        public Student DeleteStudent([FromBody] Student student)
        {
            return student;
        }
    }
}
