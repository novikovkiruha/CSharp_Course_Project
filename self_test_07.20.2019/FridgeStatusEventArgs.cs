using self_test_07._20._2019.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace self_test_07._20._2019
{
    public class FridgeStatusEventArgs : EventArgs
    {
        public SwitchStatus FridgeStatus { get; set; }

        public DoorStatus FridgeDoor { get; set; }

        public DoorStatus FreezerDoor { get; set; }

        public string Message { get; }

        //
        // for the first option
        //
        public FridgeStatusEventArgs(SwitchStatus fridgeStatus, DoorStatus fridgeDoor, DoorStatus freezerDoor, string message)
        {
            this.FridgeStatus = fridgeStatus;
            this.FridgeDoor = fridgeDoor;
            this.FreezerDoor = freezerDoor;
            this.Message = message;
        }

        //
        // for the second option with add'l method
        //
        public FridgeStatusEventArgs(string message)
        {
            this.Message = message;
        }
    }
}
