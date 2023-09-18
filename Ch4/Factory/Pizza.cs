using Factory.Ingredients;

namespace Factory
{
    public abstract class Pizza
    {
        public string? Name { get; set; }

        public Dough? Dough { get; set; }

        public Sauce? Sauce { get; set; }

        public Veggies[]? Veggies { get; set; }

        public Cheese? Cheese { get; set; }

        public Pepperoni? Pepperoni { get; set; }

        public Clams? Clams { get; set; }

        // Cutomized Preparing
        public abstract void Prepare();

        public /*abstract*/ void Bake()
        {
            Console.WriteLine("Bake for 25 minutes at 350F");
        }

        public /*abstract*/ void Cut()
        {
            Console.WriteLine("Cutting the pizza into diagonal slices");
        }

        public /*abstract*/ void Box()
        {
            Console.WriteLine("Place pizza in official PizzaStore box");
        }

    }

}