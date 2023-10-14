using System.Diagnostics.Contracts;

namespace Facade
{
    public class Amplifier
    {
        private Turner? m_turner;
        private StreamPlayer? m_streamPlayer;

        public string Description { get; set; }

        public Amplifier(string description)
        {
            Description = description;
        }

        public void SetTurner(Turner tuner)
        {
            m_turner = tuner;
        }

        public void SetStreamPlayer(StreamPlayer streamPlayer)
        {
            m_streamPlayer = streamPlayer;
        }

        public void TurnOn()
        {
            Console.WriteLine($"Turn {Description} On");
        }

        public void TurnOff()
        {
            Console.WriteLine($"Turn {Description} Off");
        }

        public void SetStreamPlayer()
        {
            Console.WriteLine($"Setting Streaming Player to {m_streamPlayer}");
        }

        public void SetStereoMode()
        {
            Console.WriteLine("Turn Stereo Mode On");
        }

        public void SetSurroundMode()
        {
            Console.WriteLine("Turn Surround Mode On");
        }

        public void SetTunner()
        {
            Console.WriteLine($"Set Turner to {m_turner}");
        }

        public void SetVolumn(int volumn)
        {
            Console.WriteLine($"Set Volumn to {volumn} level");
        }
    }
}