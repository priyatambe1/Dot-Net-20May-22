using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Models;


namespace WebApplication2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {

        SampleDB2Context db = new SampleDB2Context();
        [HttpGet]
        public List<Employee> Get()
        {
            return db.Employees.ToList();
        }
      /*  [HttpGet]
        [Route("StudentsWithCourses")]
        public List<StudentWithCourse> GetStudentsWithCourse()
        {
            return db.TblStudents.Join(db.TblCourses, x => x.CourseId, y => y.Id, (x, y) => new StudentWithCourse { CourseName = y.CourseName, FirstName = x.FirstName, LastName = x.LastName, Gender = x.Gender, Id = x.Id }).ToList();
        }  */
        [HttpPost]
        public string Post([FromBody] Employee employee)
        {
            Employee s = new Employee();
            s.FirstName = employee.FirstName;
            s.LastName = employee.LastName;
            
            s.Gender = employee.Gender;
            db.Employees.Add(s);
            db.SaveChanges();
            return "Success";
        }
        [HttpPut]
        public string Put([FromBody] Employee employee)
        {
            var employeeObj = db.Employees.Where(x => x.Id == employee.Id);
            if (employeeObj != null)
            {
                db.Employees.Update(employee);
                db.SaveChanges();
                return "Success";
            }

            return "Fail";
        }

        [HttpDelete]
        public string Delete([FromBody] int Id)
        {
            var employeeObj = db.Employees.Where(x => x.Id == Id).FirstOrDefault();
            if (employeeObj != null)
            {
                db.Employees.Remove(employeeObj);
                db.SaveChanges();
                return "Success";
            }

            return "Fail";
        }
    }
}
