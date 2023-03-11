namespace OOP3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TestClass testClass = new TestClass(89);
            TestClass testClass1 = new TestClass();
            testClass1.NormalMethod();
            testClass1.VirtualMethod(65);
            testClass1.VirtualVoidMethod();
            testClass1.VirtualEmptyMethod();
        }
    }
}