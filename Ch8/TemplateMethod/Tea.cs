namespace TemplateMethod
{
    public class Tea
    {
        public void PrepareRecipe()
        {
            BoilWater();
            SteepTeaBag();
            PourInCup();
            AddLemon();
        }

        public void BoilWater()
        {
            Console.WriteLine("Boiling Water");
        }

        public void SteepTeaBag()
        {
            Console.WriteLine("Steeping the Tea Bag");
        }

        public void AddLemon()
        {
            Console.WriteLine("Adding Lemon");
        }

        public void PourInCup()
        {
            Console.WriteLine("Pouring into Cup");
        }
    }
}