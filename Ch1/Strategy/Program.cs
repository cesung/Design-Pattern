class Program
{
    static public void Main()
    {
        Duck mallard = new MallardDuck();
        mallard.display();
        mallard.swim();
        mallard.performFly();
        mallard.perfromQuack();

        Duck rubberDuck = new RubberDuck();
        rubberDuck.display();
        rubberDuck.swim();
        rubberDuck.performFly();
        rubberDuck.perfromQuack();

        Duck anotherRubberDuck = new RubberDuck();

        anotherRubberDuck.display();
        anotherRubberDuck.swim();
        anotherRubberDuck.performFly();
        Console.WriteLine("!!LETS MAKE THE OTHER RUBBERDUCK FLY!!");
        // setting behavior dynamically 
        anotherRubberDuck.setFlyBehavior(new FlyWithWings());
        anotherRubberDuck.performFly();
        anotherRubberDuck.perfromQuack();
    }
}
