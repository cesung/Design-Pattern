namespace AbstractFactory
{
    public class VeggieManufacturer : Restaurant
    {
        public override IBurger CreateBurger()
        {
            return new VeggieBurger();
        }

        public override IPizza CreatePizza()
        {
            return new VeggiePizza();
        }
    }
}