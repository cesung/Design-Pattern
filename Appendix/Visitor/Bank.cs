namespace Visitor
{
    public class Bank : Client
    {
        public int BranchesInsured {get; set;}

        public Bank(
            string name,
            string address,
            string phoneNumber,
            int branchesInsured)
        {
            Name = name;
            Address = address;
            PhoneNumber = phoneNumber;
            BranchesInsured = branchesInsured;
        }

        // public override void SendMail()
        // {
        //     Console.WriteLine("Send theft insurance mail");
        // }

        public override void SendMail(IInsuranceMailingVisitor visitor)
        {
            visitor.SendMail(this);
        } 
    }
}