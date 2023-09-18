using Factory.Ingredients;

namespace Factory
{
    public class NYPizzaIngredientFactory : IPizzaIngredientFactory
    {
        public Dough CreateDough()
        {
            return new ThinCrustDough();
        }
        public Sauce CreateSauce()
        {
            return new MarinaraSauce();
        }
        public Cheese CreateCheese()
        {
            return new ReggianoCheese();
        }
        public Veggies[] CreateVeggies()
        {
            Veggies[] veggies = { new Garlic(), new Onion() };
            return veggies;
        }
        public Pepperoni CreatePepperoni()
        {
            return new SlicedPepperoni();
        }
        public Clams CreateClams()
        {
            return new FreshClams();
        }
    }
}