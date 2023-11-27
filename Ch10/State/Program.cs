using System.ComponentModel;

namespace State
{
    public class Program
    {
        public static void Main()
        {
            GumballMachine m_gumballMachine = new GumballMachine(5);

            Console.WriteLine(m_gumballMachine);
            m_gumballMachine.InsertQuarter();
            m_gumballMachine.TurnCrank();

            Console.WriteLine(m_gumballMachine);
            m_gumballMachine.InsertQuarter();
            m_gumballMachine.TurnCrank();
            m_gumballMachine.InsertQuarter();
            m_gumballMachine.TurnCrank();

            Console.WriteLine(m_gumballMachine);
        }
    }

}