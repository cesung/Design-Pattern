namespace Builder
{
    public class MotorCycleBuilder : IVehicleBuilder
    {
        public Vehicle Vehicle { get; set; }
        public MotorCycleBuilder()
        {
            Vehicle = new Vehicle("MotorCycle");
        }

        public void BuildFrame()
        {
            Vehicle["Frame"] = "MotorCycle Frame";
        }

        public void BuildEngine()
        {
            Vehicle["Engine"] = "2000 cc";
        }

        public void BuildWheels()
        {
            Vehicle["Wheels"] = "2";
        }

        public void BuildDoors()
        {
            Vehicle["Doors"] = "0";
        }
    }
}