namespace OOP2
{
    internal class Doctor : Human
    {
        public short y;
        public Doctor()
        {
            
        }
        public Doctor(short t) : base(t)
        {
            y = t;
            Console.WriteLine(y + "doctor CTOR");
        }
        public void TestMethod()
        {
            Name = "ELizabeta Vachaganovna";
            Age = y;
            PublicHelloMen();
            InternalByMen();
            ProtectedWhyMen();
        }
    }
}
