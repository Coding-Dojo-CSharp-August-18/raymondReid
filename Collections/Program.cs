using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            // array to hold int 0 to 9
            int[] num = {0,1,2,3,4,5,6,7,8,9};
            // array to hold names
            string[] name = {"Tim", "Martin", "Nikki", "Sara"};
            // array of bool
            string[] TFarray = {"True", "False", "True", "False", "True", "False", "True", "False", "True", "False"};

            // list of ice cream flavors
            List<string> icecream = new List<string>();
            icecream.Add("Mint Chip");
            icecream.Add("Rocky Road");
            icecream.Add("Salted Carmel");
            icecream.Add("Cookie n Cream");
            icecream.Add("Cherry");
            icecream.Add("Neopalatin");
            icecream.Add("Vanilla");
            icecream.Add("Chocolate");
            icecream.Add("Pistachio");
            icecream.Add("Moose Tracks");

            // Lenght of array
            Console.WriteLine("We have {0} ice creams in our list.", icecream.Count);
            Console.WriteLine("The third ice cream in list: {0}",icecream[2]);
            icecream.Remove("Salted Carmel");
            Console.WriteLine("We now have {0} ice cream in out list.", icecream.Count);

            // Dictionary
            Dictionary<string,string> Fav = new Dictionary<string,string>();
            Fav.Add("Tim", "Rocky Road");
            Fav.Add("Martin", "Vanilla");
            Fav.Add("Nikki", "Pistachio");
            Fav.Add("Sara", "Moose Tracks");
            Console.WriteLine("Dictionary:");
            foreach (KeyValuePair<string,string> entry in Fav)
            {
                Console.WriteLine(entry.Key + " - " + entry.Value);
            }
            
            {
                
            }

        }
    }
}
