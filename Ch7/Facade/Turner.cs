using System.Diagnostics.Contracts;
using System.Dynamic;

namespace Facade
{
    public class Turner
    {
        public string Description { get; set; }

        public Turner(string description)
        {
            Description = description;
        }

        public void TurnOn()
        {
            Console.WriteLine($"Turn {Description} On");
        }

        public void TurnOff()
        {
            Console.WriteLine($"Turn {Description} Off");
        }

        public void SetAm()
        {
            Console.WriteLine("Set AM Mode");
        }

        public void SetPm()
        {
            Console.WriteLine("Set PM Mode");
        }

        public void SetFrequency(double frequency)
        {
            Console.WriteLine($"Set Frequency to {frequency}");
        }

        public override string ToString()
        {
            return Description;
        }
    }
}