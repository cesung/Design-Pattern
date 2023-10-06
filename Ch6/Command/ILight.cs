namespace Command
{
    public interface ILight
    {
        string Name { get; set; }
        void On();
        void Off();
    }
}