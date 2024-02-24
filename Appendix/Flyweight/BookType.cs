namespace Flyweight
{
    public class BookType
    {
        public string Type { get; set; }

        public string Distributor { get; set; }

        public BookType(string type, string distributor)
        {
            Type = type;
            Distributor = distributor;
        }
    }

}