namespace AbstractFactory
{
    public abstract class Restaurant
    {
        public IBurger OrderBugger()
        {
            IBurger burger = CreateBurger();

            burger.Prepare();
            burger.Bake();
            burger.Assemble();
            burger.Box();
            Console.WriteLine("============================");

            return burger;
        }

        public IPizza OrderPizza()
        {
            IPizza pizza = CreatePizza();

            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();
            Console.WriteLine("============================");

            return pizza;
        }

        // Factory Method
        public abstract IBurger CreateBurger();

        // Factory Method
        public abstract IPizza CreatePizza();
    }
}