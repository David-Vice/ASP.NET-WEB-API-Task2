using System;

namespace ASP.NET_First_WEB_API.Models
{
    public class Student
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public DateTime Bday { get; set; }
        public int Group { get; set; }
    }
}
