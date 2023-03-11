namespace ClassTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Milk milk = new Milk(600);
            //Console.WriteLine( milk.MakeSmetan(10) );
            //Console.WriteLine( milk.MakeMatsoon(10) );
            //Console.WriteLine( milk.MakeTvarog(10) );

            StructTest structTest = new StructTest(789);
            Console.WriteLine( structTest.test("Barev tver - ") );

        }
    }
}