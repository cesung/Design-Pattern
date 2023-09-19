namespace Singleton
{
    public class Singleton
    {
        private static int counter = 0;
        private static Singleton? instance;
        private static readonly object InstanceLock = new object();
        private Singleton()
        {
            counter += 1;
            Console.WriteLine($"Counter: {counter}");
        }

        // A Static/Class method
        // Need a class name to reference a static method
        public static Singleton GetInstance()
        {
            // lock (InstanceLock)
            // {
            //     // lazy instantiation, for the purpose of resource optimization
            //     if (instance == null)
            //     {
            //         instance = new Singleton();
            //     }
            // }
            if (instance == null)
            {
                lock (InstanceLock)
                {
                    if (instance == null)
                    {
                        instance = new Singleton();
                    }
                }
            }

            // if instance wasn't null, then it was previously created. Return the instance directly
            return instance;
        }

        public void PrintMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}