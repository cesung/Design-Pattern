namespace TemplateMethod
{
    public abstract class CaffineBeverage
    {
        public abstract void PrepareRecipe();

        public void BoilWater()
        {
            Console.WriteLine("Boiling Water");
        }

        public void PourInCup()
        {
            Console.WriteLine("Pouring into Cup");
        }
    }
}