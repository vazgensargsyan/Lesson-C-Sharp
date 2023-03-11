namespace Shabat1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int a = ELiMiBan.Sum(10, 20);
            //int b = ELiMiBan.Sum(10, 30);
            //int c = ELiMiBan.Mul(10, 20);
            //Console.WriteLine(a);
            //Console.WriteLine(b);
            //Console.WriteLine(c);
            //int[] a = new int[] {1, 2, 3};
            //try
            //{
            //    Console.WriteLine(a[4]); ;
            //}
            //catch(Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //finally
            //{
            //    Console.WriteLine("Finally");
            //}

            string inputString = "aabaasss";
            string palindrom = "";
            for (int i = inputString.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(inputString[i]);
                palindrom += inputString[i];
            }
            Console.WriteLine(palindrom);

        }
    }
}