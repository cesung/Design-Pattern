namespace ChainOfResponsibility
{
    public class VP : Approver
    {
        private const int c_VPLimits = 100000;

        public Approver? Next { get; set; }

        public void SetNext(Approver next)
        {
            Next = next;
        }

        public void Process(Purchase purchase)
        {
            if (purchase.GetPurchaseTotal() < c_VPLimits)
            {
                Console.WriteLine($"VP approved the purchase id {purchase.PurchaseId}");
            }
            else
            {
                Console.WriteLine($"purchase id {purchase.PurchaseId} need executative meeting!");
            }
        }
    }
}