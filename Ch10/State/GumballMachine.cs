using System.ComponentModel;
using System.Reflection.PortableExecutable;
using System.Text;

namespace State
{
    public class GumballMachine
    {
        IState m_hasQuarterState;
        IState m_noQuarterState;
        IState m_outOfGumballsState;
        IState m_soldState;
        IState m_winnerState;

        private int m_count;
        private IState m_state;

        public GumballMachine(int count)
        {
            m_hasQuarterState = new HasQuarterState(this);
            m_noQuarterState = new NoQuarterState(this);
            m_outOfGumballsState = new OutOfGumballsState(this);
            m_soldState = new SoldState(this);
            m_winnerState = new WinnerState(this);

            m_count = count;
            if (m_count > 0)
            {
                m_state = m_noQuarterState;
            }
            else
            {
                m_state = m_outOfGumballsState;
            }
        }

        public void InsertQuarter()
        {
            m_state.InsertQuarter();
        }

        public void EjectQuarter()
        {
            m_state.EjectQuarter();
        }

        public void TurnCrank()
        {
            m_state.TurnCrank();
            m_state.Dispense();
        }

        // Note that we don't need an action method for Dispense. Dispense is an internal action
        // A user can't ask the machine to dispense directly. Instead, we call Dispense() from the
        // TurnCrank() mehtod

        public int GetCount()
        {
            return m_count;
        }

        public void ReleaseBall()
        {
            Console.WriteLine("A gumball comes rolling out the slot...");
            if (m_count > 0)
            {
                m_count -= 1;
            }
        }

        public void Refill(int count)
        {
            m_count += count;
            Console.WriteLine($"The gumball machine was just refilled; its new count is: {m_count}");
            m_state.Refill();
        }

        public IState GetState()
        {
            return m_state;
        }

        public void SetState(IState state)
        {
            m_state = state;
        }

        public IState GetHasQuarterState()
        {
            return m_hasQuarterState;
        }

        public IState GetNoQuarterState()
        {
            return m_noQuarterState;
        }

        public IState GetOutOfGumballsState()
        {
            return m_outOfGumballsState;
        }

        public IState GetSoldState()
        {
            return m_soldState;
        }

        public IState GetWinnerState()
        {
            return m_winnerState;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append("\nMighty Gumball, Inc.");
            result.Append("\nJava-enabled Standing Gumball Model #2004");
            result.Append("\nInventory: " + m_count + " gumball");
            if (m_count != 1)
            {
                result.Append("s");
            }
            result.Append("\n");
            result.Append("Machine is " + m_state + "\n");
            return result.ToString();
        }

        public void Refill() { }
    }
}