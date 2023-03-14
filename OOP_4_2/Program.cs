namespace OOP_4_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Armenia armenia = new Armenia();
            ICountry country = new Armenia();
            armenia.Capital = "Yerevan";
            armenia.Language = "Armenian";
            armenia.Nationality = "Armenian";
            armenia.Population = 3000000;
            armenia.Size = 29000;
            armenia.PrintFullInfo();
            country.PrintInfo("Armenia");
        }
    }
}