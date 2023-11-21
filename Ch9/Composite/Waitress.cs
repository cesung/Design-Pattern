namespace Composite
{
    public class Waitress
    {
        MenuComponent m_menu;

        public Waitress(MenuComponent menu)
        {
            m_menu = menu;
        }

        public void PrintMenu()
        {
            m_menu.Print();
        }
    }
}