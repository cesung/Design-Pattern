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