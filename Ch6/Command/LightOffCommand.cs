using System.Diagnostics.Contracts;

namespace Command
{
    public class LightOffCommand : ICommand
    {
        ILight light;

        public LightOffCommand(ILight light)
        {
            this.light = light;
        }

        public void Execute()
        {
            light.Off();
        }

        public void Undo()
        {
            light.On();
        }

        public override string ToString()
        {
            return $"{light.Name}OffCommand";
        }

    }
}