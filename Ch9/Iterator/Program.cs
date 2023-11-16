namespace Iterator
{
    public class Program
    {
        public static void Main()
        {
            var pancakeHouseMenu = new PancakeHouseMenu();
            var dinerMenu = new DinerMenu();

            var alice = new Waitress(new List<IMenu> {
                pancakeHouseMenu,
                dinerMenu,
            });

            alice.PrintAllMenu();
        }
    }
}