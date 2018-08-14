using System;
namespace Phone
{    
    
    public class Nokia : Phone, IRingable 
    {
        public Nokia(string versionNumber, int batteryPercentage, string carrier, string ringTone) 
            : base(versionNumber, batteryPercentage, carrier, ringTone) {}
            public string Ring() 
            {
                Console.WriteLine($"...{this.ringTone}...");
            }
            public string Unlock() 
            {
                Console.WriteLine($"Nokia {this.versionNumber} unlocked with passcode");
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