namespace ChainOfResponsibility
{
    public interface Approver
    {
        public void SetNext(Approver next);

        public void Process(Purchase purchase);
    }
}