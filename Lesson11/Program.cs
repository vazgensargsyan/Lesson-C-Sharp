namespace Lesson11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Factorial factorial = new Factorial();
            Console.WriteLine(factorial.fac(5));
            Console.WriteLine(factorial.mult(5, null, 5, 5));
        }
    }
}