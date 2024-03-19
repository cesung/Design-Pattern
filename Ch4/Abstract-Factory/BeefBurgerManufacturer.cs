namespace AbstractFactory
{
    public class BeefBugerManufacturer : BurgerStore
    {
        public override IBurger CreateBurger()
        {
            return new BeefBurger();
        }
    }
}