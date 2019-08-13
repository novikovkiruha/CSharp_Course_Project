using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTask_CarRacing
{
    public class Node
    {
        private int x;

        private int y;

        public Node(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public void Up()
        {
            this.y++;
        }

        public void Down()
        {
            this.y--;
        }

        public void Left()
        {
            this.x++;
        }

        public void Right()
        {
            this.x--;
        }

        public int X
        {
            get
            {
                return this.x;
            }
            set
            {
                if (value == 0)
                    throw new NullReferenceException("Please, fill X coordinate");
                else
                    this.x = value;
            }
        }

        public int Y
        {
            get
            {
                return this.y;
            }
            set
            {
                if (value == 0)
                    throw new NullReferenceException("Please, fill Y coordinate");
                else
                    this.x = value;
            }
        }
    }
}
