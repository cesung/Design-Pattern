namespace TemplateMethod
{
    public class Tea : CaffineBeverage
    {
        public override void Brew()
        {
            Console.WriteLine("Steeping the Tea Bag");
        }

        public override void AddCodiments()
        {
            Console.WriteLine("Adding Lemon");
        }
    }
}