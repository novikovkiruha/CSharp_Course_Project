using practice_06._15._2019_generics.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice_06._15._2019_generics.Task2_CarCollection
{
    public class Car : ICar
    {
        public string CarName { get; set; }

        public int CarYear { get; set; }
    }
}
