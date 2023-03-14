namespace OOP_4_2
{
    internal class Armenia : ICountry
    {
        public string Capital { get; set; }
        public string Language { get; set; }
        public string Nationality { get; set; }
        public int Population { get; set; }
        public int Size { get; set; }

        public void PrintFullInfo()
        {
            Console.WriteLine("Capital: " + Capital);
            Console.WriteLine("Language: " + Language);
            Console.WriteLine("Nationality: " + Nationality);
            Console.WriteLine("Population: " + Population);
            Console.WriteLine("Size: " + Size + "Kkm square");
        }
    }
}
