using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using StudentPortal.Models;
using StudentPortal.Services;

namespace StudentPortal.Pages.Students
{
    public class DeleteModel : PageModel
    {
        private readonly StudentService _studentService;

        public DeleteModel(StudentService studentService)
        {
            _studentService = studentService;
        }

        public Student? Student { get; set; }

        public IActionResult OnGet(int id)
        {
            Student = _studentService.GetStudentById(id);
            if (Student == null)
            {
                return NotFound();
            }

            return Page();
        }

        public IActionResult OnPost(int id)
        {
            var success = _studentService.DeleteStudent(id);
            if (!success)
            {
                return NotFound();
            }

            return RedirectToPage("Index");
        }
    }
}
