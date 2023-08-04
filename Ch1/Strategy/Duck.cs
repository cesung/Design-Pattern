public abstract class Duck
{
    public IFlyBehavior? flyBehavior;
    public IQuackBehavior? quackBehavior;

    public void performFly()
    {
        flyBehavior?.fly();
    }

    public void setFlyBehavior(IFlyBehavior flyBehavior)
    {
        this.flyBehavior = flyBehavior;
    }

    public void perfromQuack()
    {
        quackBehavior?.quack();
    }

    public void setQuackBehavior(IQuackBehavior quackBehavior)
    {
        this.quackBehavior = quackBehavior;
    }

    public void swim()
    {
        // All ducks can swim, even for a rubber duck
        Console.WriteLine("I am swimming");
    }

    public abstract void display();
}