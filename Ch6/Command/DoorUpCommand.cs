namespace Command
{
    public class DoorUpCommand : ICommand
    {
        IDoor door;

        public DoorUpCommand(IDoor door)
        {
            this.door = door;
        }

        public void Execute()
        {
            door.Up();
        }

        public void Undo()
        {
            door.Down();
        }

        public override string ToString()
        {
            return $"{door.Name}UpCommand";
        }
    }

}