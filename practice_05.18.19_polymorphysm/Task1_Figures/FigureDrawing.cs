using System;

namespace practice_05._18._19_classes.Task1_Figures
{
    public class FigureDrawing
    {
        public void DrawFigure()
        {
            Figure[] figures =
            {
                new Circle(5.0, 3.5, 10),
                new Circle(1.5, 2.5, 5),
                new Triangle(5.0, 10.0, 10, 12, 14),
                new Triangle(6.5, 7.0, 7, 8, 9),
            };

            foreach (var item in figures)
            {
                item.Draw();
            }
        }
    }
}