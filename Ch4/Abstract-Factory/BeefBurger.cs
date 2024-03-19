namespace AbstractFactory
{
    public class BeefBurger : IBurger
    {
        public void Prepare()
        {
            Console.WriteLine("Prepare Ingredient for BeefBurger");
        }

        public void Bake()
        {
            Console.WriteLine("Bake burger bread for 25 minutes at 350F");
        }

        public void Assemble()
        {
            Console.WriteLine("Assemble BeefBurger");
        }

        public void Box()
        {
            Console.WriteLine("Box the BeefBurger");
        }
    }
}