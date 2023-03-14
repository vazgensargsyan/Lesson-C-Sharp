namespace OOP_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EriksNotebook eriksNotebook = new EriksNotebook();
            INotebook notebook = new EriksNotebook();
            eriksNotebook.FirstAcceleration();
            notebook.SecondAcceleration(89);
        }
    }
}