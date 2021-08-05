namespace Lession4
{
    interface IAnimal
    {
        int Legs { get; set; }
        string Walk();
        string Swimming();
        string Speak();
    }
}