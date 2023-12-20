namespace ChainOfResponsibility
{
    public class Manager : Approver
    {

        private const int c_managerLimits = 10000;

        public Approver? Next { get; set; }

        public void SetNext(Approver next)
        {
            Next = next;
        }

        public void Process(Purchase purchase)
        {
            if (purchase.GetPurchaseTotal() < c_managerLimits)
            {
                Console.WriteLine($"Manager approved the purchase request id {purchase.PurchaseId}");
            }
            else
            {
                Console.WriteLine($"Manager forward the purchase request to his/her manager");
                Next?.Process(purchase);
            }
        }
    }
}