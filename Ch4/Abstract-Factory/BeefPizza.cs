namespace AbstractFactory
{
    public class BeefPizza : IPizza
    {
        public void Prepare()
        {
            Console.WriteLine("Prepare Ingredient for BeefPizza");
        }

        public void Bake()
        {
            Console.WriteLine("Bake pizza for 25 minutes at 350F");
        }

        public void Cut()
        {
            Console.WriteLine("Cut BeefPizza into several pieces");
        }

        public void Box()
        {
            Console.WriteLine("Box the BeefPizza");
        }
    }
}