namespace Facade
{
    public class Program
    {
        public static void Main()
        {
            Amplifier amplifier =
                new Amplifier("Pt390btu Digital Home Theater Bluetooth Stereo Receiver");
            PopcornPopper popcornPopper
                = new PopcornPopper("Presto 04830 PowerPop Microwave Multi-Popper, Black");
            Proejctor proejctor =
                new Proejctor("FLIK X7 Home Projector");
            Screen screen
                = new Screen("Samsung - 77” Class S89C OLED 4K Smart TV");

            StreamPlayer streamPlayer = new StreamPlayer("Roku Ultra 4802R");
            TheaterLights theaterLights = new TheaterLights("LED Theater Par Light");
            Turner turner = new Turner("Sony W87");

            HomeTheaterFacade homeTheaterFacade = new HomeTheaterFacade(
                amplifier,
                popcornPopper,
                proejctor,
                screen,
                streamPlayer,
                theaterLights,
                turner
            );

            homeTheaterFacade.WatchMoive("Final Destination IV");
            homeTheaterFacade.EndMovie("Final Destination IV");

        }
    }
}