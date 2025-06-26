using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace students_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private static readonly List<object> students_list = new List<object>()
        {
            new {Id=1, Name="Amar", Email="amar@gmail.com", Age=27, City="Pune"},
            new {Id=2, Name="Radha", Email="radha@gmail.com", Age=22, City="Mumbai"},
            new {Id=3, Name="Sheetal", Email="sheetal@gmail.com", Age=23, City="Nagpur"}
        };

        [HttpGet]
        public IActionResult GetStudents()
        {
            return Ok(students_list);

        }
    }
}
