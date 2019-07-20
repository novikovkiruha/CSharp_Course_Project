using self_test_07._20._2019.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace self_test_07._20._2019.ChangedTask
{
    public class NewFridge
    {
        public delegate void FridgeDelegate(Object fridge, FridgeStatusEventArgs args);

        public event FridgeDelegate FridgeEvent;

        public SwitchStatus FridgeStatus { get; }

        public DoorStatus FridgeDoor { get; }

        public DoorStatus FreezerDoor { get; }

        protected virtual void OnNewFridge(FridgeStatusEventArgs e)
        {
            this.FridgeEvent?.Invoke(this, e);
        }

        public void PrintFridgeStatus(Fridge fridge, FridgeStatusEventArgs e)
        {
            Console.WriteLine(fridge.ToString());
            this.OnNewFridge(e);
        }

        public SwitchStatus ChangeSwitchStatus()
        {
            while (true)
            {
                Console.WriteLine($"Please choose one of the option to set a fridge status:{Environment.NewLine}" +
                $"1 - turn on{Environment.NewLine}" +
                $"0 - turn off{Environment.NewLine}");
                var fridgeStatus = Console.ReadLine();

                if (fridgeStatus != "0" && fridgeStatus != "1")
                {
                    Console.WriteLine("Incorrect value. Please, try again...");
                    continue;
                }

                switch (fridgeStatus)
                {
                    case "1":
                        return SwitchStatus.TurnOn;
                    case "0":
                        return SwitchStatus.TurnOff;
                    default:
                        Console.WriteLine("Wrong staus. Try again...");
                        break;
                }
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
