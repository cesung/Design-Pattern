using System.ComponentModel;
using System.Reflection.PortableExecutable;

namespace Facade
{

    public class Proejctor
    {
        public string Description { get; set; }

        public Proejctor(string description)
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

        public void TvMode()
        {
            Console.WriteLine($"Change {Description} to TV Mode");
        }

        public void WideScreenMode()
        {
            Console.WriteLine($"Change {Description} to Wide Screen Mode");
        }

        public override string ToString()
        {
            return Description;
        }
    }
}