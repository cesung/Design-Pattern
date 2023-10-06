namespace Command
{
    public class DoorDownCommand : ICommand
    {
        IDoor door;

        public DoorDownCommand(IDoor door)
        {
            this.door = door;
        }

        public void Execute()
        {
            door.Down();
        }

        public void Undo()
        {
            door.Up();
        }

        public override string ToString()
        {
            return $"{door.Name}DownCommand";
        }
    }

}