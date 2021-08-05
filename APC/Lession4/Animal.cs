using System;
namespace Lession4
{
    // sealed class Animal: Object
    abstract class Animal: Object
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
        // public sealed override string ToString()
        // {
        //     return $"Name: {Name}, Age: {Age}";
        // }

        // public abstract string Speak();

        // public abstract string Move();
    }
}