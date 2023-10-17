namespace TemplateMethod
{
    public class Coffee : CaffineBeverage
    {
        public override void Brew()
        {
            Console.WriteLine("Dripping Coffee through Filter");
        }

        public override void AddCodiments()
        {
            Console.WriteLine("Adding Sugar and Milk");
        }

        public override bool CheckCustomerWantsCodiments()
        {
            Console.WriteLine("Milk and sugar?[Y/y]");
            var answer = Convert.ToString(Console.ReadLine());

            if (string.Equals(answer ?? "no", "y"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}