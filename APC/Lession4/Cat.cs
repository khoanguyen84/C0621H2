namespace Lession4
{
    class Cat : Animal, IAnimal
    {

        public int Legs { get; set; }
        public Cat(string name, int age, int legs) : base(name, age)
        {
            this.Legs = legs;
        }

        public override string ToString(){
            return $"{base.ToString()}, Legs:{Legs}";
        }
        public string Speak()
        {
            return "Meo meo";
        }

        public string Move()
        {
            return "Move by 4 legs";
        }

        public string Walk()
        {
            throw new System.NotImplementedException();
        }

        public string Swimming()
        {
            throw new System.NotImplementedException();
        }
    }
}