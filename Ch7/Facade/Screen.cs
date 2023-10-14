namespace Facade
{
    public class Screen
    {
        public string Description { get; set; }

        public Screen(string description)
        {
            Description = description;
        }

        public void Up()
        {
            Console.WriteLine($"{Description} Going Up");
        }

        public void Down()
        {
            Console.WriteLine($"{Description} Going Down");
        }

        public override string ToString()
        {
            return Description;
        }

    }
}