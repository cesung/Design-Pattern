public class MallardDuck : Duck
{
    public MallardDuck()
    {
        Console.WriteLine("-- MallardDuck -- ");
        flyBehavior = new FlyWithWings();
        quackBehavior = new Quack();
    }

    public override void display()
    {
        Console.WriteLine("Looks like a mallard duck");
    }
}