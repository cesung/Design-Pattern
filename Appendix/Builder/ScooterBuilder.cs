namespace Builder
{
    public class ScooterBuilder : IVehicleBuilder
    {
        public Vehicle Vehicle { get; set; }
        public ScooterBuilder()
        {
            Vehicle = new Vehicle("Scooter");
        }

        public void BuildFrame()
        {
            Vehicle["Frame"] = "Scooter Frame";
        }

        public void BuildEngine()
        {
            Vehicle["Engine"] = "1200 cc";
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