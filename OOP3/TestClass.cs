namespace OOP3
{
    internal class TestClass : VirtualClass
    {
        public TestClass()
        {
            
        }
        public TestClass(int t)
        {
            base.VirtualMethod(t);
        }

        public override void VirtualEmptyMethod()
        {
            Console.WriteLine("TestClass : VirtualClass");
            base.VirtualEmptyMethod();
            Console.WriteLine("Ending TestClass : VirtualClass");
        }

        public override int VirtualMethod(int t)
        {
            return base.VirtualMethod(t);
        }
    }
}
