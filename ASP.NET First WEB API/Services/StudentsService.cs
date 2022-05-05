using ASP.NET_First_WEB_API.Interfaces;
using ASP.NET_First_WEB_API.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_First_WEB_API.Services
{
    public class StudentsService : IStudentsService
    {
        private List<Student> _students;
        public StudentsService()
        {
            _students = new List<Student>();
        }

        public async Task<IEnumerable<Student>> GetAllStudents()
        {
            return _students;
        }
        public async Task<Student> GetStudent(int id)
        {
            return _students.Find(x => x.Id == id);
        }
        public async Task<int> AddStudent(Student student)
        {
            student.Id = _students.Count;
            _students.Add(student);
            return student.Id ?? -1;
        }
        public async Task<string> DeleteStudent(int id)
        {
            _students.Remove(_students.Where(s => s.Id == id).First());
            return "Deleted";
        }
        public async Task<string> EditStudent(int id, Student student)
        {
            Student std = _students.Find(x => x.Id == id);
            student.Id = std.Id;
            _students[_students.IndexOf(std)] = student;
            return "Edited";
        }
    }
}
