using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice_05._11._19_classes.Task1_Figures
{
    public class Rhombus : Figure
    {
        private double firstDiagonal;

        private double secondDiagonal;

        public Rhombus(double ordinate, double abscissa, double firstDiagonal, double secondDiagonal)
            : base(ordinate, abscissa)
        {
            this.firstDiagonal = firstDiagonal;
            this.secondDiagonal = secondDiagonal;
        }

        public double FirstDiagonal
        {
            get
            {
                return this.firstDiagonal;
            }
            set
            {
                if (value > 0)
                {
                    this.firstDiagonal = value;
                }
            }
        }

        public double SecondDiagonal
        {
            get
            {
                return this.secondDiagonal;
            }
            set
            {
                if (value > 0)
                {
                    this.secondDiagonal = value;
                }
            }
        }
    }
}
