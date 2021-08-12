using System;
namespace Lession10
{
    class Generic
    {
        public static void Main()
        {
            MyGeneric<Student> myGeneric = new MyGeneric<Student>();
            Student std1 = new Student(){
                StudentId = 1,
                Fullname = "Khoa",
                Age = 18,
                Email = "Khoa.nguyen@codegym.vn"
            };
            myGeneric.Add(std1);
            myGeneric.Add(std1);
            myGeneric.Add(std1);
            myGeneric.Add(std1);
            myGeneric.Add(std1);
            myGeneric[6] = std1;
            // Console.WriteLine(myGeneric.data[0].ToString());
            Console.WriteLine(myGeneric[0].ToString());
            // Console.WriteLine(myGeneric.Count);
            // Console.WriteLine(myGeneric.Capacity);
        }
    }
}
