namespace Factory
{
    public class ClamsPizza : Pizza
    {
        IPizzaIngredientFactory pizzaIngredientFactory;

        public ClamsPizza(IPizzaIngredientFactory pizzaIngredientFactory)
        {
            this.pizzaIngredientFactory = pizzaIngredientFactory;
        }

        public override void Prepare()
        {
            Dough = pizzaIngredientFactory.CreateDough();
            Sauce = pizzaIngredientFactory.CreateSauce();
            Cheese = pizzaIngredientFactory.CreateCheese();
            Clams = pizzaIngredientFactory.CreateClams();
            Console.WriteLine($"Preparing {Name} With Ingredients:\n\tDough: {Dough.Name}\n\tSauce: {Sauce.Name}\n\tCheese: {Cheese.Name}\n\tClams: {Clams.Name}");
        }
    }
}