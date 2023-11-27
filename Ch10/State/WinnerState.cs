namespace State
{
    public class WinnerState : IState
    {
        private GumballMachine m_gumballMachine;

        public WinnerState(GumballMachine gumballMachine)
        {
            m_gumballMachine = gumballMachine;
        }


        // just like SoldState
        public void InsertQuarter()
        {
            // inappropriate action
            Console.WriteLine("Please wait, we're already giving you a gumball");
        }

        // just like SoldState
        public void EjectQuarter()
        {
            // inappropriate action
            Console.WriteLine("Sorry, you already turned the crank!");
        }

        // just like SoldState
        public void TurnCrank()
        {
            // inappropriate action
            Console.WriteLine("Turning crank twice won't give you another gumball");
        }

        public void Dispense()
        {
            m_gumballMachine.ReleaseBall();
            if (m_gumballMachine.GetCount() == 0)
            {
                Console.WriteLine("Oops, gumball machine is out of gumballs");
                m_gumballMachine.SetState(m_gumballMachine.GetOutOfGumballsState());
            }
            else
            {
                m_gumballMachine.ReleaseBall();
                Console.WriteLine("YOU'RE WINNER! You got two gumballs for your quarter!");
                if (m_gumballMachine.GetCount() == 0)
                {
                    Console.WriteLine("Oops, gumball machine is out of gumballs");
                    m_gumballMachine.SetState(m_gumballMachine.GetOutOfGumballsState());
                }
                else
                {
                    m_gumballMachine.SetState(m_gumballMachine.GetNoQuarterState());
                }
            }
        }

        public void Refill() { }
    }
}