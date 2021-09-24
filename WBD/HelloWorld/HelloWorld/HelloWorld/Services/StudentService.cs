using HelloWorld.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloWorld.Services
{
    public class StudentService : IStudentService
    {
        private static List<Student> Students;
        public StudentService()
        {
            Students = new List<Student>() {
                new Student()
                {
                    StudentId = 1,
                    Fullname = "Khoa Nguyen",
                    Dob = DateTime.Parse("2000-10-10"),
                    Gender = true
                },
                new Student()
                {
                    StudentId = 2,
                    Fullname = "Nam Thu",
                    Dob = DateTime.Parse("2000-10-10"),
                    Gender = true
                },
                new Student()
                {
                    StudentId = 3,
                    Fullname = "Huy Thu",
                    Dob = DateTime.Parse("2000-10-10"),
                    Gender = true
                }
            };
        }
        public List<Student> Gets()
        {
            return Students;
        }

        public bool Create(Student student)
        {
            try
            {
                student.StudentId = Students.Max(s => s.StudentId) + 1;
                Students.Add(student);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
