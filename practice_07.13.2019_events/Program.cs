using practice_07._13._2019_events.Task1_PingPong;
using practice_07._13._2019_events.Task1_PingPong.Task1._1_CustomDelegate;
using practice_07._13._2019_events.Task2_HunterAndRabbit;
using practice_07._13._2019_events.Task3_IDisposable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice_07._13._2019_events
{
    class Program
    {
        static void Main(string[] args)
        {
            //new GameManager(new Ping(), new Pong());
            //new GameManager(new Ping(), new Pong());
            new Hunting(new Hunter(), new Rabbit());
            //new FileSystem("some text").CreateFile(@"D:\temp.txt");
        }
    }
}
