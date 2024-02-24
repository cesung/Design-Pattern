using System.Text;

namespace Flyweight
{
    public class Program
    {
        public const double c_randDoubleLowerBound = 10.0;
        public const double c_randDoubleUpperBound = 500.0;
        public const int c_numBooks = 10;

        public static void Main()
        {
            var bookStore = new BookStore();
            var rand = new Random();

            for (var i = 0; i < c_numBooks; i++)
            {
                var r = rand.Next(0, 2);
                bookStore.StockBook(
                    GetRandomBookName(),
                    GetRandomPrice(),
                    r % 2 == 0 ? "Action" : "Fantasy",
                    r % 2 == 0 ? "A" : "B"
                );
            }

            Console.Write(bookStore);
        }

        public static string GetRandomBookName()
        {
            var rand = new Random();
            var bookNameLength = rand.Next(4, 10);
            var stringBuilder = new StringBuilder();

            for (var i = 0; i < bookNameLength; i++)
            {
                var randLetter = Convert.ToChar(rand.Next(0, 26) + 65);
                stringBuilder.Append(randLetter);
            }

            var bookName = stringBuilder.ToString();
            stringBuilder.Remove(0, stringBuilder.Length);

            return bookName;
        }

        public static double GetRandomPrice()
        {
            var rand = new Random();
            return rand.NextDouble() * (c_randDoubleUpperBound - c_randDoubleLowerBound) + c_randDoubleLowerBound;
        }
    }
}