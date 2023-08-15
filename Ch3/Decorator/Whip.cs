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