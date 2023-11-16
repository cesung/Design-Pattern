namespace Iterator
{
    public class DinerMenuIterator : IMenuItemIterator
    {

        private MenuItem[] m_menuItems;
        private int m_itemIndex = 0;

        public DinerMenuIterator(MenuItem[] menuItems)
        {
            m_menuItems = menuItems;
        }

        public bool HasNext()
        {
            return (
                m_itemIndex < m_menuItems.Length &&
                m_menuItems[m_itemIndex] != null
            ) ? true : false;
        }

        public MenuItem Next()
        {
            return m_menuItems[m_itemIndex++];
        }
    }
}