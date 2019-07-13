using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace practice_07._13._2019_events.Task1_PingPong
{
    public class Pong
    {
        public event EventHandler NewPong;

        protected virtual void OnNewPong(EventArgs e)
        {
            //if (NewPong != null)
            //    NewPong(this, e);
            this.NewPong?.Invoke(this, e);
        }

        public void PrintPong()
        {
            Console.WriteLine("Pong...");
            Thread.Sleep(1000);
            this.OnNewPong(new EventArgs());
        }
    }
}
