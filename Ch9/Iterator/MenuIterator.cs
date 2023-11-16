namespace Iterator
{
    public class MenuIterator : IMenuIterator
    {

        public List<IMenu> m_menus;
        public int itemIndex = 0;

        public MenuIterator(List<IMenu> menus)
        {
            m_menus = menus;
        }

        public bool HasNext()
        {
            return (
                itemIndex < m_menus.Count
            ) ? true : false;
        }

        public IMenu Next()
        {
            return m_menus[itemIndex++];
        }
    }

}