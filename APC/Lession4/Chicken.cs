namespace Lession4
{
    class Chicken : IAnimal, IFlyable
    {

        public int Legs { get => Legs; set => Legs = value; }

        public string Fly()
        {
            throw new System.NotImplementedException();
        }

        public string Speak()
        {
            throw new System.NotImplementedException();
        }

        public string Swimming()
        {
            throw new System.NotImplementedException();
        }

        public string Walk()
        {
            throw new System.NotImplementedException();
        }
    }
}