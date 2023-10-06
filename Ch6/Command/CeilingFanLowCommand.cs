namespace Command
{
    public class CeilingFanLowCommand : ICommand
    {
        ICeilingFan cellingFan;
        Speed prevSpeed;

        public CeilingFanLowCommand(ICeilingFan cellingFan)
        {
            this.cellingFan = cellingFan;
        }

        public void Execute()
        {
            cellingFan.Low();
            prevSpeed = cellingFan.GetSpeed();
        }

        public void Undo()
        {
            // cellingFan.Off();
            switch (prevSpeed)
            {
                case Speed.HIGH:
                    cellingFan.High();
                    break;
                case Speed.MEDIUM:
                    cellingFan.Medium();
                    break;
                case Speed.LOW:
                    cellingFan.Low();
                    break;
                case Speed.OFF:
                    cellingFan.Off();
                    break;
            }
        }

        public override string ToString()
        {
            return $"{cellingFan.Name}LowCommand";
        }
    }

}