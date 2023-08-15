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