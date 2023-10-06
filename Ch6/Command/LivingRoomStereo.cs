namespace Command
{
    public class LivingRoomStereo : IStereo
    {
        public string Name { get; set; } = "LivingRoomStereo";

        public void On()
        {
            Console.WriteLine("Living Room Stereo is On");
        }

        public void Off()
        {
            Console.WriteLine("Living Room Stereo is Off");
        }

        public void SetCd()
        {
            Console.WriteLine("Living Room Stereo is set for CD input");
        }

        public void SetDvd()
        {
            Console.WriteLine("Living Room Stereo is set for DVD input");
        }

        public void SetRadio()
        {
            Console.WriteLine("Living Room Stereo is set for Radio input");
        }

        public void SetVolumn(int volumn)
        {
            Console.WriteLine($"Living Room Stereo Volumn is set to {volumn}");
        }
    }
}