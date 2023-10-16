using System.ComponentModel;

namespace TemplateMethod
{
    public class Coffee
    {
        public void PrepareRecipe()
        {
            BoilWater();
            BrewCoffeeGrinds();
            PourInCup();
            AddSugarAndMilk();
        }

        public void BoilWater()
        {
            Console.WriteLine("Boiling Water");
        }

        public void BrewCoffeeGrinds()
        {
            Console.WriteLine("Dripping Coffee through Filter");
        }

        public void AddSugarAndMilk()
        {
            Console.WriteLine("Adding Sugar and Milk");
        }

        public void PourInCup()
        {
            Console.WriteLine("Pouring into Cup");
        }
    }
}