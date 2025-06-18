using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Student_API_Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetStudents()
        {
            var students = new[]
            {
                new { Id = 1, Name = "Amar", City="Satra" },
                new { Id = 2, Name = "Akbar", City="Pune" },
                new { Id = 3, Name = "Mahesh", City="Mumbai" }
            };

            return Ok(students);
        }
    }
}
