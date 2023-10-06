namespace Command
{
    public interface IDoor
    {
        string Name { get; set; }
        void Up();
        void Down();
        void Stop();
    }
}