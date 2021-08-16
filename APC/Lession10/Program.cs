using System;
using System.Collections.Generic;
using System.Linq;

namespace Lession10
{
    class Program
    {
        static void Main(string[] args)
        {
            List<List<int>> matrix = new List<List<int>>(){
                                                                new List<int>(){1,2,3,5},
                                                                new List<int>(){1,2,3,5},
                                                                new List<int>(){1,2,3,5},
                                                            };

            // foreach(List<int> ints in matrix)
            // {
            //     foreach(int value in ints)
            //     {
            //         Console.Write($"{value} ");
            //     }
            //     Console.WriteLine();
            // }

            // List<Student> students = new List<Student>();
            // Student std1 = new Student(){
            //     StudentId = 1,
            //     Fullname = "Khoa",
            //     Age = 18,
            //     Email = "Khoa.nguyen@codegym.vn"
            // };
            // students.Add(std1);
            // Console.WriteLine(students[0]);

            // Queue<Student> stds = new Queue<Student>();
            
            // Stack<Student> stdss = new Stack<Student>();

            // Dictionary<int, Student> stds = new Dictionary<int, Student>();
            // stds.Add(std1.StudentId, std1);
            // stds.Add(2, std1);

            // foreach(Student std in stds.Values){
            //     Console.WriteLine(std.ToString());
            // }

            // foreach(int key in stds.Keys){

            // }

            // foreach(KeyValuePair<int,Student> item in stds)
            // {
            //     Console.WriteLine($"key: {item.Key}, value: {item.Value.ToString()}");
            // }

            // HashSet<Student> stds = new HashSet<Student>();
            // stds.Add(std1);
            // stds.Add(std1);
            // foreach(Student std in stds){
            //     Console.WriteLine(std.ToString());
            // }

            // LinkedList<Student> stds = new LinkedList<Student>();
            // LinkedListNode<Student> node = new LinkedListNode<Student>(std1);
            // stds.AddFirst(node);

            //Lamda Expression
            //LinQ

            List<Student> students = new List<Student>();
            Student std1 = new Student(){
                StudentId = 1,
                Fullname = "Khoa",
                Age = 18,
                Email = "Khoa.nguyen@codegym.vn"
            };
            students.Add(std1);
            Student std2 = new Student(){
                StudentId = 2,
                Fullname = "Nguyên",
                Age = 20,
                Email = "nguyen.truong@codegym.vn"
            };
            students.Add(std2);
            int maxAge = 0;
            Student StudentWithMaxAge = new Student();
            foreach(Student std in students){
                if(std.Age > maxAge){
                    maxAge = std.Age;
                    StudentWithMaxAge = std;
                }
            }
            Console.WriteLine(StudentWithMaxAge.ToString());

            int max = students.Max(s => s.Age);
            Student StudentWithHighAge = students.Single(s => s.Age == max);

            Console.WriteLine(StudentWithHighAge.ToString());

            Student stdLinq = (from s in students
                                where s.Age == (students.Max(s => s.Age))
                            select s
                         ).Single();
            
            Console.WriteLine(stdLinq.ToString());

            Student st = students.Find(s => s.Fullname.Contains("a") && s.Age >=18);
            students.Remove(st);
            Console.WriteLine(st.ToString());
        }
    }
}


