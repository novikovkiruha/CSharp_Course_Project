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
            this.InitializeState(startX, startY);
            foreach (var node in this.nodes)
            {
                Console.SetCursorPosition(node.X, node.Y);
                Console.WriteLine(this.Symbol);
            }
        }

        //public override void Move(MoveDirection direction, Func<Figure, bool> isFree) { }
        public void MoveUp()
        {
            foreach (var node in this.nodes)
            {
                node.Up();
                this.DrawMyCar(node.X, node.Y);
            }
        }

        public void MoveDown()
        {
            foreach (var node in this.nodes)
            {
                node.Down();
                this.DrawMyCar(node.X, node.Y);
            }
        }

        public void MoveLeft()
        {
            foreach (var node in this.nodes)
            {
                node.Left();
                this.DrawMyCar(node.X, node.Y);
            }
        }

        public void MoveRight()
        {
            foreach (var node in this.nodes)
            {
                node.Right();
                this.DrawMyCar(node.X, node.Y);
            }
        }
    }
}
