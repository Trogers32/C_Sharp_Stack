using System;

namespace Phone
{
    class Program
    {
        static void Main(string[] args)
        {
            Galaxy s8 = new Galaxy("S8", 100, "T-Mobile", "DOOO doo DEEE");
            Nokia ell = new Nokia("1100", 60, "Metro", "REEEEEEeeeEEEEEeeEeEeEEE");
            Console.WriteLine(s8.Ring());
            Console.WriteLine(s8.Unlock());
            s8.DisplayInfo();
            Console.WriteLine(ell.Ring());
            Console.WriteLine(ell.Unlock());
            ell.DisplayInfo();
        }
    }
    public abstract class Phone 
    {
        public string _versionNumber;
        public int _batteryPercentage;
        public string _carrier;
        public string _ringTone;
        public Phone(string versionNumber, int batteryPercentage, string carrier, string ringTone){
            _versionNumber = versionNumber;
            _batteryPercentage = batteryPercentage;
            _carrier = carrier;
            _ringTone = ringTone;
        }
        // abstract method. This method will be implemented by the subclasses
        public abstract void DisplayInfo();
    }
    public interface IRingable 
    {
        string Ring();
        string Unlock();
    }
    public class Nokia : Phone, IRingable 
    {
        public Nokia(string versionNumber, int batteryPercentage, string carrier, string ringTone) 
            : base(versionNumber, batteryPercentage, carrier, ringTone) {}
        public string Ring() 
        {
            return _ringTone;
        }
        public string Unlock() 
        {
            return $"Nokia {_versionNumber} unlocked with fingerprint scanner.";
        }
        public override void DisplayInfo() 
        {
            Console.WriteLine($"$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$\nNokia {_versionNumber}\nBattery: {_batteryPercentage}\nCarrier: {_carrier}\nRing Tone: {_ringTone}\n$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$\n");         
        }
    }
    public class Galaxy : Phone, IRingable 
    {
        public Galaxy(string versionNumber, int batteryPercentage, string carrier, string ringTone) 
            : base(versionNumber, batteryPercentage, carrier, ringTone) {}
        public string Ring() 
        {
            return _ringTone;
        }
        public string Unlock() 
        {
            return $"Galaxy {_versionNumber} unlocked with fingerprint scanner.";
        }
        public override void DisplayInfo() 
        {
            Console.WriteLine($"$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$\nGalaxy {_versionNumber}\nBattery: {_batteryPercentage}\nCarrier: {_carrier}\nRing Tone: {_ringTone}\n$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$\n");         
        }
    }
}
