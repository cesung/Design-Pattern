namespace Factory
{
    public class NYPizzaStore : PizzaStore
    {
        protected override Pizza? CreatePizza(string type)
        {
            Pizza? pizza = null;
            IPizzaIngredientFactory pizzaIngredientFactory = new NYPizzaIngredientFactory();

            switch (type)
            {
                case "Cheese":
                    pizza = new CheesePizza(pizzaIngredientFactory);
                    pizza.Name = "NY-style Cheese Pizza";
                    break;

                case "Clams":
                    pizza = new ClamsPizza(pizzaIngredientFactory);
                    pizza.Name = "NY-style Clams Pizza";
                    break;

            }
            return pizza;

            // switch (type)
            // {
            //     case "Cheese":
            //         pizza = new NYCheesePizza();
            //         break;

            //     case "Greek":
            //         pizza = new NYGreekPizza();
            //         break;

            //     case "Pepperoni":
            //         pizza = new NYPepperoniPizza();
            //         break;
            // }
            // return pizza;
        }
    }
}