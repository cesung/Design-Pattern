using System.Text;

namespace Prototype
{
    public class Person : PersonPrototype
    {
        public int Age { get; set; }

        public string FullName { get; set; }

        public DateTime Birthday { get; set; }

        public IdInfo IdInfo { get; set; }

        public Person(int age, string fullName, DateTime birthday, IdInfo idInfo)
        {
            ArgumentNullException.ThrowIfNull(age);
            ArgumentNullException.ThrowIfNull(fullName);
            ArgumentNullException.ThrowIfNull(birthday);
            ArgumentNullException.ThrowIfNull(idInfo);

            Age = age;
            FullName = fullName;
            Birthday = birthday;
            IdInfo = idInfo;
        }

        public Person ShallowClone()
        {
            return (Person)this.MemberwiseClone();
        }

        public Person DeepClone()
        {
            var clone = (Person)this.MemberwiseClone();
            clone.IdInfo = new IdInfo(IdInfo.IdNumber);
            // Even though string is Reference Type variable, string is immutable
            // If we change a string value, then the compiler creates a new string object in the memory
            // and point a variable to the new memory location.
            clone.FullName = FullName;

            return clone;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Age: {Age} ({(Age > 20 ? "Adult" : "Adolescent")})");
            sb.AppendLine($"Fullname: {FullName}");
            sb.AppendLine($"Birthday: {Birthday.ToString()}");
            sb.AppendLine($"ID#: {IdInfo.IdNumber.ToString()}");

            var retString = sb.ToString();
            sb.Remove(0, sb.Length);

            return retString;
        }
    }

}