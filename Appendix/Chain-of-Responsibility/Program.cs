namespace ChainOfResponsibility
{
    public class Program
    {
        public static void Main()
        {
            // Report chain: Manager -> Director -> VP
            Manager manager = new Manager();
            Director director = new Director();
            VP vp = new VP();

            manager.SetNext(director);
            director.SetNext(vp);

            Purchase purchase1 = new Purchase(
                1,
                100,
                50
            );
            Console.WriteLine(purchase1);
            manager.Process(purchase1);

            Purchase purchase2 = new Purchase(
                2,
                400,
                100
            );
            Console.WriteLine(purchase2);
            manager.Process(purchase2);

            Purchase purchase3 = new Purchase(
                3,
                1000,
                600
            );
            Console.WriteLine(purchase3);
            manager.Process(purchase3);
        }
    }
}