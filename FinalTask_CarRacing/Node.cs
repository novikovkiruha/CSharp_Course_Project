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
    }
}
