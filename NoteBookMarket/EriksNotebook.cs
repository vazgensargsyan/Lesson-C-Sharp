namespace OOP_4
{
    internal class EriksNotebook : INotebook
    {
        //public string Brand { get { return Brand; } set { value = "myString"; } }
        public string Brand { get; set; }
        public string SubBrand { get; set; }
        public double Weight { get; set; }
        public byte Ram { get; set; }
        public int count { get; set; }

        public void FirstAcceleration()
        {
            Console.WriteLine("Brand " + Brand);
            Console.WriteLine("EriksNotebook : INotebook : FirstAcceleration");
        }

        void INotebook.SecondAcceleration(int u)
        {
            Console.WriteLine("EriksNotebook : INotebook : INotebook.SecondAcceleration : u : " + u);
        }
    }
}