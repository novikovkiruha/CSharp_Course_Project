using System;

namespace practice_05._18._19_classes.Task1_Figures
{
    public class Triangle : Figure
    {
        private double firstSide;

        private double secondSide;

        private double thirdSide;

        public Triangle(double ordinate, double abscissa, double firstSide, double secondSide, double thirdSide)
            : base(ordinate, abscissa)
        {
            this.firstSide = firstSide;
            this.secondSide = secondSide;
            this.thirdSide = thirdSide;
        }

        public double FirstSide
        {
            get
            {
                return this.firstSide;
            }
            set
            {
                if (value > 0)
                    this.firstSide = value;
            }
        }

        public double SecondSide
        {
            get
            {
                return this.secondSide;
            }
            set
            {
                if (value > 0)
                    this.secondSide = value;
            }
        }

        public double ThirdSide
        {
            get
            {
                return this.thirdSide;
            }
            set
            {
                if (value > 0)
                    this.thirdSide = value;
            }
        }

        public override void Draw()
        {
            Console.WriteLine($"Abscissa: {this.Abscissa}\nOrdinate: {this.Ordinate}\nSides of {GetType().Name}: {this.FirstSide}, {this.SecondSide}, {this.ThirdSide}");
        }
    }
}