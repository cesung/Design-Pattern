using System.Threading.Channels;

namespace Factory
{
    public class ChicagoPizzaStore : PizzaStore
    {
        protected override Pizza? CreatePizza(string type)
        {
            Pizza? pizza = null;
            IPizzaIngredientFactory pizzaIngredientFactory = new ChicagoPizzaIngredientFactory();
            switch (type)
            {
                case "Cheese":
                    pizza = new CheesePizza(pizzaIngredientFactory);
                    break;

                case "Clams":
                    pizza = new ClamsPizza(pizzaIngredientFactory);
                    break;
            }
            return pizza;

            // Pizza? pizza = null;
            // switch (type)
            // {
            //     case "Cheese":
            //         pizza = new ChicagoCheesePizza();
            //         break;

            //     case "Greek":
            //         pizza = new ChicagoGreekPizza();
            //         break;

            //     case "Pepperoni":
            //         pizza = new ChicagoPepperoniPizza();
            //         break;
            // }
            // return pizza;
        }
    }
}