using HelloWorld.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloWorld.Services
{
    public interface IStudentService
    {
        List<Student> Gets();
        bool Create(Student student);
    }
}
