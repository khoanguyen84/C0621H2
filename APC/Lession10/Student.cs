using System;
namespace Lession10
{
    class Student : Object
    {
        public int StudentId { get; set; }
        public string Fullname { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }

        public override string ToString()
        {
            return $"{StudentId}\t\t{Fullname}\t\t{Age}\t\t{Email}";
        }
    }
}