// using System.Reflection.Metadata.Ecma335;

// namespace Factory
// {
//     public class DependentPizzaStore
//     {
//         public Pizza? CreatePizza(string region, string type)
//         {
//             Pizza? pizza = null;
//             if (region == "NY")
//             {
//                 switch (type)
//                 {
//                     case "Cheese":
//                         pizza = new NYCheesePizza();
//                         break;

//                     case "Greek":
//                         pizza = new NYGreekPizza();
//                         break;

//                     case "Pepperoni":
//                         pizza = new NYPepperoniPizza();
//                         break;
//                 }
//             }
//             if (region == "Chicago")
//             {
//                 switch (type)
//                 {
//                     case "Cheese":
//                         pizza = new ChicagoCheesePizza();
//                         break;

//                     case "Greek":
//                         pizza = new ChicagoGreekPizza();
//                         break;

//                     case "Pepperoni":
//                         pizza = new ChicagoPepperoniPizza();
//                         break;
//                 }
//             }

//             return pizza;
//         }

//         public void OrderPizza(string region, string type)
//         {
//             Pizza? pizza = CreatePizza(region, type);

//             pizza?.Prepare();
//             pizza?.Bake();
//             pizza?.Cut();
//             pizza?.Box();
//         }
//     }
// }