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
        private int startY;

        private int previousX;

        public MyCar(char symbol, ConsoleColor color)
            : base(symbol, color)
        {
            
        }

        protected void InitializeState(int startX, int startY)
        {
            this.nodes = new List<Node>() {

                                                    new Node(startX - 1, startY - 3),
                new Node(startX - 2, startY - 2),   new Node(startX - 1, startY - 2),   new Node(startX, startY - 2),
                                                    new Node(startX - 1, startY - 1),
                new Node(startX - 2, startY),                                           new Node(startX, startY)

            };
        }

        public void DrawMyCar(int startX, int startY)
        {
            this.startY = startY;
            this.InitializeState(startX, startY);

            foreach (var node in this.nodes)
            {
                Console.ForegroundColor = this.Color;
                Console.SetCursorPosition(node.X, node.Y);
                Console.WriteLine(this.Symbol);
            }
        }

        //public override void Move(MoveDirection direction, Func<Figure, bool> isFree) { }

        public void MoveLeft()
        {
            var oldX = 0;

            foreach (var node in this.nodes)
            {
                oldX = node.X;

                node.Left();
                this.DrawMyCar(node.X, this.startY);

                this.DrawMyCar(oldX, this.startY);
                Console.Write(" ");
            }
        }

        public void MoveRight()
        {
            var oldX = 0;
            
            foreach (var node in this.nodes)
            {
                oldX = node.X;

                node.Right();
                this.DrawMyCar(node.X, this.startY);

                Console.SetCursorPosition(oldX, this.startY);
                Console.Write(" ");
            }
        }
    }
}
