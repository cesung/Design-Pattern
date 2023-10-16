namespace TemplateMethod
{
    public class Coffee : CaffineBeverage
    {
        public override void PrepareRecipe()
        {
            BoilWater();
            BrewCoffeeGrinds();
            PourInCup();
            AddSugarAndMilk();
        }

        public void BrewCoffeeGrinds()
        {
            Console.WriteLine("Dripping Coffee through Filter");
        }

        public void AddSugarAndMilk()
        {
            Console.WriteLine("Adding Sugar and Milk");
        }
    }
}