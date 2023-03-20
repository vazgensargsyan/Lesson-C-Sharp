namespace OOP_6
{
    public delegate string MyDelegate(string myString);
    internal class DelegateMethods
    {
        public string myMethod1(string myString)
        {
            Console.WriteLine("myMethod1 " + myString);
            return "abc";
        }
        public string myMethod2(string myString)
        {
            Console.WriteLine("myMethod2 " + myString);
            return "def";
        }
        public string myMethod3(string myString)
        {
            Console.WriteLine("myMethod3 " + myString);
            return "ghi";
        }
    }
}
