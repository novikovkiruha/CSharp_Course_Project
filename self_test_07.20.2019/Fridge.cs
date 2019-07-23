using self_test_07._20._2019.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace self_test_07._20._2019
{
    public class Fridge
    {
        public SwitchStatus FridgeStatus { get; set; }

        public DoorStatus FridgeDoor { get; set; }

        public DoorStatus FreezerDoor { get; set; }

        //public delegate void FridgeDelegate(object fridge, FridgeStatusEventArgs args);

        public event EventHandler<FridgeStatusEventArgs> FridgeEvent;

        protected virtual void OnNewFridge(FridgeStatusEventArgs e)
        {
            this.FridgeEvent?.Invoke(this, e);
        }

        public void ChangeFridgeStatus()
        {
            while (true)
            {
                Console.WriteLine($"Choose the option:{Environment.NewLine}" +
                                $"1 - Turn on the fridge{Environment.NewLine}" +
                                $"2 - Turn off the fridge{Environment.NewLine}" +
                                $"0 - Exit{Environment.NewLine}");

                var fridgeStatus = Console.ReadLine();

                if (fridgeStatus == string.Empty)
                {
                    Console.WriteLine("Please choose one of the option...");
                    continue;
                }

                switch (fridgeStatus)
                {
                    case "1":
                        this.FridgeStatus = SwitchStatus.On;
                        Console.ForegroundColor = ConsoleColor.Green;
                        break;
                    case "2":
                        this.FridgeStatus = SwitchStatus.Off;
                        Console.ForegroundColor = ConsoleColor.Red;
                        break;
                    case "0":
                        break;
                    default:
                        Console.WriteLine("Wrong option. Try again...");
                        continue;
                }

                this.OnNewFridge(new FridgeStatusEventArgs($"Fridge status: {this.FridgeStatus}{Environment.NewLine}"));
                Console.ForegroundColor = ConsoleColor.Gray;

                if (fridgeStatus == "0")
                    break;
            }
        }

        public void ChangeFridgeDoorPosition()
        {
            while (true)
            {
                Console.WriteLine($"Choose the option:{Environment.NewLine}" +
                                $"1 - Open the fridge door{Environment.NewLine}" +
                                $"2 - Close the fridge door{Environment.NewLine}" +
                                $"0 - Exit");

                var fridgeDoorPosition = Console.ReadLine();

                if (fridgeDoorPosition == string.Empty)
                {
                    Console.WriteLine("Please choose one of the option...");
                    continue;
                }

                switch (fridgeDoorPosition)
                {
                    case "1":
                        this.FridgeDoor = DoorStatus.Open;
                        Console.ForegroundColor = ConsoleColor.Green;
                        break;
                    case "2":
                        this.FridgeDoor = DoorStatus.Close;
                        Console.ForegroundColor = ConsoleColor.Red;
                        break;
                    case "0":
                        break;
                    default:
                        Console.WriteLine("Wrong option. Try again...");
                        continue;
                }

                this.OnNewFridge(new FridgeStatusEventArgs($"Fridge door position: {this.FridgeDoor}{Environment.NewLine}"));
                Console.ForegroundColor = ConsoleColor.Gray;

                if (fridgeDoorPosition == "0")
                    break;
            }
        }

        public void ChangeFreezerDoorPosition()
        {
            while (true)
            {
                Console.WriteLine($"Choose the option:{Environment.NewLine}" +
                                $"1 - Open the freezer door{Environment.NewLine}" +
                                $"2 - Close the freezer door{Environment.NewLine}" +
                                $"0 - Exit{Environment.NewLine}");

                var freezerDoorPosition = Console.ReadLine();

                if (freezerDoorPosition == string.Empty)
                {
                    Console.WriteLine("Please choose one of the option...");
                    continue;
                }

                switch (freezerDoorPosition)
                {
                    case "1":
                        this.FreezerDoor = DoorStatus.Open;
                        Console.ForegroundColor = ConsoleColor.Green;
                        break;
                    case "2":
                        this.FreezerDoor = DoorStatus.Close;
                        Console.ForegroundColor = ConsoleColor.Red;
                        break;
                    case "0":
                        break;
                    default:
                        Console.WriteLine("Wrong option. Try again...");
                        continue;
                }

                this.OnNewFridge(new FridgeStatusEventArgs($"Freezer door position: {this.FreezerDoor}{Environment.NewLine}"));
                Console.ForegroundColor = ConsoleColor.Gray;

                if (freezerDoorPosition == "0")
                    break;
            }
        }

        public override string ToString()
        {
            return $"Fridge status: {FridgeStatus}{Environment.NewLine}" +
                $"Fridge door status: {FridgeDoor}{Environment.NewLine}" +
                $"Freezer door status: {FreezerDoor}{Environment.NewLine}";
        }
    }
}
