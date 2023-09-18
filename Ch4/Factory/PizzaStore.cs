using System.Runtime.InteropServices;

namespace Factory
{
    public abstract class PizzaStore
    {
        // public SimplePizzaFactory simplePizzaFactory;

        // public PizzaStore(SimplePizzaFactory simplePizzaFactory)
        // {
        //     this.simplePizzaFactory = simplePizzaFactory;
        // }

        public Pizza? OrderPizza(string type)
        {
            // Pizza? pizza = simplePizzaFactory.CreatePizza(type);
            Pizza? pizza = CreatePizza(type);

            pizza?.Prepare();
            pizza?.Bake();
            pizza?.Cut();
            pizza?.Box();

            return pizza;
        }

        protected abstract Pizza? CreatePizza(string type);
    }
}