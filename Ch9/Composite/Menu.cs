namespace Composite
{
    public class Menu : MenuComponent
    {
        private readonly List<MenuComponent> m_menuComponents = new List<MenuComponent>();
        private readonly string m_name;
        private readonly string m_description;

        // Note: GetPrice() and IsVegetarian() doesn't make sense to Menu (composite/internal node)

        public Menu(string name, string description)
        {
            m_name = name;
            m_description = description;
        }

        public override void Add(MenuComponent menuComponent)
        {
            m_menuComponents.Add(menuComponent);
        }

        public override void Remove(MenuComponent menuComponent)
        {
            m_menuComponents.Remove(menuComponent);
        }

        public override MenuComponent GetChild(int i)
        {
            return m_menuComponents[i];
        }

        public override string GetName()
        {
            return m_name;
        }

        public override string GetDescription()
        {
            return m_description;
        }


        public override void Print()
        {
            Console.WriteLine($"Name : {GetName()}");
            Console.WriteLine($"Description: {GetDescription()}");

            // Since Menu is composite and contains both MenuItems and Menu, the Print() method
            // should print everything it contains
            // Implementing Print() is easy by leveraging the recursive

            foreach (MenuComponent menuComponent in m_menuComponents)
            {
                // Since Menu and MenuItems both implement Print() method, we just call the Print() here
                // Note: if, during this iteration, we encounter another Menu Object, its Print() method
                // will start another iteration and/or recursive call
                menuComponent.Print();
            }
        }

    }
}