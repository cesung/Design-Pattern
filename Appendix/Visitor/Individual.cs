namespace Visitor
{
    public class Individual : Client
    {
        public int InsuranceLevel {get; set;}

        public Individual(
            string name,
            string address,
            string phoneNumber,
            int insuranceLevel)
        {
            Name = name;
            Address = address;
            PhoneNumber = phoneNumber;
            InsuranceLevel = insuranceLevel;
        }

        // public override void SendMail()
        // {
        //     Console.WriteLine("Send medical insurance mail");
        // }

        public override void SendMail(IInsuranceMailingVisitor visitor)
        {
            visitor.SendMail(this);
        }
    }
}