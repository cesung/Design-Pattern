namespace Iterator
{
    public class PancakeHouseMenuIterator : IMenuItemIterator
    {

        List<MenuItem> m_menuItems;
        private int m_itemIndex = 0;

        public PancakeHouseMenuIterator(List<MenuItem> menuItems)
        {
            m_menuItems = menuItems;
        }

        public bool HasNext()
        {
            return (
                m_itemIndex < m_menuItems.Count
            ) ? true : false;
        }

        public MenuItem Next()
        {
            return m_menuItems[m_itemIndex++];
        }
    }
}