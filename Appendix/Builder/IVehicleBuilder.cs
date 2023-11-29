using System.Reflection.Metadata;

namespace Builder
{
    public interface IVehicleBuilder
    {
        Vehicle Vehicle { get; set; }
        void BuildFrame();
        void BuildEngine();
        void BuildWheels();
        void BuildDoors();
    }
}