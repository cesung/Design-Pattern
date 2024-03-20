namespace AbstractFactory
{
    public class VeggiePizza : IPizza
    {
        public void Prepare()
        {
            Console.WriteLine("Prepare Ingredient for VeggiePizza");
        }

        public void Bake()
        {
            Console.WriteLine("Bake pizza for 25 minutes at 350F");
        }

        public void Cut()
        {
            Console.WriteLine("Cut VeggiePizza");
        }

        public void Box()
        {
            Console.WriteLine("Box the VeggiePizza");
        }
    }
}