namespace Command
{
    public class Program
    {
        public static void Main()
        {

            /* Remote Control */
            RemoteControl remoteControl = new RemoteControl();

            /* Light */
            ILight livingRoomLight = new LivingRoomLight();
            // create the command object
            LightOnCommand livingRoomLightOnCommand = new LightOnCommand(livingRoomLight);
            LightOffCommand livinfRoomLightOffCommand = new LightOffCommand(livingRoomLight);
            ILight kitchenLight = new KitchenLight();
            LightOnCommand kitchenLightOnCommand = new LightOnCommand(kitchenLight);
            LightOffCommand kitchenLightOffCommand = new LightOffCommand(kitchenLight);

            /* Door */
            IDoor garageDoor = new GarageDoor();
            DoorUpCommand garageDoorUpCommand = new DoorUpCommand(garageDoor);
            DoorDownCommand garageDoorDownCommand = new DoorDownCommand(garageDoor);

            /* Ceiling Fan */
            ICeilingFan livingRoomCeilingFan = new LivingRoomCeilingFan();
            // CeilingFanOnCommand livingRoomCeilingFanOnCommand = new CeilingFanOnCommand(livingRoomCeilingFan);
            CeilingFanHighCommand livingRoomCeilingFanHighCommand = new CeilingFanHighCommand(livingRoomCeilingFan);
            CeilingFanMediumCommand livingRoomCeilingFanMediumCommand = new CeilingFanMediumCommand(livingRoomCeilingFan);
            CeilingFanLowCommand livingRoomCeilingFanLowCommand = new CeilingFanLowCommand(livingRoomCeilingFan);
            CeilingFanOffCommand livingRoomCeilingFanOffCommand = new CeilingFanOffCommand(livingRoomCeilingFan);

            /* Stereo */
            IStereo livingRoomStereo = new LivingRoomStereo();
            StereoOnWithCDCommand livingRoomStereoOnWithCDCommand = new StereoOnWithCDCommand(livingRoomStereo);
            StereoOffCommand livingRoomStereoOffCommand = new StereoOffCommand(livingRoomStereo);

            /* Party Mode */
            MacroCommand partyOnCommand = new MacroCommand(new ICommand[] {
                livingRoomLightOnCommand,
                livingRoomLightOnCommand,
                livingRoomStereoOnWithCDCommand
            });

            MacroCommand partyOffCommand = new MacroCommand(new ICommand[] {
                livinfRoomLightOffCommand,
                livingRoomCeilingFanOffCommand,
                livingRoomStereoOffCommand
            });

            // call setCommand and store the command object in the invoker
            remoteControl.SetCommand(0, livingRoomLightOnCommand, livinfRoomLightOffCommand);
            remoteControl.SetCommand(1, kitchenLightOnCommand, kitchenLightOffCommand);
            remoteControl.SetCommand(2, garageDoorUpCommand, garageDoorDownCommand);
            remoteControl.SetCommand(3, livingRoomCeilingFanHighCommand, livingRoomCeilingFanOffCommand);
            remoteControl.SetCommand(4, livingRoomCeilingFanMediumCommand, livingRoomCeilingFanOffCommand);
            remoteControl.SetCommand(5, livingRoomCeilingFanLowCommand, livingRoomCeilingFanOffCommand);
            // remoteControl.SetCommand(4, livingRoomStereoOnWithCDCommand, livingRoomStereoOffCommand);
            remoteControl.SetCommand(6, livingRoomStereoOnWithCDCommand, livingRoomStereoOffCommand);
            remoteControl.SetCommand(7, partyOnCommand, partyOffCommand);



            Console.WriteLine(remoteControl);

            // client ask the invoker to execute the command
            remoteControl.OnOnBtnsPressed(0);
            remoteControl.OnOffBtnsPressed(0);
            remoteControl.OnUndoBtnPressed();

            Console.WriteLine(remoteControl);

            remoteControl.OnOnBtnsPressed(1);


            Console.WriteLine(remoteControl);
            remoteControl.OnOffBtnsPressed(1);

            Console.WriteLine("---Party Mode On---");
            remoteControl.OnOnBtnsPressed(7);
            Console.WriteLine("---Party Mode Off---");
            remoteControl.OnOffBtnsPressed(7);

        }
    }
}