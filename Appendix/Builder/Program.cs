namespace Builder
{
    public class Program
    {
        public static void Main()
        {
            IVehicleBuilder carBuilder = new CarBuilder();
            Shop carShop = new Shop(carBuilder);
            carShop.Construct();
            carBuilder.Vehicle.Show();

            IVehicleBuilder scooterBuilder = new ScooterBuilder();
            Shop scooterShop = new Shop(scooterBuilder);
            scooterShop.Construct();
            scooterBuilder.Vehicle.Show();

            IVehicleBuilder motorCycleBuilder = new MotorCycleBuilder();
            Shop motorCycleShop = new Shop(motorCycleBuilder);
            motorCycleShop.Construct();
            motorCycleBuilder.Vehicle.Show();
        }
    }
}