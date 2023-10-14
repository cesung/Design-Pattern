using System.ComponentModel;

namespace Facade
{
    public class StreamPlayer
    {

        public string Description { get; set; }

        public StreamPlayer(string description)
        {
            Description = description;
        }

        public void TurnOn()
        {
            Console.WriteLine($"Turn {Description} On");
        }

        public void TurnOff()
        {
            Console.WriteLine($"Turn {Description} Off");
        }

        public void Play(string movie)
        {
            Console.WriteLine($"Play {movie}");
        }

        public void Puase(string movie)
        {
            Console.WriteLine($"Pause {movie}");
        }

        public void Stop(string movie)
        {
            Console.WriteLine($"Stop {movie}");
        }

        public void SetSurroundAudio()
        {
            Console.WriteLine("Set Surround Audio");
        }

        public void SetTwoChannelAudio()
        {
            Console.WriteLine("Set Two Channel Audio");
        }

        public override string ToString()
        {
            return Description;
        }
    }
}