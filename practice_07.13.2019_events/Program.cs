using practice_07._13._2019_events.Task1_PingPong;
using practice_07._13._2019_events.Task2_HunterAndRabbit;
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
            new Hunting(new Hunter(), new Rabbit());
        }
    }
}
