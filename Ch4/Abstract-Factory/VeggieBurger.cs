namespace AbstractFactory
{
    public class VeggieBurger : IBurger
    {
        public void Prepare()
        {
            Console.WriteLine("Prepare Ingredient for VeggieBurger");
        }

        public void Bake()
        {
            Console.WriteLine("Bake Burger Bread for 1 minutes at 350F");
        }

        public void Assemble()
        {
            Console.WriteLine("Assemble VeggieBurger");
        }

        public void Box()
        {
            Console.WriteLine("Box the VeggieBurger");
        }
    }
}