namespace Visitor
{
    public abstract class Client
    {
        public string Name {get; set;}
        public string Address {get; set;}
        public string PhoneNumber {get; set;}

        // public abstract void SendMail();

        public abstract void SendMail(IInsuranceMailingVisitor visitor);
    }
}