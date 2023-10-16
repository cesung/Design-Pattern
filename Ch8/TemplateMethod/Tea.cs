namespace TemplateMethod
{
    public class Tea : CaffineBeverage
    {
        public override void PrepareRecipe()
        {
            BoilWater();
            SteepTeaBag();
            PourInCup();
            AddLemon();
        }

        public void SteepTeaBag()
        {
            Console.WriteLine("Steeping the Tea Bag");
        }

        public void AddLemon()
        {
            Console.WriteLine("Adding Lemon");
        }
    }
}