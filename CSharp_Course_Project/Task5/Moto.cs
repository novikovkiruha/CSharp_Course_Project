using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Course_Project.Task5
{
    class Moto : Vehicle
    {
        public MotoType MotoType { get; set; }

        public Moto(MotoType motoType,
            int wheelCount, ConsoleColor color, int maxSpeed, int passengerCount)
            :base(wheelCount, color, maxSpeed, passengerCount)
        {
            MotoType = motoType;
        }
    }

    enum MotoType
    {
        Adventure,
        Chopper,
        Cruiser,
        Enduro
    }
}
