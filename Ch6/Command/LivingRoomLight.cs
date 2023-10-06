namespace Command
{
    public class LivingRoomLight : ILight
    {
        public string Name { get; set; } = "LivingRoomLight";

        public void On()
        {
            Console.WriteLine("Living Room Light is On");
        }

        public void Off()
        {
            Console.WriteLine("Living Room Light is Off");
        }
    }
}
