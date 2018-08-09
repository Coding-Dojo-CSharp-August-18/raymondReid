using System;
using System.Linq;

namespace Puzzles
{
    class Program
    {
        static void Main(string[] args)
        {
            //ranarray();
            //Cointoss();
            Names();
        }
        static void ranarray()
        {
            Console.WriteLine("This is a Random Array");
            Random a = new Random();
            int[] arr = new int[10];
            for (int i =0; i < 10; i++)
            {
                arr[i] = a.Next(5, 25);
                Console.WriteLine(arr[i]);
            }
            Console.WriteLine("**********");
            Console.WriteLine("Minimum: " + arr.Min());
            Console.WriteLine("Max: " + arr.Max());
            Console.WriteLine("Total: " + arr.Sum());
            Console.WriteLine("**********");
        }
        static void Cointoss()
        {
            Console.WriteLine("Coin Toss: ");
            Random coin = new Random();
            int[] toss = new int[1];
            toss[0] = coin.Next(1,100);
            if (toss[0] % 2 == 0)
            {
                Console.WriteLine("Heads");
            }
            else
            {
                Console.WriteLine("Tails");
            }
            Console.WriteLine("**********");

        }
        static void Names()
        {
            string[] name = {"Todd", "Tiffany", "Charlie", "Geneva", "Sydney"}; 
            shuffle(name);
            for(int j = 0; j < 5; j++)
            {
                Console.WriteLine(name[j]);
            }           
        }
        public static void shuffle(string[] a)
        {
            
            Random rand = new Random();
            for(string i = 0; i < 5; i++)
            {
                swap(a, i, i + rand.Next(len - i));

            }
        }
        public static void swap(string[] name, string a,string b)
        {
            string temp = name[a];
            name[a] = name[b];
            name[b] = temp;
        }
    }
}
