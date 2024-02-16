namespace Prototype
{
    public class Program
    {
        public static void Main()
        {
            Person p1 = new Person(
                28,
                "Ikari Sung",
                Convert.ToDateTime("1995-08-28"),
                new IdInfo(123456789));

            Person p2 = p1.ShallowClone();
            Person p3 = p2.DeepClone();

            Console.WriteLine("============ Before Modification ============");
            Console.WriteLine(p2);
            Console.WriteLine(p3);

            p1.Age = 32;
            p1.FullName = "Cynthia Yang";
            p1.Birthday = Convert.ToDateTime("1992-09-14");
            p1.IdInfo.IdNumber = 987654321;

            Console.WriteLine("============ After Modification ============");
            Console.WriteLine(p2);
            Console.WriteLine(p3);
        }
    }
}