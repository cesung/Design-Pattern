using System.Runtime.InteropServices;
using System.Security.Cryptography;

namespace Facade
{
    public class TheaterLights
    {
        public string Description { get; set; }

        public TheaterLights(string description)
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

        public void Dim(int level)
        {
            Console.WriteLine($"{Description} dimming to {level}%");
        }

        public override string ToString()
        {
            return Description;
        }

    }
}