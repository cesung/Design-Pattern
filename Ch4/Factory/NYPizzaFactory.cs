// namespace Factory
// {
//     public class NYPizzaFactory : SimplePizzaFactory
//     {
//         public override Pizza? CreatePizza(string type)
//         {
//             Pizza? pizza = null;

//             switch (type)
//             {
//                 case "Cheese":
//                     pizza = new NYCheesePizza();
//                     break;

//                 case "Greek":
//                     pizza = new NYGreekPizza();
//                     break;

//                 case "Pepperoni":
//                     pizza = new NYPepperoniPizza();
//                     break;
//             }

//             return pizza;
//         }
//     }

// }