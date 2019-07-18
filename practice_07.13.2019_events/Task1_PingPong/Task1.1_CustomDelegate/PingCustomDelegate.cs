using System;
using System.Threading;
using static practice_07._13._2019_events.Task1_PingPong.Task1._1_CustomDelegate.PingPongEventArgs;

namespace practice_07._13._2019_events.Task1_PingPong.Task1._1_CustomDelegate
{
    public class PingCustomDelegate
    {
        public event PingPongDelegate NewPing;

        protected virtual void OnNewPing(PingPongEventArgs e)
        {
            this.NewPing?.Invoke(this, e);
        }

        public void DoPing()
        {
            Console.WriteLine("Ping...");
            Thread.Sleep(1000);
            this.OnNewPing(new PingPongEventArgs());
        }
    }
}
