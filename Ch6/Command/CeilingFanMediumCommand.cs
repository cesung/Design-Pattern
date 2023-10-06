namespace Command
{
    public class CeilingFanMediumCommand : ICommand
    {
        ICeilingFan cellingFan;
        Speed prevSpeed;

        public CeilingFanMediumCommand(ICeilingFan cellingFan)
        {
            this.cellingFan = cellingFan;
        }

        public void Execute()
        {
            cellingFan.Medium();
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
            return $"{cellingFan.Name}MediumCommand";
        }
    }

}