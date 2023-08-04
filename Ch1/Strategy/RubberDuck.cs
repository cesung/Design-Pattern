public class RubberDuck : Duck
{
    public RubberDuck()
    {
        Console.WriteLine("-- RubberDuck -- ");

        flyBehavior = new FlyNoWay();
        quackBehavior = new Squeak();
    }

    public override void display()
    {
        Console.WriteLine("Looks like a rubber duck");
    }

}