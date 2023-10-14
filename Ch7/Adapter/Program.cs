namespace Adapter
{
    public class Program
    {
        public static void Main()
        {
            // create a MallardDuck
            IDuck m_mallardDuck = new MallardDuck();
            m_mallardDuck.Quack();
            m_mallardDuck.Fly();

            // create a WildTurkey
            ITurkey m_wildTurkey = new WildTurkey();
            m_wildTurkey.Gobble();
            m_wildTurkey.Fly();

            // create a Fake Duck (a WildTurkey act like a Duck)
            IDuck m_fakeDuck = new TurkeyToDuckAdapter(m_wildTurkey);
            m_fakeDuck.Quack();
            m_fakeDuck.Fly();
        }
    }
}

