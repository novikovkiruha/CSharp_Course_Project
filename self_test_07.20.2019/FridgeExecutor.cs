using self_test_07._20._2019.Enum;
using System;

namespace self_test_07._20._2019
{
    public class FridgeExecutor
    {
        public Fridge Fridge { get; set; }

        public FridgeExecutor(Fridge fridge)
        {
            this.Fridge = fridge;

            this.Fridge.FridgeEvent += this.OnNewFridgeEventInvoked;
            this.Fridge.ChangeFridgeStatus();
            this.Fridge.ChangeFridgeDoorPosition();
            this.Fridge.ChangeFreezerDoorPosition();
        }

        public void OnNewFridgeEventInvoked(object sender, FridgeStatusEventArgs e)
        {
            Console.WriteLine(e.Message);
        }
    }
}
