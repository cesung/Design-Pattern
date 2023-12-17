namespace Visitor
{
    public class InsuranceMailingVisitor : IInsuranceMailingVisitor
    {

        public void SendAllMails(List<Client> clients)
        {
            foreach (var client in clients)
            {
                client.SendMail(this);
            }
        }

        public void SendMailByClient(Client client)
        {
            client.SendMail(this);
        }

        public void SendMail(Bank bank)
        {
            Console.WriteLine("Send theft insurance mail");
        }

        public void SendMail(Individual individual)
        {
            Console.WriteLine("Send medical insurance mail");
        }
    }
}