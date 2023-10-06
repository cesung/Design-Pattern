namespace Command
{
    public class LightOnCommand : ICommand
    {
        ILight light;

        public LightOnCommand(ILight light)
        {
            this.light = light;
        }

        public void Execute()
        {
            light.On();
        }

        public void Undo()
        {
            light.Off();
        }

        public override string ToString()
        {
            return $"{light.Name}OnCommand";
        }

    }
}