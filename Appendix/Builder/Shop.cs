using System.Reflection.Emit;

namespace Builder
{
    public class Shop
    {
        IVehicleBuilder m_vehicleBuilder;
        public Shop(IVehicleBuilder vehicleBuilder)
        {
            m_vehicleBuilder = vehicleBuilder;
        }

        public void Construct()
        {
            m_vehicleBuilder.BuildFrame();
            m_vehicleBuilder.BuildEngine();
            m_vehicleBuilder.BuildDoors();
            m_vehicleBuilder.BuildWheels();
        }
    }
}