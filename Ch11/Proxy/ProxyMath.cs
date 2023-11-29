namespace Proxy
{
    public class ProxyMath : IMath
    {
        private Math? m_math;

        public void CheckInstance()
        {
            if (m_math == null)
            {
                m_math = new Math();
            }
        }
        public double? Add(double x, double y)
        {
            // lazy initialization
            CheckInstance();
            return m_math?.Add(x, y);
        }

        public double? Sub(double x, double y)
        {
            // lazy initialization
            CheckInstance();
            return m_math?.Sub(x, y);
        }

        public double? Mul(double x, double y)
        {
            // lazy initialization
            CheckInstance();
            return m_math?.Mul(x, y);
        }

        public double? Div(double x, double y)
        {
            // lazy initialization
            CheckInstance();

            // additional logic check, if y == 0, reutrn 0
            if (y == 0)
            {
                return 0.0;
            }

            return m_math?.Div(x, y);
        }
    }
}