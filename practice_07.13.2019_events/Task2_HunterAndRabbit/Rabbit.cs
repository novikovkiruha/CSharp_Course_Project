using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace practice_07._13._2019_events.Task2_HunterAndRabbit
{
    public class Rabbit
    {
        public delegate void LocationDelegate(object sender, CoordinatesEventArgs args);

        public event LocationDelegate EventNewLocation;

        public int FirstCoordinate { get; set; }

        public int SecondCoordinate { get; set; }

        public void ChangeLocation()
        {
            var random = new Random();

            while (true)
            {
                this.FirstCoordinate = random.Next();
                this.SecondCoordinate = random.Next();
                this.OnEventNewLocation(new CoordinatesEventArgs(this.FirstCoordinate, this.SecondCoordinate));
                Thread.Sleep(2000);
            }
        }

        protected virtual void OnEventNewLocation(CoordinatesEventArgs e)
        {
            this.EventNewLocation?.Invoke(this, e);
        }
    }
}
