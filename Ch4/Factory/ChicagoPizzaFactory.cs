// namespace Factory
// {
//     public class ChicagoPizzaFactory : SimplePizzaFactory
//     {
//         public override Pizza? CreatePizza(string type)
//         {
//             Pizza? pizza = null;

//             switch (type)
//             {
//                 case "Cheese":
//                     pizza = new ChicagoCheesePizza();
//                     break;

//                 case "Greek":
//                     pizza = new ChicagoGreekPizza();
//                     break;

//                 case "Pepperoni":
//                     pizza = new ChicagoPepperoniPizza();
//                     break;
//             }

//             return pizza;
//         }
//     }

// }