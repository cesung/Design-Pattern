namespace Bridge
{
    public class Program
    {
        public static void Main()
        {

            var LGRemoteControl = new LGRemoteControl(new Tv());
            Console.WriteLine("[LG TV Off]");
            LGRemoteControl.ShowInfo();

            Console.WriteLine("[LG TV Toggle On]");
            LGRemoteControl.TogglePower();
            LGRemoteControl.ShowInfo();

            Console.WriteLine("[LG TV Set Volumn and Channel]");
            LGRemoteControl.SetChannel(66);
            LGRemoteControl.SetVolumn(13);
            LGRemoteControl.ShowInfo();

            Console.WriteLine("[Mute LG TV]");
            LGRemoteControl.Mute();
            LGRemoteControl.ShowInfo();

            var SonyRemoteControl = new SonyRemoteControl(new Tv());
            Console.WriteLine("[Sony TV Off]");
            SonyRemoteControl.ShowInfo();

            Console.WriteLine("[Sony TV Toggle On]");
            SonyRemoteControl.TogglePower();
            SonyRemoteControl.ShowInfo();

            Console.WriteLine("[Sony TV Channel Up]");
            SonyRemoteControl.SetChannelUp();
            SonyRemoteControl.ShowInfo();

            Console.WriteLine("[Sony TV Channel Go Back]");
            SonyRemoteControl.GoBack();
            SonyRemoteControl.ShowInfo();

            Console.WriteLine("[Sony TV Channel Go Back]");
            SonyRemoteControl.GoBack();
            SonyRemoteControl.ShowInfo();
        }
    }
}