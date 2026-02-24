using StudentPortal.Models;

namespace StudentPortal.Services
{
    public class StudentService
    {
        private static List<Student> _students = new List<Student>
        {
            new Student { Id = 1, Name = "John Doe", Email = "john.doe@example.com", Age = 20, EnrollmentDate = new DateTime(2024, 9, 1) },
            new Student { Id = 2, Name = "Jane Smith", Email = "jane.smith@example.com", Age = 22, EnrollmentDate = new DateTime(2023, 9, 1) },
            new Student { Id = 3, Name = "Bob Johnson", Email = "bob.johnson@example.com", Age = 21, EnrollmentDate = new DateTime(2024, 1, 15) }
        };
        
        private static int _nextId = 4;

        public List<Student> GetAllStudents()
        {
            return _students;
        }

        public Student? GetStudentById(int id)
        {
            return _students.FirstOrDefault(s => s.Id == id);
        }

        public void AddStudent(Student student)
        {
            student.Id = _nextId++;
            _students.Add(student);
        }

        public bool UpdateStudent(Student student)
        {
            var existingStudent = GetStudentById(student.Id);
            if (existingStudent == null)
                return false;

            existingStudent.Name = student.Name;
            existingStudent.Email = student.Email;
            existingStudent.Age = student.Age;
            existingStudent.EnrollmentDate = student.EnrollmentDate;
            return true;
        }

        public bool DeleteStudent(int id)
        {
            var student = GetStudentById(id);
            if (student == null)
                return false;

            _students.Remove(student);
            return true;
        }
    }
}
