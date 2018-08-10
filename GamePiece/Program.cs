using System;

namespace GamePiece
{
    class Program
    {
        static void Main(string[] args)
        {
            Human ninja = new Human("Tony",5,10,10,100);
            Human fighter = new Human();
            Console.WriteLine($"My Ninja {ninja.Name} has {ninja.strength} strenght points!");
        }
    }
}
