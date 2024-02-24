namespace Flyweight
{
    // public class Book
    // {
    //     public string Name { get; set; }

    //     public double Price { get; set; }

    //     public string Type { get; set; }

    //     public string Distributor { get; set; }

    //     // Assume that there are only two kinds of "Type": Action and Fantasy
    //     // With Action type of Book, the distributor always comes from "A" distributor, and
    //     // With Fantasy type of Book, the distributor always come from "B" distributor
    //     public Book(string name, double price, string type, string distributor)
    //     {
    //         Name = name;
    //         Price = price;
    //         Type = type;
    //         Distributor = distributor;
    //     }
    // }

    public class Book
    {
        public string Name { get; set; }

        public double Price { get; set; }

        public BookType Type { get; set; }

        public Book(string name, double price, BookType type)
        {
            Name = name;
            Price = price;
            Type = type;
        }
    }
}