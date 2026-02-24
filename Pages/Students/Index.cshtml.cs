using Microsoft.AspNetCore.Mvc.RazorPages;
using StudentPortal.Models;
using StudentPortal.Services;

namespace StudentPortal.Pages.Students
{
    public class IndexModel : PageModel
    {
        private readonly StudentService _studentService;

        public IndexModel(StudentService studentService)
        {
            _studentService = studentService;
        }

        public List<Student> Students { get; set; } = new List<Student>();

        public void OnGet()
        {
            Students = _studentService.GetAllStudents();
        }
    }
}
