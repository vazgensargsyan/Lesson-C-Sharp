namespace OOP2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Doctor doctor = new Doctor(120);
            doctor.TestMethod();
            Console.WriteLine(doctor.Age+"Doctor");
            //Human human = new Human();
            //Console.WriteLine(human.Age);
        }
    }
}