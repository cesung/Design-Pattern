namespace Adapter
{
    public class TurkeyToDuckAdapter : IDuck
    {
        private readonly ITurkey m_turkey;

        public TurkeyToDuckAdapter(ITurkey turkey)
        {
            m_turkey = turkey;
        }

        public void Quack()
        {
            m_turkey.Gobble();
        }

        public void Fly()
        {
            // since Turkey fly in a short distance, we call the Turkey's Fly() five times
            for (int i = 0; i < 5; i++)
            {
                m_turkey.Fly();
            }
        }
    }
}