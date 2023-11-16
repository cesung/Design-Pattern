namespace Iterator
{
    public class MenuItem
    {
        private string m_name;
        private string m_description;
        private bool m_isVegetarian;
        private double m_price;

        public MenuItem(
            string name,
            string description,
            bool isVegetarian,
            double price
        )
        {
            m_name = name;
            m_description = description;
            m_isVegetarian = isVegetarian;
            m_price = price;
        }

        public string GetName()
        {
            return m_name;
        }

        public string GetDescription()
        {
            return m_description;
        }

        public bool GetIsVegetarian()
        {
            return m_isVegetarian;
        }

        public double GetPrice()
        {
            return m_price;
        }
    }
}