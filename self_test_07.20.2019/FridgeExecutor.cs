using self_test_07._20._2019.Enum;
using System;

namespace self_test_07._20._2019
{
    public class FridgeExecutor
    {
        public Fridge fridge;

        public FridgeExecutor()
        {
        }

        public void FridgeManager()
        {
            this.fridge = new Fridge();
            this.fridge.FridgeEvent += this.OnNewFridgeEventInvoked;
            this.fridge.FridgeEvent += this.OnNewCurrentFridgeStatusInvoked;

            while (true)
            {
                Console.WriteLine($"Please choose the action:{Environment.NewLine}" +
                    $"1 - Turn On the fridge{Environment.NewLine}" +
                    $"2 - Turn Off the fridge{Environment.NewLine}" +
                    $"3 - Open fridge door{Environment.NewLine}" +
                    $"4 - Close fridge door{Environment.NewLine}" +
                    $"5 - Open freezer door{Environment.NewLine}" +
                    $"6 - Close freezer door{Environment.NewLine}" +
                    $"0 - Exit{Environment.NewLine}");

                var action = Console.ReadLine();

                if (action == string.Empty)
                {
                    Console.WriteLine("Please choose one of the action...");
                    continue;
                }

                switch (action)
                {
                    case "1":
                        Console.ForegroundColor = ConsoleColor.Green;
                        this.fridge.TurnOn();
                        Console.ResetColor();
                        break;
                    case "2":
                        Console.ForegroundColor = ConsoleColor.Red;
                        this.fridge.TurnOff();
                        Console.ResetColor();
                        break;
                    case "3":
                        Console.ForegroundColor = ConsoleColor.Green;
                        this.fridge.OpenFridgeDoor();
                        Console.ResetColor();
                        break;
                    case "4":
                        Console.ForegroundColor = ConsoleColor.Red;
                        this.fridge.CloseFridgeDoor();
                        Console.ResetColor();
                        break;
                    case "5":
                        Console.ForegroundColor = ConsoleColor.Green;
                        this.fridge.OpenFreezerDoor();
                        Console.ResetColor();
                        break;
                    case "6":
                        Console.ForegroundColor = ConsoleColor.Red;
                        this.fridge.CloseFreezerDoor();
                        Console.ResetColor();
                        break;
                    case "0":
                        break;
                    default:
                        Console.WriteLine($"Wrong option. Try again...{Environment.NewLine}");
                        continue;
                }

                if (action == "0")
                    break;
            }
        }

        public void OnNewFridgeEventInvoked(object sender, FridgeStatusEventArgs e)
        {
            Console.WriteLine(e.Message);
        }

        public void OnNewCurrentFridgeStatusInvoked(object sender, FridgeStatusEventArgs e)
        {
            Console.ResetColor();

            e.FridgeStatus = this.fridge.FridgeStatus;
            e.FridgeDoor = this.fridge.FridgeDoor;
            e.FreezerDoor = this.fridge.FreezerDoor;

            Console.WriteLine($"Current fridge status: {e.FridgeStatus}{Environment.NewLine}" +
                $"Current fridge door status: {e.FridgeDoor}{Environment.NewLine}" +
                $"Current freezer door status: {e.FreezerDoor}{Environment.NewLine}");
        }
    }
}
