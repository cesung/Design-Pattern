
namespace State
{
    public class SoldState : IState
    {
        private GumballMachine m_gumballMachine;

        public SoldState(GumballMachine gumballMachine)
        {
            m_gumballMachine = gumballMachine;
        }

        public void InsertQuarter()
        {
            // inappropriate action
            Console.WriteLine("Please wait, we're already giving you a gumball");
        }

        public void EjectQuarter()
        {
            // inappropriate action
            Console.WriteLine("Sorry, you already turned the crank!");
        }

        public void TurnCrank()
        {
            // inappropriate action
            Console.WriteLine("Turning crank twice won't give you another gumball");
        }

        public void Dispense()
        {
            // We are in the sold state, which means customer already paid. Thus, we are going to
            // ask the machine to realease the gumball
            m_gumballMachine.ReleaseBall();

            // if still having gumball left in the gumball machine
            if (m_gumballMachine.GetCount() > 0)
            {
                // transit to NO_QUARTER state and waiting quarter from next customer
                m_gumballMachine.SetState(m_gumballMachine.GetNoQuarterState());
            }
            else
            {
                Console.WriteLine("Oops, gumball machine is out of gumballs");
                // number of gumballs in gumball machine == 0
                m_gumballMachine.SetState(m_gumballMachine.GetOutOfGumballsState());
            }
        }

        public void Refill() { }
    }
}