namespace Command
{
    public class CeilingFanOffCommand : ICommand
    {
        ICeilingFan cellingFan;
        Speed prevSpeed;

        public CeilingFanOffCommand(ICeilingFan cellingFan)
        {
            this.cellingFan = cellingFan;
        }

        public void Execute()
        {
            prevSpeed = cellingFan.GetSpeed();
            cellingFan.Off();
        }

        public void Undo()
        {
            // cellingFan.On();
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
            return $"{cellingFan.Name}OffCommand";
        }
    }

}