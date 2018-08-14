using System;

namespace DeckofCard
{
    class Program
    {
        static void Main(string[] args)
        {
            card myCard = new card();
            foreach (stringVal item in myCard)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(myCard.stringVal[6]);
            Console.WriteLine(myCard.suit[2]);
            Console.WriteLine(myCard.val[6]);
        }
    }
}
