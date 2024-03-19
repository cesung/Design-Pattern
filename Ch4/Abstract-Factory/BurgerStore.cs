namespace AbstractFactory
{
    public abstract class BurgerStore
    {
        public IBurger OrderBugger()
        {
            IBurger burger = CreateBurger();

            burger.Prepare();
            burger.Bake();
            burger.Assemble();
            burger.Box();

            return burger;
        }

        // Factory Method
        public abstract IBurger CreateBurger();
    }
}