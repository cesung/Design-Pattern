namespace TemplateMethod
{
    public class Program
    {
        public static void Main()
        {
            var tea = new Tea();
            var coffee = new Coffee();

            Console.WriteLine("Making tea...");
            tea.PrepareRecipe();

            Console.WriteLine("Making coffee...");
            coffee.PrepareRecipe();
        }
    }
}