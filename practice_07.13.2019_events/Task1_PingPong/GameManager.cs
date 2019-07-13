using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice_07._13._2019_events.Task1_PingPong
{
    public class GameManager
    {
        public Ping Ping { get; set; }

        public Pong Pong { get; set; }

        public GameManager(Ping ping, Pong pong)
        {
            this.Ping = ping;
            this.Pong = pong;

            this.Ping.NewPing += this.OnPingInvoked;
            this.Pong.NewPong += this.OnPongInvoked;

            this.Ping.PrintPing();
        }

        public void OnPingInvoked(object sender, EventArgs e)
        {
            this.Pong.PrintPong();
        }

        public void OnPongInvoked(object sender, EventArgs e)
        {
            this.Ping.PrintPing();
        }
    }
}
