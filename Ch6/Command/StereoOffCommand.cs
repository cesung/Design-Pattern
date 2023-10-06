namespace Command
{
    public class StereoOffCommand : ICommand
    {
        IStereo stereo;

        public StereoOffCommand(IStereo stereo)
        {
            this.stereo = stereo;
        }

        public void Execute()
        {
            stereo.Off();
        }

        public void Undo()
        {
            stereo.On();
            // Channel?
            // Volumn?
        }

        public override string ToString()
        {
            return $"{stereo.Name}OffCommand";
        }
    }
}