namespace Factory
{
    public class Program
    {
        public static void Main()
        {
            PizzaStore nyPizzaStore = new NYPizzaStore();
            nyPizzaStore.OrderPizza("Cheese");

            PizzaStore chicagoPizzaStore = new ChicagoPizzaStore();
            chicagoPizzaStore.OrderPizza("Clams");

            // PizzaStore nyPizzaStore = new NYPizzaStore();
            // nyPizzaStore.OrderPizza("Cheese");

            // PizzaStore chicagoPizzaStore = new ChicagoPizzaStore();
            // chicagoPizzaStore.OrderPizza("Pepperoni");

            // DependentPizzaStore dependentPizzaStore = new DependentPizzaStore();
            // dependentPizzaStore.OrderPizza("NY", "Greek");

        }
    }
}