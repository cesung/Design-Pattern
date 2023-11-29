namespace Builder
{
    public class CarBuilder : IVehicleBuilder
    {
        public Vehicle Vehicle { get; set; }
        public CarBuilder()
        {
            Vehicle = new Vehicle("Car");
        }

        public void BuildFrame()
        {
            Vehicle["Frame"] = "Car Frame";
        }

        public void BuildEngine()
        {
            Vehicle["Engine"] = "2500 cc";
        }

        public void BuildWheels()
        {
            Vehicle["Wheels"] = "4";
        }

        public void BuildDoors()
        {
            Vehicle["Doors"] = "4";
        }
    }
}