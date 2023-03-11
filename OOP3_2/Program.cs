namespace OOP3_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AnimalType animal = new AnimalType();
            animal.Voice(Animals.Dog);
            animal.Voice(Animals.Cat);
            animal.Voice(Animals.Lion);
            animal.Voice(Animals.ddd);
        }
    }
}