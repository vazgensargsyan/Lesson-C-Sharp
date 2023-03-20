namespace OOP_6
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            DelegateMethods delegateMethods = new DelegateMethods();
            MyDelegate myDelegate = new MyDelegate(delegateMethods.myMethod1);
            myDelegate += delegateMethods.myMethod2;
            myDelegate += delegateMethods.myMethod3;
            myDelegate("myDelegate");
        }
        
    }
}