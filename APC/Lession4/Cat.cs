namespace Lession4
{
    class Cat : Animal
    {

        public int Legs { get; set; }
        public Cat(string name, int age, int legs) : base(name, age)
        {
            this.Legs = legs;
        }

        public override string ToString(){
            return $"{base.ToString()}, Legs:{Legs}";
        }
    }
}