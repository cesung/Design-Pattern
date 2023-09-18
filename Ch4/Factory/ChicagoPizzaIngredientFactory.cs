using Factory.Ingredients;

namespace Factory
{
    public class ChicagoPizzaIngredientFactory : IPizzaIngredientFactory
    {
        public Dough CreateDough()
        {
            return new ThickCrustDough();
        }
        public Sauce CreateSauce()
        {
            return new PlumTomatoSauce();
        }
        public Cheese CreateCheese()
        {
            return new MozzarellaCheese();
        }
        public Veggies[] CreateVeggies()
        {
            Veggies[] veggies = { new EggPlant(), new Spinach() };
            return veggies;
        }
        public Pepperoni CreatePepperoni()
        {
            return new SlicedPepperoni();
        }
        public Clams CreateClams()
        {
            return new FrozenClams();
        }
    }
}