using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinalTask_CarRacing.Enum;

namespace FinalTask_CarRacing
{
    public class MyCar : Figure
    {
        public MyCar(char symbol, ConsoleColor color)
            : base(symbol, color)
        {
            
        }

        protected override void InitializeState()
        {
            this.nodes = new List<Node>() {
                new Node(1, 0),
                new Node(0, 1),
                new Node(1, 1),
                new Node(2, 1),
                new Node(1, 2),
                new Node(0, 3),
                new Node(2, 3)
            };
        }

        public override void Move(MoveDirection direction, Func<Figure, bool> isFree)
        {
            
        }
    }
}
