namespace TemplateMethod
{
    public class Coffee : CaffineBeverage
    {
        public override void Brew()
        {
            Console.WriteLine("Dripping Coffee through Filter");
        }

        public override void AddCodiments()
        {
            Console.WriteLine("Adding Sugar and Milk");
        }
    }
}