namespace Lession4
{
    class Dog : Animal
    {
        public string EyeColor { get; set; }
        public string Color { get => color; set => color = value; }

        public Dog(string name, int age, string eyeColor) : base(name, age)
        {
            this.EyeColor = eyeColor;
        }

        public override string ToString(){
            return $"{base.ToString()}, Eye color:{EyeColor}";
        }
    }
}