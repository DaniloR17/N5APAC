using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using PAC.Domain;
using PAC.IBusinessLogic;
using PAC.WebAPI.Filters;

namespace PAC.WebAPI
{



    [ApiController]
    [Route("[controller]")]
    public class StudentController : ControllerBase
    {

        private IStudentLogic _studentLogic;

        public StudentController(IStudentLogic studentLogic)
        {
            _studentLogic = studentLogic;
        }


        [HttpGet]
        public IActionResult GetStudents()
        {
            return Ok(_studentLogic.GetStudents());
        }

        [HttpGet("{id}")]
        public IActionResult GetStudentsById( int id)
        {
            return Ok(_studentLogic.GetStudentById(id));
        }


        [HttpPost]
        public IActionResult InsertStudent([FromBody] Student newStudent)
        {
            _studentLogic.InsertStudents(newStudent);
            return Ok(newStudent);
        }

    }
}
