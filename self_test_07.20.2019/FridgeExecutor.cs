using self_test_07._20._2019.Enum;
using System;

namespace self_test_07._20._2019
{
    public class FridgeExecutor
    {
        public void Execute()
        {
            var fridge = new Fridge();

            Console.WriteLine($"Please choose one of the option to set a fridge status:{Environment.NewLine}" +
                $"1 - turn on{Environment.NewLine}" +
                $"0 - turn off{Environment.NewLine}");
            var fridgeStatus = Console.ReadLine();

            switch (fridgeStatus)
            {
                case "1":
                    fridge.FridgeStatus = SwitchStatus.TurnOn;
                    break;
                case "0":
                    fridge.FridgeStatus = SwitchStatus.TurnOff;
                    break;
                default:
                    Console.WriteLine("Wrong staus. Try again...");
                    break;
            }

            Console.WriteLine($"Please choose one of the option to set a fridge door status:{Environment.NewLine}" +
                $"1 - open{Environment.NewLine}" +
                $"0 - close{Environment.NewLine}");
            var fridgeDoorStatus = Console.ReadLine();

            switch (fridgeDoorStatus)
            {
                case "1":
                    fridge.FridgeDoor = DoorStatus.Open;
                    break;
                case "0":
                    fridge.FridgeDoor = DoorStatus.Close;
                    break;
                default:
                    Console.WriteLine("Wrong staus. Try again...");
                    break;
            }

            Console.WriteLine($"Please choose one of the option to set a freezer door status:{Environment.NewLine}" +
                $"1 - open{Environment.NewLine}" +
                $"0 - close{Environment.NewLine}");
            var freezerDoorStatus = Console.ReadLine();

            switch (freezerDoorStatus)
            {
                case "1":
                    fridge.FreezerDoor = DoorStatus.Open;
                    break;
                case "0":
                    fridge.FreezerDoor = DoorStatus.Close;
                    break;
                default:
                    Console.WriteLine("Wrong staus. Try again...");
                    break;
            }
        }
    }
}
