namespace AbstractFactory
{
    public class Program
    {
        public static void Main()
        {
            var beefManufacturer = new BeefManufacturer();
            IBurger beefBurger = beefManufacturer.OrderBugger();
            IPizza beefPizza = beefManufacturer.OrderPizza();

            var veggieManufacturer = new VeggieManufacturer();
            IBurger veggieBurger = veggieManufacturer.OrderBugger();
            IPizza veggiePizza = veggieManufacturer.OrderPizza();
        }
    }
}