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