using ASP.NET_First_WEB_API.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ASP.NET_First_WEB_API.Interfaces
{
    public interface IStudentsService
    {
        Task<Student> GetStudent(int id);
        Task<IEnumerable<Student>> GetAllStudents();
        Task<int> AddStudent(Student student);
        Task<string> DeleteStudent(int id);
        Task<string> EditStudent(int id, Student student);
    }
}
