using System;

namespace practice_05._11._19_classes.Task1_Figures
{
    public static class FigureDrawing
    {
        public static void DrawFigure()
        {
            Figure[] figures =
            {
                new Circle(5.0, 3.5, 10),
                new Circle(1.5, 2.5, 5),
                new Triangle(5.0, 10.0, 10, 12, 14),
                new Triangle(6.5, 7.0, 7, 8, 9),
                new Square(3.0, 3.0, 3, 5),
                new Square(5.0, 3, 10, 20),
                new Rhombus(4.0, 5.0, 5, 7),
                new Rhombus(4.0, 5.0, 5, 7)
            };

            foreach (var item in figures)
            {
                if (item is Triangle triangle)
                    triangle.Draw();
                else if (item is Circle circle)
                    circle.Draw();
                else if (item is Square square)
                    square.Draw();
                else if (item is Rhombus rhombus) { }
            }
        }
    }
}
