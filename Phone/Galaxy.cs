using System;

namespace Phone
{
    public class Galaxy : Phone, IRingable 
    {
        public Galaxy(string versionNumber, int batteryPercentage, string carrier, string ringTone) 
            : base(versionNumber, batteryPercentage, carrier, ringTone) {}
        public string Ring() 
        {
            Console.WriteLine($"... {this.ringTone} ...");
            
        }
        
        public string Unlock() 
        {
            Console.WriteLine($"Galaxy {this.versionNumber} unlocked with fingerprint scanner");
            
        }
        public override void DisplayInfo() 
        {
            Console.WriteLine("##########################################");
            Console.WriteLine($"{this.versionNumber}");
            Console.WriteLine($"{this.batteryPercentage}");
            Console.WriteLine($"{this.carrier}");
            Console.WriteLine($"{this.ringTone}"); 
            Console.WriteLine("##########################################");           
        }
    }
}