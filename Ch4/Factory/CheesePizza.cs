namespace Factory
{
    public class CheesePizza : Pizza
    {
        IPizzaIngredientFactory pizzaIngredientFactory;

        public CheesePizza(IPizzaIngredientFactory pizzaIngredientFactory)
        {
            this.pizzaIngredientFactory = pizzaIngredientFactory;
        }

        public override void Prepare()
        {
            Dough = pizzaIngredientFactory.CreateDough();
            Sauce = pizzaIngredientFactory.CreateSauce();
            Cheese = pizzaIngredientFactory.CreateCheese();
            Console.WriteLine($"Preparing {Name} With Ingreidents:\n\tDough: {Dough.Name}\n\tSauce: {Sauce.Name}\n\tCheese: {Cheese.Name}");
        }
    }
}