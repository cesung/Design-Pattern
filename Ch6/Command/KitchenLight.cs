namespace Command
{
    public class KitchenLight : ILight
    {
        public string Name { get; set; } = "KitchenLight";

        public void On()
        {
            Console.WriteLine("Kitchen Light is On");
        }

        public void Off()
        {
            Console.WriteLine("Kitchen Light is Off");
        }
    }
}
