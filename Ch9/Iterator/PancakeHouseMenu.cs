namespace Iterator
{
    public class PancakeHouseMenu : IMenu
    {
        private List<MenuItem> m_menuItems;

        public PancakeHouseMenu()
        {
            m_menuItems = new List<MenuItem>();

            AddItem(
                "K&B's Pancake Breakfast",
                "Pancakes with scrambled eggs and toast",
                true,
                2.99
            );

            AddItem(
                "Regular Pancake Breakfast",
                "Pancakes with fried eggs, sausage",
                false,
                2.99
            );

            AddItem(
                "Bluebarry Pancakes",
                "Pancakes made with fresh blueberries",
                true,
                3.49
            );

            AddItem(
                "Waffles",
                "Waffles with your choice of blueberries or strawberries",
                true,
                3.59
            );
        }

        public void AddItem(
            string name,
            string description,
            bool isVegetarian,
            double price
        )
        {
            MenuItem menuItem = new MenuItem(name, description, isVegetarian, price);
            m_menuItems.Add(menuItem);
        }

        public IMenuItemIterator CreateIterator()
        {
            return new PancakeHouseMenuIterator(m_menuItems);
        }
    }
}