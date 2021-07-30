using System;
namespace Lession3
{
    class Student
    {
        private string password;
        public string Fullname {get; private set;}//readonly
        public string Address;
        public static string University = "CodeGym";
        //Contructors
        public Student(string Fullname){
            this.Fullname = Fullname;
        }
        public Student(string Fullname, string Address){
            this.Fullname = Fullname;
            this.Address = Address;
        }

        //getter setter

        public static string Slogen(){
            return "still breath still alive";
        }

        public string GetPassword(){
            return password;
        }

        public void SetPassword(string pw){
            password = pw;
        }

        public string Password{
            get { 
                return password.ToLower(); 
            }
            set { 
                password = value;
            }
        }

        public string PW {
            get => password;
            set => password = value;
        }
    }
}