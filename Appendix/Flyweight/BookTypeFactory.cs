namespace Flyweight
{
    public class BookTypeFactory
    {
        public static Dictionary<string, BookType> BookTypeDict { get; set; } = new();

        public static BookType GetOrCreateBookType(string type, string distributor)
        {
            if (BookTypeDict.TryGetValue(type, out var bookType) == false)
            {
                BookTypeDict.Add(type, new BookType(type, distributor));
                bookType = BookTypeDict[type];
            }

            return bookType;
        }
    }
}