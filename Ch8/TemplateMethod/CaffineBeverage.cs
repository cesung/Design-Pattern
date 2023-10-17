namespace TemplateMethod
{
    public abstract class CaffineBeverage
    {
        public void PrepareRecipe()
        {
            BoilWater();
            Brew();
            PourInCup();
            if (CheckCustomerWantsCodiments())
            {
                AddCodiments();
            }
        }

        public abstract void Brew();
        public abstract void AddCodiments();

        public void BoilWater()
        {
            Console.WriteLine("Boiling Water");
        }

        public void PourInCup()
        {
            Console.WriteLine("Pouring into Cup");
        }

        public virtual bool CheckCustomerWantsCodiments()
        {
            return true;
        }
    }
}