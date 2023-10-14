namespace Facade
{
    public class HomeTheaterFacade
    {
        Amplifier Amplifier { get; set; }
        PopcornPopper PopcornPopper { get; set; }
        Proejctor Proejctor { get; set; }
        Screen Screen { get; set; }
        StreamPlayer StreamPlayer { get; set; }
        TheaterLights TheaterLights { get; set; }
        Turner Turner { get; set; }

        public HomeTheaterFacade
        (
            Amplifier amplifier,
            PopcornPopper popcornPopper,
            Proejctor proejctor,
            Screen screen,
            StreamPlayer streamPlayer,
            TheaterLights theaterLights,
            Turner turner
        )
        {
            Amplifier = amplifier;
            PopcornPopper = popcornPopper;
            Proejctor = proejctor;
            Screen = screen;
            StreamPlayer = streamPlayer;
            TheaterLights = theaterLights;
            Turner = turner;
        }

        public void WatchMoive(string movie)
        {
            Console.WriteLine($"\n\n===== Get Ready to Watch Movie: {movie} ======");

            PopcornPopper.TurnOn();
            PopcornPopper.Pop();

            TheaterLights.TurnOn();
            TheaterLights.Dim(10);

            Screen.Down();

            Proejctor.TurnOn();
            Proejctor.WideScreenMode();

            Amplifier.SetStreamPlayer();
            Amplifier.SetSurroundMode();
            Amplifier.SetVolumn(5);

            StreamPlayer.TurnOn();
            StreamPlayer.Play(movie);
        }

        public void EndMovie(string movie)
        {
            Console.WriteLine("\n\n====== Shutting Movie Theater Down ======");
            PopcornPopper.TurnOff();
            TheaterLights.TurnOff();
            Screen.Up();
            Proejctor.TurnOff();
            Amplifier.TurnOff();
            StreamPlayer.Stop(movie);
            StreamPlayer.TurnOff();
        }
    }
}