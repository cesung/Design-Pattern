
namespace State
{
    public class HasQuarterState : IState
    {
        private GumballMachine m_gumballMachine;
        private Random m_random = new Random();

        public HasQuarterState(GumballMachine gumballMachine)
        {
            m_gumballMachine = gumballMachine;
        }

        public void InsertQuarter()
        {
            Console.WriteLine("You can't insert another quarter");
        }

        public void EjectQuarter()
        {
            Console.WriteLine("Quarter returned!");
            m_gumballMachine.SetState(m_gumballMachine.GetNoQuarterState());
        }

        public void TurnCrank()
        {
            Console.WriteLine("You turned...");
            // random positive integer within range [0, 10)
            var r = m_random.Next(10);
            if (r == 0)
            {
                m_gumballMachine.SetState(m_gumballMachine.GetWinnerState());
            }
            else
            {
                m_gumballMachine.SetState(m_gumballMachine.GetSoldState());
            }

        }

        public void Dispense()
        {
            Console.WriteLine("No gumball dispended");
        }

        public void Refill() { }
    }
}