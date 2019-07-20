using self_test_07._20._2019.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace self_test_07._20._2019
{
    public class User
    {
        private readonly Fridge fridge;

        public User(Fridge fridge)
        {
            this.fridge = fridge;
        }

        public void PrintStatus(Object fridge, FridgeStatusEventArgs e)
        {
            Console.WriteLine(this.fridge.ToString());
        }
    }
}
