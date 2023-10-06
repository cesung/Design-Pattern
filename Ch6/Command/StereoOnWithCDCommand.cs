namespace Command
{
    public class StereoOnWithCDCommand : ICommand
    {
        IStereo stereo;

        public StereoOnWithCDCommand(IStereo stereo)
        {
            this.stereo = stereo;
        }

        public void Execute()
        {
            stereo.On();
            stereo.SetCd();
            stereo.SetVolumn(11);
        }

        public void Undo()
        {
            stereo.Off();
        }

        public override string ToString()
        {
            return $"{stereo.Name}OnWithCDCommand";
        }
    }

}