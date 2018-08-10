namespace GamePiece
{
    
    public class Human
    {
        public string Name = "Conan";
        public int strength = 3;
        public int intelligence = 3;
        public int dexterity = 3;
        public int health = 100;
        public Human()
        {
            
        }
        
        public Human(string val, int str, int intel, int dex, int life)
        {
            Name = val;
            strength = str;
            intelligence = intel;
            dexterity = dex;
            health = life;
        }
        public void Attack(int strength, int health)
        {
            int damage = health - (strength * 5);
            int energy = strength - 1;
            
        }

    }
}