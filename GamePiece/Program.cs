using System;

namespace GamePiece
{
    class Program
    {
        static void Main(string[] args)
        {
            Human ninja = new Human("Tony",5,10,10,100);
            Human fighter = new Human("Balboa");
            Console.WriteLine($"My Ninja {ninja.name} has {ninja.strength} strenght points!");
            Console.WriteLine($"My Ninja {fighter.name} has {fighter.strength} strenght points!");
        }
    }
}
