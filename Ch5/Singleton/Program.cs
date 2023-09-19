using System;
using System.Threading.Tasks;

namespace Singleton
{
    public class Program
    {
        public static void Main()
        {
            // Singleton instance;

            // instance = Singleton.GetInstance();
            // instance.PrintMessage("Call #1");

            // instance = Singleton.GetInstance();
            // instance.PrintMessage("Call #2");

            Parallel.Invoke(
                () =>
                {
                    var instance1 = Singleton.GetInstance();
                    instance1.PrintMessage($"Call #1");
                },
                () =>
                {
                    var instance2 = Singleton.GetInstance();
                    instance2.PrintMessage($"Call #2");
                }
            );
        }
    }
}