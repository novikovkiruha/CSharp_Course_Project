using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice_07._13._2019_events.Task1_PingPong.Task1._1_CustomDelegate
{
    public class PingPongEventArgs : EventArgs
    {
        public delegate void PingPongDelegate(object sender, PingPongEventArgs e);

        public string Ping { get; }

        public string Pong { get; }

        public PingPongEventArgs()
        {
            this.Ping = "Ping";
            this.Pong = "Pong";
        }
    }
}
