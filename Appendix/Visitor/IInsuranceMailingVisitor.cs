namespace Visitor
{
    public interface IInsuranceMailingVisitor
    {
        public void SendMail(Bank bank);
        public void SendMail(Individual individual);
    }
}