using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTask_CarRacing
{
    public class Field
    {
        private int startX;

        private int startY;

        public int Width { get; }

        public int Height { get; }

        private List<Figure> figures;

        private void Initialize()
        {
            this.figures = new List<Figure>() {
                new MyCar('*', ConsoleColor.White),
                new OtherCar('!', ConsoleColor.Red),
                new OtherCar('!', ConsoleColor.Red),
                new OtherCar('!', ConsoleColor.Red),
                new OtherCar('!', ConsoleColor.Red),
                new RoadBorder('|', ConsoleColor.Black)
            };
        }

        private bool IsPositionFree(Figure figure)
        {

            return true;
        }
    }
}
