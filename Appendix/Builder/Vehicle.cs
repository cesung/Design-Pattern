namespace Builder
{
    public class Vehicle
    {
        private string m_vehicleType;
        private Dictionary<string, string> m_parts = new Dictionary<string, string>();

        public Vehicle(string vehicleType)
        {
            m_vehicleType = vehicleType;
        }

        // public Dictionary<string, string> Parts
        // {
        //     get => m_parts;
        //     set => m_parts = value;
        // }

        public string this[string key]
        {
            get => m_parts[key];
            set => m_parts[key] = value;
        }

        public void Show()
        {
            Console.WriteLine("\n---------------------------");
            Console.WriteLine("Vehicle Type: {0}", m_vehicleType);
            Console.WriteLine(" Frame : {0}", m_parts["Frame"]);
            Console.WriteLine(" Engine : {0}", m_parts["Engine"]);
            Console.WriteLine(" #Wheels: {0}", m_parts["Wheels"]);
            Console.WriteLine(" #Doors : {0}", m_parts["Doors"]);
        }
    }
}