using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace LessionJSON
{
    class StudentDemo
    {
        public static void Main(){
            string path = @"C:\CodeGym\Class\C0621H2\APC\LessionJSON\data";
            string file = "student.json";
            // string responseData = string.Empty;
            // using(StreamReader sr = File.OpenText(Path.Combine(path,file))){
            //     responseData = sr.ReadToEnd();
            // }
            // var result = JsonConvert.DeserializeObject<StudentRes>(responseData);
            var result = FileHelper.ReadFile<StudentRes>(Path.Combine(path,file));
            
            
            Console.WriteLine($"Name\t\tGender\t\tAge");
            foreach(Student std in result.students){
                Console.WriteLine(std.ToString());
            }

            var stdProcess = new List<StudentProcess>();
            foreach(Student std in result.students){
                var stdnew = new StudentProcess(){
                    age = std.age,
                    gender = std.gender,
                    name = std.name,
                    scores = std.scores
                };
                stdProcess.Add(stdnew);
            }
            var stdUpdate = new StudentUpdate(){
                students = stdProcess
            };
            // using(StreamWriter sw = File.CreateText(Path.Combine(path,"student_update.json"))){
            //     var jsonData = JsonConvert.SerializeObject(stdUpdate);
            //     sw.Write(jsonData);
            // }
            FileHelper.WriteFile<StudentUpdate>(Path.Combine(path,"student_update.json"), stdUpdate);
            FileHelper.WriteFile<StudentRes>(Path.Combine(path,"student_update2.json"), result.students);
        }
    }

    class Score
    {
        public string name { get; set; }
        public double value { get; set; }
        public override string ToString()
        {
            return $"{name}:\t{value}\n";
        }
    }

    class Student
    {
        public string name { get; set; }
        public string gender { get; set; }
        public int age { get; set; }
        public List<Score> scores { get; set; }

        public override string ToString()
        {
            var info = $"{name}\t\t{gender}\t\t{age}\n";
            foreach(Score score in scores){
                info+=$"\t\t{score.ToString()}";
            }
            return info;
        }
    }

    class StudentProcess : Student{
        public double avescore => CalsAveScore();
        public string rank => Rank();

        private double CalsAveScore(){
            double total = 0;
            foreach(Score score in scores){
                total += score.value;
            }
            return Math.Round(total/scores.Count,1);
        }

        private string Rank(){
            string rank = "Yếu";
            switch (Math.Floor(avescore))
            {
                case 10:
                case 9:{
                    rank = "Xuất sắc";
                    break;
                }
                case 8:{
                    rank = "Giỏi";
                    break;
                }
                case 7:
                {
                    rank = "Khá";
                    break;
                }
                case 6:
                case 5:
                {
                    rank = "Trung bình";
                    break;
                }
            }
            return rank;
        }
    }

    class StudentRes
    {
        public List<Student> students { get; set; }
    }

    class StudentUpdate
    {
        public List<StudentProcess> students { get; set; }
    }
}