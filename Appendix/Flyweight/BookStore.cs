using System.Text;

namespace Flyweight
{
    public class BookStore
    {
        public List<Book> Books = new();

        public BookTypeFactory BookTypeFactory { get; set; } = new BookTypeFactory();

        public void StockBook(string name, double price, string type, string distributor)
        {
            BookType bookType = BookTypeFactory.GetOrCreateBookType(type, distributor);

            Books.Add(new Book(name, price, bookType));
        }

        public override string ToString()
        {
            var stringBuilder = new StringBuilder();

            foreach (var book in Books)
            {
                stringBuilder.AppendLine($"{book.Name} ({book.Price}) - {book.Type.Type}, {book.Type.Distributor}");
            }

            var ret = stringBuilder.ToString();
            stringBuilder.Remove(0, stringBuilder.Length);

            return ret;
        }
    }
}