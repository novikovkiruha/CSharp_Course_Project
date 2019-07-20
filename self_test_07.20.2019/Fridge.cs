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
        //public delegate void FridgeDelegate(Object fridge, FridgeStatusEventArgs args);

        public event EventHandler NewFridge;

        public DoorStatus FridgeDoor { get; set; }

        public DoorStatus FreezerDoor { get; set; }

        public SwitchStatus FridgeStatus { get; set; }

        protected virtual void OnNewFridge(EventArgs e)
        {
            this.NewFridge?.Invoke(this, e);
        }

        public void PrintFridgeStatus(Fridge fridge)
        {
            Console.WriteLine(fridge.ToString());
            this.OnNewFridge(new EventArgs());
        }

        public override string ToString()
        {
            return $"Fridge status: {FridgeStatus}{Environment.NewLine}" +
                $"Fridge door status: {FridgeDoor}{Environment.NewLine}" +
                $"Freezer door status: {FreezerDoor}{Environment.NewLine}";
        }
    }
}
