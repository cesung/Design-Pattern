namespace TemplateMethod
{
    public class Tea : CaffineBeverage
    {
        public override void Brew()
        {
            Console.WriteLine("Steeping the Tea Bag");
        }

        public override void AddCodiments()
        {
            Console.WriteLine("Adding Lemon");
        }

        public override bool CheckCustomerWantsCodiments()
        {
            Console.WriteLine("Lemon[Y/y]");
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