namespace Command
{
    public interface ICeilingFan
    {
        string Name { get; set; }
        // void On();
        void High();
        void Medium();
        void Low();
        void Off();
        Speed GetSpeed();
    }

}