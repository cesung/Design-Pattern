namespace AbstractFactory
{
    public class Program
    {
        public static void Main()
        {
            var beefBugerManufacturer = new BeefBugerManufacturer();
            IBurger beefBurger = beefBugerManufacturer.OrderBugger();

            var veggieBugerManufacturer = new VeggieBugerManufacturer();
            IBurger veggieBurger = veggieBugerManufacturer.OrderBugger();
        }
    }
}