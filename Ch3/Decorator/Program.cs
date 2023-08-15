namespace Decorator
{
    public class Program
    {
        public static void Main()
        {
            Beverage decaf = new Decaf(Beverage.Size.VENTI);
            decaf = new Milk(decaf);
            decaf = new Whip(decaf);
            decaf = new Whip(decaf);
            decaf = new Whip(decaf);

            Console.WriteLine($"{decaf.GetDescription()}: ${string.Format("{0:N2}", decaf.Cost())}");

            Beverage darkRost = new DarkRost(Beverage.Size.GRANDE);
            darkRost = new Milk(darkRost);
            darkRost = new Whip(darkRost);
            darkRost = new Whip(darkRost);
            darkRost = new Whip(darkRost);

            Console.WriteLine($"{darkRost.GetDescription()}: ${string.Format("{0:N2}", darkRost.Cost())}");
        }
    }
}