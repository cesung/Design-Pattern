using System.Reflection.Metadata.Ecma335;

namespace Command
{
    public class GarageDoor : IDoor
    {
        public string Name { get; set; } = "GarageDoor";

        public void Up()
        {
            Console.WriteLine("Garage Door is Opened");
        }

        public void Down()
        {
            Console.WriteLine("Garage Door is Closed");
        }

        public void Stop()
        {
            Console.WriteLine("Garage Door is Stoped");
        }

        public void LightOn()
        {
            Console.WriteLine("Garage Light is On");
        }

        public void LightOff()
        {
            Console.WriteLine("Garage Light is Off");
        }
    }
}