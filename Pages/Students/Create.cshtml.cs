using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using StudentPortal.Models;
using StudentPortal.Services;
using System.ComponentModel.DataAnnotations;

namespace StudentPortal.Pages.Students
{
    public class CreateModel : PageModel
    {
        private readonly StudentService _studentService;

        public CreateModel(StudentService studentService)
        {
            _studentService = studentService;
        }

        [BindProperty]
        public Student Student { get; set; } = new Student();

        public void OnGet()
        {
            Student.EnrollmentDate = DateTime.Today;
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _studentService.AddStudent(Student);
            return RedirectToPage("Index");
        }
    }
}
