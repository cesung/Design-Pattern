using System;
using System.Text;

namespace ChainOfResponsibility
{
    public class Purchase
    {
        public int PurchaseId { get; set; }
        public int Amount { get; set; }
        public int Price { get; set; }

        public Purchase(int purchaseId, int amount, int price)
        {
            PurchaseId = purchaseId;
            Amount = amount;
            Price = price;
        }

        public int GetPurchaseTotal()
        {
            return Amount * Price;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"\nPurchase ID: {PurchaseId}, Amount: {Amount}, Price: {Price}");

            return sb.ToString();
        }
    }
}