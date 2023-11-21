namespace Composite
{
    public class Program
    {
        public static void Main()
        {
            MenuComponent PancakeHouseMenu = new Menu("Pancake House Menu", "Breakfast");
            MenuComponent DinerMenu = new Menu("Diner Menu", "Lunch");
            MenuComponent CafeMenu = new Menu("Cafe Menu", "Dinner");
            MenuComponent DessertMenu = new Menu("Dessert Menu", "Dessert of course!");

            MenuComponent Menus = new Menu("All Menu", "All Menu Combined");
            Menus.Add(PancakeHouseMenu);
            Menus.Add(DinerMenu);
            Menus.Add(CafeMenu);

            DinerMenu.Add(
                new MenuItem(
                    "Pasta",
                    "Spaghetti with Marinara Sauce, and a slice of sourdough bread",
                    true,
                    3.89
                )
            );
            DinerMenu.Add(DessertMenu);

            DessertMenu.Add(
                new MenuItem(
                    "Apple Pie",
                    "Apple Pie with a flakey crust, topped with vanilla ice cream",
                    true,
                    1.59
                )
            );

            Waitress waitress = new Waitress(Menus);
            waitress.PrintMenu();
        }
    }
}