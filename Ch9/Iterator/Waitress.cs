namespace Iterator
{
    public class Waitress
    {
        private List<IMenu> m_menus;

        public Waitress(List<IMenu> menus)
        {
            m_menus = menus;
        }


        public void PrintAllMenu()
        {
            IMenuIterator menuIterator = new MenuIterator(m_menus);

            while (menuIterator.HasNext())
            {
                IMenu menu = menuIterator.Next();
                IMenuItemIterator menuItemIterator = menu.CreateIterator();
                PrintMenu(menuItemIterator);
            }
        }

        public void PrintMenu(IMenuItemIterator menuItemIterator)
        {
            while (menuItemIterator.HasNext())
            {
                MenuItem menuItem = menuItemIterator.Next();
                Console.WriteLine($"{menuItem.GetName()}");
                Console.WriteLine($"\t- {menuItem.GetDescription()}");
                Console.WriteLine($"\t- {menuItem.GetIsVegetarian()}");
                Console.WriteLine($"\t- {menuItem.GetPrice()}");

            }
        }
    }
}