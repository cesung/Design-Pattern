using System.Reflection.Metadata;

namespace Iterator
{
    public class DinerMenu : IMenu
    {
        public const int c_maxMenuItems = 6;
        private int m_numberOfItems = 0;
        private MenuItem[] m_menuItems;

        public DinerMenu()
        {
            m_menuItems = new MenuItem[c_maxMenuItems];

            AddItem(
                "Vegetarian BLT",
                "(Fakin') Bacon with lettuce & tomato on whole wheat",
                true,
                2.99
            );

            AddItem(
                "BLT",
                "Bacon with lettuce & tomato on whole wheat",
                false,
                2.99
            );

            AddItem(
                "Soup of the day",
                "Soup of the day, with a side of potato salad",
                false,
                3.29
            );

            AddItem(
                "Hotdog",
                "A hot dog, with sauerkraut, relish, onions, topped with cheese",
                false,
                3.05
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
            if (m_numberOfItems > c_maxMenuItems)
            {
                Console.WriteLine("Menu is full! Can't add item to menu");
            }
            else
            {
                m_menuItems[m_numberOfItems++] = menuItem;
            }
        }

        public IMenuItemIterator CreateIterator()
        {
            return new DinerMenuIterator(m_menuItems);
        }
    }
}