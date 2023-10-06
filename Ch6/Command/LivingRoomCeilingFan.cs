using System.Reflection.Metadata.Ecma335;

namespace Command
{
    public enum Speed
    {
        HIGH,
        MEDIUM,
        LOW,
        OFF,
    }

    public class LivingRoomCeilingFan : ICeilingFan
    {

        // public void On()
        // {
        //     Console.WriteLine("Living Room Ceiling Fan is On");
        // }

        Speed speed;

        public string Name { get; set; } = "LivingRoomCeilingFan";

        public LivingRoomCeilingFan()
        {
            speed = Speed.OFF;
        }

        public void High()
        {
            Console.WriteLine("Living Room Ceiling Fan is on High");
            speed = Speed.HIGH;
        }

        public void Medium()
        {
            Console.WriteLine("Living Room Ceiling Fan is on Medium");
            speed = Speed.MEDIUM;
        }

        public void Low()
        {
            Console.WriteLine("Living Room Ceiling Fan is on Low");
            speed = Speed.LOW;
        }

        public void Off()
        {
            Console.WriteLine("Living Room Ceiling Fan is Off");
            speed = Speed.OFF;
        }

        public Speed GetSpeed()
        {
            return speed;
        }
    }
}
