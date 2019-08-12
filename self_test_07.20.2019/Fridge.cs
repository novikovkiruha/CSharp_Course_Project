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

        public event EventHandler<FridgeStatusEventArgs> FridgeEvent;

        public Fridge()
        {
            this.FridgeStatus = SwitchStatus.On;
            this.FridgeDoor = DoorStatus.Close;
            this.FreezerDoor = DoorStatus.Close;
        }

        //
        // first option
        //
        protected virtual void OnNewFridge(FridgeStatusEventArgs e)
        {
            if (this.FridgeEvent != null)
            {
                e.FridgeStatus = this.FridgeStatus;
                e.FridgeDoor = this.FridgeDoor;
                e.FreezerDoor = this.FreezerDoor;

                this.FridgeEvent(this, e);
            }
        }

        //
        // second option with add'l method
        //
        protected virtual void OnNewFridgeEvent(FridgeStatusEventArgs e)
        {
            this.FridgeEvent?.Invoke(this, e);
        }

        private void NotifySubscribers(string message)
        {
            this.OnNewFridgeEvent(new FridgeStatusEventArgs(this.FridgeStatus, this.FridgeDoor, this.FreezerDoor, message));
        }

        public SwitchStatus TurnOn()
        {
            this.FridgeStatus = SwitchStatus.On;
            
            //first option
            //this.OnNewFridge(new FridgeStatusEventArgs($"Fridge status was turned {this.FridgeStatus}{Environment.NewLine}"));

            //second option
            this.NotifySubscribers($"Fridge status was turned {this.FridgeStatus}{Environment.NewLine}");

            return this.FridgeStatus;
        }

        public SwitchStatus TurnOff()
        {
            this.FridgeStatus = SwitchStatus.Off;
            //this.OnNewFridge(new FridgeStatusEventArgs($"Fridge status was turned {this.FridgeStatus}{Environment.NewLine}"));

            //second option
            this.NotifySubscribers($"Fridge status was turned {this.FridgeStatus}{Environment.NewLine}");

            return this.FridgeStatus;
        }

        public DoorStatus OpenFridgeDoor()
        {
            this.FridgeDoor = DoorStatus.Open;
            //this.OnNewFridge(new FridgeStatusEventArgs($"Fridge door was {this.FridgeDoor}ed{Environment.NewLine}"));

            //second option
            this.NotifySubscribers($"Fridge door was {this.FridgeDoor}ed{Environment.NewLine}");

            return this.FridgeDoor;
        }

        public DoorStatus CloseFridgeDoor()
        {
            this.FridgeDoor = DoorStatus.Close;
            //this.OnNewFridge(new FridgeStatusEventArgs($"Fridge door was {this.FridgeDoor}d{Environment.NewLine}"));

            //second option
            this.NotifySubscribers($"Fridge door was {this.FridgeDoor}d{Environment.NewLine}");

            return this.FridgeDoor;
        }

        public DoorStatus OpenFreezerDoor()
        {
            this.FreezerDoor = DoorStatus.Open;
            //this.OnNewFridge(new FridgeStatusEventArgs($"Freezer door was {this.FreezerDoor}ed{Environment.NewLine}"));

            //second option
            this.NotifySubscribers($"Freezer door was {this.FreezerDoor}ed{Environment.NewLine}");

            return this.FreezerDoor;
        }

        public DoorStatus CloseFreezerDoor()
        {
            this.FreezerDoor = DoorStatus.Close;
            //this.OnNewFridge(new FridgeStatusEventArgs($"Freezer door was {this.FreezerDoor}d{Environment.NewLine}"));

            //second option
            this.NotifySubscribers($"Freezer door was {this.FreezerDoor}d{Environment.NewLine}");

            return this.FreezerDoor;
        }

        public override string ToString()
        {
            return $"Fridge status: {FridgeStatus}{Environment.NewLine}" +
                $"Fridge door status: {FridgeDoor}{Environment.NewLine}" +
                $"Freezer door status: {FreezerDoor}{Environment.NewLine}";
        }
    }
}
