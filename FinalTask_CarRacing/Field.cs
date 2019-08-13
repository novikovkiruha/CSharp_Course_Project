using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTask_CarRacing
{
    public class Field
    {
        public int Width { get; }

        public int Height { get; }

        public int StartX { get; set; }

        public int StartY { get; set; }

        private List<Figure> figures;

        public Field()
        {
            this.Width = 10;
            this.Height = 20;
            //this.Initialize();
        }

        private void Initialize()
        {
            this.figures = new List<Figure>() {
                new MyCar('*', ConsoleColor.White),
                //new OtherCar('!', ConsoleColor.Red),
                //new OtherCar('!', ConsoleColor.Red),
                //new OtherCar('!', ConsoleColor.Red),
                //new OtherCar('!', ConsoleColor.Red),
                //new RoadBorder('|', ConsoleColor.Green)
            };
        }

        private bool IsPositionFree(Figure figure)
        {
            return true;
        }
    }
}
