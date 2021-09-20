using HelloWorld.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloWorld.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            //ViewBag.StudentId = id;
            //ViewData["StudentId"] = id;

            var students = new List<Student>();
            var std1 = new Student()
            {
                StudentId = 1,
                Fullname = "Khoa Nguyen",
                Dob = DateTime.Parse("2000-10-10"),
                Gender = "Male"
            };
            var std2 = new Student()
            {
                StudentId = 2,
                Fullname = "Nam Thu",
                Dob = DateTime.Parse("2000-10-10"),
                Gender = "Male"
            };
            var std3 = new Student()
            {
                StudentId = 3,
                Fullname = "Huy Thu",
                Dob = DateTime.Parse("2000-10-10"),
                Gender = "Male"
            };
            students.Add(std1);
            students.Add(std2);
            students.Add(std3);
            return View("~/Views/Student/Student.cshtml", students);
        }

        //Attribute routing
        //[Route("/Student/Detail/{stdId}/{fn}")]
        public IActionResult Detail(int stdId, string fn)
        {
            var studentDetail = new StudentDetail()
            {
                Fullname = fn,
                StudentId = stdId
            };
            return View(studentDetail);
        }
    }

    public class StudentDetail
    {
        public int StudentId { get; set; }
        public string Fullname { get; set; }
    }
}
