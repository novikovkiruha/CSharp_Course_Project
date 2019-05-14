using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice_05._11._19_classes.Task1_Figures
{
    public class Figure
    {
        public double Ordinate { get; set; }

        public double Abscissa { get; set; }

        public Figure(double ordinate, double abscissa)
        {
            this.Ordinate = ordinate;
            this.Abscissa = abscissa;
        }
    }
}
