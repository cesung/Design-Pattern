# Design Pattern - Ch3: The Decorator Pattern

---

## The Decorator Pattern

> **_The Observer Pattern: attaches additional responsibilities to an object dynamically. Decorators provides a flexible alternative to subclassing for extending functionality_**

## Note

:notebook_with_decorative_cover: [Design Pattern - Ch3: The Decorator Pattern]()

## Pattern Design

### **Original Design**

Starbuzz coffee design their classes as follow
**_base class_**

```csharp
// An abstract class, subclassed by all beverages offered in the coffee shop
public abstract class Beverage
{
    private string description;

    public string GetDescription();

    // `Cost()` is an abstract method, each subclass need to define its own implementation
    public abstract float Cost();
}
```

**_subclasses_**

```csharp
public class DarkRoast : Beverage
{
    // Each subclass implement `Cost()` to return the cose of the beverage
    public override float Cost();
}
```

```csharp
public class Decaf : Beverage
{
    // Each subclass implement `Cost()` to return the cose of the beverage
    public override float Cost();
}
```

```csharp
public class Espresson : Beverage
{
    // Each subclass implement `Cost()` to return the cose of the beverage
    public override float Cost();
}
```

What are the problems? In addition to different types of coffee, customers can also ask for serveral condiments. Such as milk, soy, mocha, …, which produce the “CLASS EXPLOSION”
**_base class_**

```csharp
// An abstract class, subclassed by all beverages offered in the coffee shop
public abstract class Beverage
{
    private string description;

    public string GetDescription();

    // `Cost()` is an abstract method, each subclass need to define its own implementation
    public abstract float Cost();
}
```

**_subclasses_**

```csharp
public class DarkRoast : Beverage
{
    // Each subclass implement `Cost()` to return the cose of the beverage
    public override float Cost();
}
```

```csharp
public class DarkRoastWithMilk : Beverage
{
    // Each subclass implement `Cost()` to return the cose of the beverage
    public override float Cost();
}
```

```csharp
public class DarkRoastWithSoy : Beverage
{
    // Each subclass implement `Cost()` to return the cose of the beverage
    public override float Cost();
}
```

```csharp
public class DarkRoastWithMilkAndWithSoy : Beverage
{
    // Each subclass implement `Cost()` to return the cose of the beverage
    public override float Cost();
}
```

_( …other codiments that are mix with DarkRoast)_

```csharp
public class Decaf : Beverage
{
    // Each subclass implement `Cost()` to return the cose of the beverage
    public override float Cost();
}
```

```csharp
public class DecafWithMilk : Beverage
{
    // Each subclass implement `Cost()` to return the cose of the beverage
    public override float Cost();
}
```

_( …And so on)_

### **Fake Solution: Keep track of the condiments in the base class**

**_base class_**

```csharp
// An abstract class, subclassed by all beverages offered in the coffee shop
public abstract class Beverage
{
    private string description;

    // boolean variables to keep track of the codiments
    private bool hasMilk;
    private bool hasSoy;
    private bool hasMocha;
    private bool hasWhip;

    // getter and setter for the boolean variables
    public void GetMilk()
    {
        return hasMilk;
    }
    public void SetMilk(bool hasMilk)
    {
        this.hasMilk = hasMilk;
    }
    public void GetSoy() { ... }
    public void SetSoy() { ... }
    public void GetMocha() { ... }
    public void SetMocha() { ... }
    public void GetWhip() { ... }
    public void SetWhip() { ... }

    public string GetDescription();

    // Implement `Cost()` in base class, so that to  calculate the costs associated with codiments
    // for a particular beverage instance.
    // Subclasses will override `Cost()` but they will also invoke base class `Cost()` so that they
    // can calculate the the total cost of of the basic beverage plus the cost of the added codiments
    public virtual float Cost()
    {
        double condimentCost
        if (hasMilk)
        {
            condimentCost += milkCost;
        }
        if (has...) {...}
        ...
    }
}
```

**_subclasses_**

```csharp
public class DarkRoast : Beverage
{
    // Each subclass implement `Cost()` to return the cose of the beverage
    public override float Cost()
    {
        // cost for DarkRoast + cost for all condiments
        // `base` is a reserved word for C#
        return 1.99 + base.Cost();
    }
}
```

```csharp
public class Decaf : Beverage
{
    // Each subclass implement `Cost()` to return the cose of the beverage
    public override float Cost() { ... }
}
```

```csharp
public class Espresso : Beverage
{
    // Each subclass implement `Cost()` to return the cose of the beverage
    public override float Cost() { ... }
}
```

