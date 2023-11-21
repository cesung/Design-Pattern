namespace Composite
{
    public class MenuItem : MenuComponent
    {
        private readonly string m_name;
        private readonly string m_description;

        private readonly bool m_vegetarian;

        private readonly double m_price;

        public MenuItem(string name, string description, bool vegetarian, double price)
        {
            m_name = name;
            m_description = description;
            m_vegetarian = vegetarian;
            m_price = price;
        }

        // Note: Add(), Remove(), and GetChild() doest make sense to MenuItem (leaf node)

        public override string GetName()
        {
            return m_name;
        }

        public override string GetDescription()
        {
            return m_description;
        }

        public override bool IsVegetarian()
        {
            return m_vegetarian;
        }

        public override double GetPrice()
        {
            return m_price;
        }

        public override void Print()
        {
            Console.WriteLine($"Name : {GetName()}");
            Console.WriteLine($"Description: {GetDescription()}");
            Console.WriteLine($"Vegetarian : {IsVegetarian()}");
            Console.WriteLine($"Price: {GetPrice()}");
        }
    }
}