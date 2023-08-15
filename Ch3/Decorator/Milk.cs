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