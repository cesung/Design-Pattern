# Design Pattern - Ch1: The Strategy Pattern

---

## The Strategy Pattern

> _**The Strategy Pattern: defines a family of algorithms, encapsulates each one, and make them interchangeable. Strategy lets the algorithm vary independently from clients that use it**_

## Note

:notebook_with_decorative_cover: [Design Pattern - Ch1: Intro to design pattern](https://zealous-open-f6a.notion.site/Design-Pattern-Ch1-Intro-to-design-pattern-a9b75e24233f4b59b7107406f7f9f098)

### Original Design

All ducks can display, and notice: `display()` in Duck class is abstract, means that every sub-classes can implement its own way to display.

```csharp
public class Duck
{
    private abstract void Display() {}
}
```

```csharp
public class MallarDuck : Duck
{
    private void Display()
    {
        // looks like a mallard
    }
}
```

```csharp
public class RedheadDuck : Duck
{
    private void Display()
    {
        // looks like a redhead
    }
}
```

### New Requirement Comes In: Duck fly

Need to add a `fly()` functionality to _some_ duck classes

```csharp
public class Duck
{
    private abstract void Display() {}
    private void Fly() { ... }
}
```

Still Looks good for classes `MallarDuck` and `RedheadDuck`

```csharp
public class MallarDuck : Duck
{
    private void Display()
    {
        // looks like a mallard
    }
}
```

```csharp
public class RedheadDuck : Duck
{
    private void Display()
    {
        // looks like a redhead
    }
}
```

Howevere, `RubberDuck` should not fly. Since we inherit from the `Duck` class, even `RubberDuck` now can fly.

```csharp
public class RubberDuck : Duck
{
    private void Display()
    {
        // looks like a RubberDuck
    }
}
```

### Fake Solution1: Override fly

```csharp
public abstract class Duck
{
    private abstract void display {}
    private abstract void fly { ... } // virtual allows sub-classes able to override
}
```

Override `fly()`

```csharp
public class RubberDuck : Duck
{
    private override void Display()
    {
        // looks like a RubberDuck
    }
    private override void Fly()
    {
        // do nothing
    }
}
```

**⇒ But then what happens when we add `WoodenDuck` to the program? We know that wooden ducks aren’t suppose to fly.**

### Fake Solution2: Flyable Interface

```csharp
public class Duck
{
    private abstract void Display() {}
    // private void fly { ... }
}
```

Only those ducks can fly can implement the flyable interface

```csharp
interface IFlyable
{
    void Fly();
}
```

Since `MallarDuck` should be able to fly. Let it implement the `IFlyable` interface

```csharp
public class MallarDuck : Duck, IFlyable
{
    private void Display()
    {
        // looks like a mallard
    }

    // MallarDuck can fly
    private void Fly() { ... }
}
```

On the other hands, since RubberDuck should not be able to fly, we do not implement the `IFlyable` interface

```csharp
public class RubberDuck : Duck
{
    private void Display
    {
        // looks like a RubberDuck
    }
}
```

⇒ Now all implementation going to the sub-classes (suppose there are `n` sub-classes), which brings up following problems

1. **There are LOTS (almost `n`) of duplicate code**
2. **What if we need to make a little change to the fly behavior? → in all `n` of the flying Duck sub-classes?**

### Real Solution: Creating a FlyBehavior interface and a set of classes for flying behavior

> _Take the parts that vary and encapsulate them, so that later you can alter or extend the parts that vary without affecting those that don’t_

> _Program to an interface not an implementation_

A fly behavior interface

```csharp
interface FlyBehavior
{
    void Fly();
}
```

A Set of fly behavior classes

```csharp
public class FlyWithWings : FlyBehavior
{
    public void Fly
    {
        // implements duck flying
    }
}
```

```csharp
public class FlyNoWay : FlyBehavior
{
    public void Fly
    {
        // do nothing
    }
}
```

With this kind of implementation, we can change the behavior of a duck dynamically ⇒ we can include a behavior setter method in the `Duck` class, so that we can dynamically change the `MallardDuck`'s flying behavior at run time

### New Design

**From above we have a interface and a set of behavior classes**

A fly behavior Interface

```csharp
interface FlyBehavior
{
    void Fly();
}
```

A set of fly behavior classes

```csharp
public class FlyWithWings : FlyBehavior
{
    public void Fly
    {
        // implements duck flying
    }
}
```

```csharp
public class FlyNoWay : FlyBehavior
{
    public void Fly
    {
        // do nothing
    }
}
```

**Now the new base & sub-classes**

New base class

```csharp
public class Duck
{
    // flyBehavior declared as the behavior interface class
    // flyBehavior will hold a reference to a specific behavior at runtime
    FlyBehavior flyBehavior;

    // public void fly();
    public void PerformFly()
    {
        flyBehavior.fly();
    }
}
```

New sub-class (take `MallarDuck` as example)

```csharp
public class MallardDuck : Duck
{
    public MallardDuck
    {
        // MallardDuck inherit the flyBehavior from Duck class
        flyBehavior = new FlyWithWings();
    }

    private void Display()
    {
        // looks like a mallard
    }
}
```

## The Big Picture

![Strategy Pattern](https://i.imgur.com/vx8SrHV.png)
