namespace Adapter
{
    public class MallardDuck : IDuck
    {
        public void Fly()
        {
            Console.WriteLine("I'm fly");
        }

        public void Quack()
        {
            Console.WriteLine("Quack");
        }
    }
}