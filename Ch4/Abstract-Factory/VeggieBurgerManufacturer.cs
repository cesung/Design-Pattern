namespace AbstractFactory
{
    public class VeggieBugerManufacturer : BurgerStore
    {
        public override IBurger CreateBurger()
        {
            return new VeggieBurger();
        }
    }
}