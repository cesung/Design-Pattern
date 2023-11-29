namespace Proxy
{
    public class Program
    {
        public static void Main()
        {
            ProxyMath m_proxyMath = new ProxyMath();

            Console.WriteLine(m_proxyMath.Add(2.35, 4.66));
            Console.WriteLine(m_proxyMath.Div(2.0, 0.0));
        }
    }
}