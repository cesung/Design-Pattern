namespace ChainOfResponsibility
{
    public class Director : Approver
    {

        private const int c_directorLimits = 50000;

        public Approver? Next { get; set; }

        public void SetNext(Approver next)
        {
            Next = next;
        }

        public void Process(Purchase purchase)
        {
            if (purchase.GetPurchaseTotal() < c_directorLimits)
            {
                Console.WriteLine($"Director approved the purchase request id {purchase.PurchaseId}");
            }
            else
            {
                Console.WriteLine($"Director forward the purchase request to his/her manager");
                Next?.Process(purchase);
            }
        }
    }
}