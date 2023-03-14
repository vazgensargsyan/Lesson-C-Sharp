namespace OOP_4
{
    internal interface INotebook
    {
        public string Brand { get; set; }
        public string SubBrand { get; set; }
        public double Weight { get; set; }
        public byte Ram { get; set; }
        int count { get; set; }
        public void FirstAcceleration();
        
        public void SecondAcceleration(int t)
        {
            Console.WriteLine("INotebook : SecondAcceleration : t :" + t);
        }
    }
}
