using FinalTask_CarRacing.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTask_CarRacing
{
    public abstract class Figure
    {
        protected List<Node> nodes;

        public char Symbol { get; }

        public ConsoleColor Color { get; }

        public Figure(char symbol, ConsoleColor color)
        {
            this.Symbol = symbol;
            this.Color = color;
        }

        //protected abstract void InitializeState();

        //public abstract void Move(MoveDirection direction, Func<Figure, bool> moveState);
        //public abstract void Move();
    }
}
