using System;
using System.Threading;
using static practice_07._13._2019_events.Task1_PingPong.Task1._1_CustomDelegate.PingPongEventArgs;

namespace practice_07._13._2019_events.Task1_PingPong.Task1._1_CustomDelegate
{
    public class PongCustomDelegate
    {
        public event PingPongDelegate NewPong;

        protected virtual void OnNewPong(PingPongEventArgs e)
        {
            this.NewPong?.Invoke(this, e);
        }

        public void DoPong()
        {
            Console.WriteLine("Ping...");
            Thread.Sleep(1000);
            this.OnNewPong(new PingPongEventArgs());
        }
    }
}
