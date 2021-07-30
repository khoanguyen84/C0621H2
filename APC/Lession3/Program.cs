using System;

namespace Lession3
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("Khoa Nguyen");
            Student std2 = new Student("Nam Nguyen", "28 NTP");
            Console.WriteLine(student.Fullname);
            Console.Write(student.Address);
            Console.WriteLine(std2.Fullname);
            Console.Write(std2.Address);
            Student.Slogen();
            Console.WriteLine(Student.University);

            Console.WriteLine(Message.Success);
            Console.WriteLine(Setting.PI);
            Setting.PI = 345;
            Console.WriteLine(Setting.PI);

            Lession31.MyRandom rnd = new Lession31.MyRandom();
            rnd.Next();

            std2.Password = "1234";
            std2.PW = "4534";
            var pw = std2.PW;

            std2.SetPassword("34564");
        }
    }
}
