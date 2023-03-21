namespace OOP_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GenericClass<string> genericClass = new GenericClass<string>();
            bool isString = false;
            Console.WriteLine(genericClass.IsString("valodik", ref isString));
            Console.WriteLine(isString);
        }
    }
}