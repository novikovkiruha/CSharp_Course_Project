using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice_07._13._2019_events.Task1_PingPong.Task1._1_CustomDelegate
{
    public class GameManagerCustomDelegate
    {
        public PingCustomDelegate Ping { get; set; }

        public PongCustomDelegate Pong { get; set; }

        public GameManagerCustomDelegate(PingCustomDelegate ping, PongCustomDelegate pong)
        {
            this.Ping = ping;
            this.Pong = pong;

            this.Ping.NewPing += this.OnPingInvoked;
            this.Pong.NewPong += this.OnPongInvoked;

            this.Ping.DoPing();
        }

        public void OnPingInvoked(object sender, EventArgs e)
        {
            this.Pong.DoPong();
        }

        public void OnPongInvoked(object sender, EventArgs e)
        {
            this.Ping.DoPing();
        }
    }
}
