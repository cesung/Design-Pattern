
namespace State
{
    public class NoQuarterState : IState
    {

        private GumballMachine m_gumballMachine;

        public NoQuarterState(GumballMachine gumballMachine)
        {
            m_gumballMachine = gumballMachine;
        }

        public void InsertQuarter()
        {
            Console.WriteLine("You inserted a quarter");
            m_gumballMachine.SetState(m_gumballMachine.GetHasQuarterState());
        }

        public void EjectQuarter()
        {
            Console.WriteLine("You haven't insert a quarter");
        }

        public void TurnCrank()
        {
            Console.WriteLine("You turned, but there's no quarter");
        }

        public void Dispense()
        {
            Console.WriteLine("You need to pay first");
        }

        public void Refill() { }
    }
}