using System;

namespace practice_05._18._19_classes.Task1_Figures
{
    public class Circle : Figure
    {
        private double radius;

        public Circle(double ordinate, double abscissa, double radius)
            : base(ordinate, abscissa)
        {
            this.radius = radius;
        }

        public double Radius
        {
            get
            {
                return this.radius;
            }
            set
            {
                if (value > 0)
                {
                    this.radius = value;
                }
            }
        }

        public override void Draw()
        {
            Console.WriteLine($"Abscissa: {this.Abscissa}\n" +
                $"Ordinate: {this.Ordinate}\n" +
                $"The radius of {this.GetType().Name}: {this.Radius}");
        }
    }
}