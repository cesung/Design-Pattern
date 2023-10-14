using System.ComponentModel;

namespace Facade
{
    public class PopcornPopper
    {
        public string Description { get; set; }
        public PopcornPopper(string description)
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

        public void Pop()
        {
            Console.WriteLine($"{Description}Start Poping");
        }

        public override string ToString()
        {
            return Description;
        }
    }

}