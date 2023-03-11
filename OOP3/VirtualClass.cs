namespace OOP3
{
    internal class VirtualClass
    {
        public virtual string Name { get; set; }

        public void NormalMethod()
        {
            Console.WriteLine("NormalMethod");
        }

        public virtual int VirtualMethod(int y )
        {
            Console.WriteLine("VirtualMethod" + y);
            return y;
        }

        public virtual void VirtualVoidMethod()
        {
            Console.WriteLine("VirtualVoidMethod");
        }

        public virtual void VirtualEmptyMethod()
        {
            
        }
    }
}
