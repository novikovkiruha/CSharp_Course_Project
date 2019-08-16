using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleRacing
{
    public class Field
    {
        public int Height { get; }

        public int Width { get; }

        public Field()
        {
            this.Height = 20;
            this.Width = 10;
            Console.SetWindowSize(40, 21);
            Console.SetBufferSize(40, 21);
        }
    }
}
