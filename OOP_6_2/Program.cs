namespace OOP_6_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("If your office have IT privilege press 1 else 0!!!");
            byte isPrivilege = Byte.Parse(Console.ReadLine());
            Console.WriteLine("Please enter your DIRTY salary!!!");
            decimal cSalary = decimal.Parse(Console.ReadLine());
            CalcSalary calcSalary = new CalcSalary(cSalary, isPrivilege);
        }
    }
}