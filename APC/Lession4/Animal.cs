using System;
namespace Lession4
{
    class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        protected string color {get;set;}
        private bool gender;

        public Animal(string Name, int Age)
        {
            this.Name = Name;
            this.Age = Age;
        }

        // public virtual string Info(){
        //     return $"Name: {Name}, Age: {Age}";
        // }

        public override string ToString()
        {
            return $"Name: {Name}, Age: {Age}";
        }
    }
}