using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace self_test_07._20._2019
{
    class Program
    {
        static void Main(string[] args)
        {
            new FridgeExecutor().Execute();
            var fridge = new Fridge();
            var user = new User(fridge);

            fridge.PrintFridgeStatus(fridge);
        }
    }
}
