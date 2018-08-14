using System;

namespace GamePiece
{
    
    public class Human
    {
        public string name;
        //The { get; set; } format creates accessor methods for the field specified
        //This is done to allow flexibility
        public int health { get; set; }
        public int strength { get; set; }
        public int intelligence { get; set; }
        public int dexterity { get; set; }
        public Human(string person)
        {
            name = person;
            strength = 3;
            intelligence = 3;
            dexterity = 3;
            health = 100;
        }
        public Human(string person, int str, int intel, int dex, int hp)
        {
            name = person;
            strength = str;
            intelligence = intel;
            dexterity = dex;
            health = hp;
        }
        public void attack(object obj)
        {
            Human enemy = obj as Human;
            if(enemy == null)
            {
                Console.WriteLine("Failed Attack");
            }
            else
            {
                enemy.health -= strength * 5;
            }
        }
    }
    public class wizard : Human
    {
        public int health = 50;
        public int intelligence = 25;

        public void heal(object obj)
        {
            wizard life = obj as wizard;
            if(life == null)
            {
                Console.WriteLine("No Health given");
            }
            else
            {
                life.health += intelligence * 10;
            }
        }
        public void fireball(object obj)
        {
            Random rand = new Random();
            wizard fire = obj as wizard;
            if(fire == null)
            {
                Console.WriteLine("Failed Attack");
            }
            else
            {
                fire.health -= health - rand.Next(20,50);
            }
        }
    }
    public class Ninja : Human
    {
        public int dexterity = 175;

        public void steal(object obj)
        {
            Ninja theft = obj as Ninja;
            if(theft == null)
            {
                Console.WriteLine("Failed graft");
            }
            else
            {
                steal.health += health + 10;
            }
        }
        public void get_away(object obj)
        {
            Ninja get_away = obj as Ninja;
            if(get_away == null)
            {
                Console.WriteLine("Failed escape");
            }
            else
            {
                get_away.health -= health - 15;
            }
        }
    }
    public class Samurai : Human
    {
        public int health = 200;

        public void death_blow(object obj)
        {
            Samurai enemy = obj as Samurai;
            if(enemy.health > 50)
            {
                Console.WriteLine("Failed Attack");
            }
            else
            {
                enemy.health = 0;
            }
        }
        public void meditate(object obj)
        {
            health = 200
        }
    }

}