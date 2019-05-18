using practice_05._18._19_classes.Task1_Figures;
using practice_05._18._19_polymorphysm.Task2_Mammals;
using practice_05._18._19_polymorphysm.Task3_Human;
using practice_05._18._19_polymorphysm.Task4_Calculator;
using System;

namespace practice_05._18._19_polymorphysm
{
    class Program
    {
        static void Main(string[] args)
        {
            //new FigureDrawing().DrawFigure();
            //new Feeder().Feed();
            //new Greeting().HumanGreeting();
            new Calculator().PerformCalculation(10, 5);
        }
    }
}
