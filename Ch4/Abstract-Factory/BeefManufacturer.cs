namespace AbstractFactory
{
    public class BeefManufacturer : Restaurant
    {
        public override IBurger CreateBurger()
        {
            return new BeefBurger();
        }

        public override IPizza CreatePizza()
        {
            return new BeefPizza();
        }
    }
}