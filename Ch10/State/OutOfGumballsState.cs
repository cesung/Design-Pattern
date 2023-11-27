
namespace State
{
    public class OutOfGumballsState : IState
    {
        private GumballMachine m_gumballMachine;

        public OutOfGumballsState(GumballMachine gumballMachine)
        {
            m_gumballMachine = gumballMachine;
        }

        public void InsertQuarter()
        {
            Console.WriteLine("You can't insert a quarter, all gumballs sold out!");
        }

        public void EjectQuarter()
        {
            Console.WriteLine("You can't eject, you haven't inserted a quarter yet");
        }

        public void TurnCrank()
        {
            Console.WriteLine("You've turned, but there are no gumballs");
        }

        public void Dispense()
        {
            Console.WriteLine("No gumball dispensed");
        }

        public void Refill() { }
    }
}