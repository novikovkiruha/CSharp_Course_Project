using System;

namespace practice_05._18._19_classes.Task1_Figures
{
    public abstract class Figure
    {
        public double Ordinate { get; set; }

        public double Abscissa { get; set; }

        public Figure(double ordinate, double abscissa)
        {
            this.Ordinate = ordinate;
            this.Abscissa = abscissa;
        }

        public abstract void Draw();
    }
}