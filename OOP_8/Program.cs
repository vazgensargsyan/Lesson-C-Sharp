using System.Collections;

namespace OOP_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List<int> myNumbers = new List<int>();
            //myNumbers.AddRange(new int[] { 11, 22, 33 });
            //myNumbers.Add(12);
            //myNumbers.Add(35);
            //myNumbers.Add(86);
            //myNumbers.Add(93);
            //myNumbers.Add(45);
            //myNumbers.Add(78);
            //myNumbers.Add(89);
            //myNumbers.Add(21);
            //myNumbers.Add(36);
            //foreach(int i in myNumbers)
            //{
            //    Console.WriteLine(i);
            //}

            //Dictionary<string, string> myDictionary = new Dictionary<string, string>();
            //myDictionary.Add("15", "vvv");
            //myDictionary.Add("28", "fff");
            //myDictionary.Add("89", "ggg");
            //foreach(var (key, value) in myDictionary)
            //{
            //    Console.WriteLine(key + " ---> " + value);
            //}

            Dictionary<int, string> janr = new Dictionary<int, string>();
            janr.Add(1, "Janr1");
            janr.Add(2, "Janr2");
            janr.Add(3, "Janr3");
            janr.Add(4, "Janr4");

            Hashtable kinoJanr = new Hashtable();
            kinoJanr.Add("Kino1", "Janr1");
            kinoJanr.Add("Kino2", "Janr1");
            kinoJanr.Add("Kino3", "Janr1");
            kinoJanr.Add("Kino4", "Janr2");
            kinoJanr.Add("Kino5", "Janr2");
            kinoJanr.Add("Kino6", "Janr2");
            kinoJanr.Add("Kino7", "Janr3");
            kinoJanr.Add("Kino8", "Janr3");
            kinoJanr.Add("Kino9", "Janr3");
            kinoJanr.Add("Kino10", "Janr4");
            kinoJanr.Add("Kino11", "Janr4");
            kinoJanr.Add("Kino12", "Janr4");

            Hashtable kinoPrice = new Hashtable();
            kinoPrice.Add("Kino1", 13.5d);
            kinoPrice.Add("Kino2", null);
            kinoPrice.Add("Kino3", null);
            kinoPrice.Add("Kino4", 22d);
            kinoPrice.Add("Kino5", null);
            kinoPrice.Add("Kino6", 35.5);
            kinoPrice.Add("Kino7", null);
            kinoPrice.Add("Kino8", null);
            kinoPrice.Add("Kino9", null);
            kinoPrice.Add("Kino10", 100);
            kinoPrice.Add("Kino11", null);
            kinoPrice.Add("Kino12", null);

            Console.WriteLine("If you want see kino press y else press n");
            char yesOrNo = Char.Parse(Console.ReadLine());
            if(yesOrNo == 'y')
            {
                Console.WriteLine("Choos janr");
                foreach (var (key, value) in janr)
                {
                    Console.WriteLine(value + " janr, press " + key);
                }
                byte choosJanr = Byte.Parse(Console.ReadLine());

                janr.TryGetValue(choosJanr, out string choosJanrName);


                foreach (var key1 in kinoJanr.Keys)
                {
                    if(kinoJanr[key1] == choosJanrName)
                    {
                        Console.WriteLine(key1 + " kino, price ");
                    }
                }
            }




            
        }
    }
}