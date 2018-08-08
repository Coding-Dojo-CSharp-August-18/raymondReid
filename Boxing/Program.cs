using System;
using System.Collections.Generic;


namespace Boxing
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> box = new List<string>();
            int sev = 7;
            string zero = sev.ToString();
            box.Add(zero);
            int twenty = 28;
            string one = twenty.ToString();
            box.Add(one);
            int negone = -1;
            string two = negone.ToString();
            box.Add(two);
            bool toto = true;
            string three = toto.ToString();
            box.Add(three);
            box.Add("chair");

            foreach (string item in box)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(sev + twenty + negone);
        }
    }
}
