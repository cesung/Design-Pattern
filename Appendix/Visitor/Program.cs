namespace Visitor
{
    public class Program
    {
        public static void Main()
        {
            Individual Ikari = new Individual(
                "Ikari",
                "1234 Winner Road, APT 222, CA, 94086, USA",
                "+1 (533) 955-1115",
                0
            );

            Bank BOA = new Bank(
                "Bank of Apple",
                "5678 Loser Road, APT 111, CA, 94111, USA",
                "+1 (333) 444-5555",
                100
            );

            var clients = new List<Client>();
            clients.Add(Ikari);
            clients.Add(BOA);

            // clients.ForEach(c => c.SendMail());

            var insuranceMailingVisitor = new InsuranceMailingVisitor();

            // Send mails to all the clients
            insuranceMailingVisitor.SendAllMails(clients);

            // Send mail (theft insurance) to client BOA only
            insuranceMailingVisitor.SendMailByClient(BOA);

        }
    }
}