using System.Diagnostics;

namespace Composite
{
    public abstract class MenuComponent
    {
        // Composite method: Add
        public virtual void Add(MenuComponent menuComponent)
        {
            throw new NotSupportedException();
        }

        // Composite method: Remove
        public virtual void Remove(MenuComponent menuComponent)
        {
            throw new NotSupportedException();
        }

        // Composite method: Get MenuComponents
        public virtual MenuComponent GetChild(int i)
        {
            throw new NotSupportedException();
        }

        // Operation Method
        public virtual string GetName()
        {
            throw new NotSupportedException();
        }

        // Operation Method
        public virtual string GetDescription()
        {
            throw new NotSupportedException();
        }

        // Operation Method
        public virtual double GetPrice()
        {
            throw new NotSupportedException();
        }

        // Operation Method
        public virtual bool IsVegetarian()
        {
            throw new NotSupportedException();
        }

        // Operation Method
        public virtual void Print()
        {
            throw new NotSupportedException();
        }
    }
}