using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace practice_07._13._2019_events.Task1_PingPong
{
    public class Ping
    {
        public event EventHandler NewPing;

        protected virtual void OnNewPing(EventArgs e)
        {
            //if (NewPing != null)
            //    NewPing(this, e);
            this.NewPing?.Invoke(this, e);
        }

        public void PrintPing()
        {
            Console.WriteLine("Ping...");
            Thread.Sleep(1000);
            this.OnNewPing(new EventArgs());
        }
    }
}