It seems that there is no “CLASS EXPLOTION” issue anymore. However, what if

-   Customer want to add two cup of milk? → `bool` to `int` ? How about 2.5 cup, now to `float`?
-   Price change for the codiments → force us to alter the exisiting code
-   New codiments introduce, which forace us to alter the `Cost()` method of the base class

> **_Design Principle #5: Classes should be opened for extension but closed for modification_**

### **Real Solution: Constructing a drink with Decorators**

![Imgur](https://i.imgur.com/v8Gi5kd.png)

-   Start with the DarkRoast object
-   Customer wants Mocha, create a Mocha object and wrap it around with DarkRoast
-   Customer aslo wants Whip, create a Whip object and wrap it around the Mocha

To compute the cost for the customer, calling `cost()` method recursively from the outermost decorator, that is, Whip, Mocha and finally the DarkRoast.

![Imgur](https://i.imgur.com/s0ED654.png)

**NOTE:** Decorator has the same type as the objects (could be another decorator or base component) they decorate.
Here is what the whole structure looks like

![Imgur](https://i.imgur.com/X8meJfV.png)

Why `CodimentDecorator` class inherit from `Beverage` class? → Make the descorators **have the same type** as the objects they are going to decorate **⇒ In other words, we are subclassing (using **inheritance**) **the abstract class `Beverage` in order to have the correct type (**_type matching_**)

### **Introduce Size to the StarBuzz Menu**

Customer can now order coffee in size of TALL, GRANDE, or VENTI. Make the condiments to be charged according to size.

![Imgur](https://i.imgur.com/1kWvJl8.png)

**Base component**

```csharp
// abstract class for base component, Beverage
namespace Decorator
{
    public abstract class Beverage
    {
        public enum Size { TALL, GRANDE, VENTI };

        public Size size;
        public string description = "";

        public abstract Size GetSize();

        public abstract string GetDescription();

        public abstract double Cost();
    }
}
```

```csharp
// concrete class for base component, DarkRoast
namespace Decorator
{
    public class DarkRost : Beverage
    {
        public DarkRost(Size size)
        {
            description = $"{size} DarkRost";
            this.size = size;
        }

        public override Size GetSize()
        {
            return size;
        }

        public override string GetDescription()
        {
            return description;
        }

        public override double Cost()
        {
            return 2.00;
        }
    }
}

```

```csharp
// concrete class for base component, DarkRoast
namespace Decorator
{
    public class Decaf : Beverage
    {
        public Decaf(Size size)
        {
            description = $"{size} Decaf";
            this.size = size;
        }

        public override Size GetSize()
        {
            return size;
        }

        public override string GetDescription()
        {
            return description;
        }

        public override double Cost()
        {
            return 1.05;
        }
    }
}
```

**Decorators**

```csharp
// abstract class for decorator, CondimentDecorator
namespace Decorator
{
    public abstract class CondimentDecorator : Beverage
    {
        public Beverage? beverage;
    }
}
```

```csharp
// concrete class for decorator, Whip
namespace Decorator
{
    public class Whip : CondimentDecorator
    {
        public Whip(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override Size GetSize()
        {
            return beverage?.GetSize() ?? Size.TALL;
        }

        public override string GetDescription()
        {
            return $"{beverage?.GetDescription() ?? ""}, Whip";
        }

        public override double Cost()
        {
            double cost = beverage?.Cost() ?? 0.0;

            switch (beverage?.GetSize())
            {
                case Size.TALL:
                    cost += 0.10;
                    break;

                case Size.GRANDE:
                    cost += 0.30;
                    break;

                case Size.VENTI:
                    cost += 0.40;
                    break;

                default:
                    break;
            }
            return cost;
        }
    }
}
```

```csharp
// concrete class for decorator, Whip
namespace Decorator
{
    public class Milk : CondimentDecorator
    {
        public Milk(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override Size GetSize()
        {
            return beverage?.GetSize() ?? Size.TALL;
        }

        public override string GetDescription()
        {
            return $"{beverage?.GetDescription() ?? ""}, Milk";
        }

        public override double Cost()
        {
            double cost = beverage?.Cost() ?? 0.0;

            switch (beverage?.GetSize())
            {
                case Size.TALL:
                    cost += 0.10;
                    break;

                case Size.GRANDE:
                    cost += 0.15;
                    break;

                case Size.VENTI:
                    cost += 0.20;
                    break;

                default:
                    break;
            }

            return cost;
        }
    }
}
```

**Main function**

```csharp
// Program.cs, Main
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
```

## The Big Picture

![Imgur](https://i.imgur.com/1kWvJl8.png)
