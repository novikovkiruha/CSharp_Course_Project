using System;

namespace CSharp_Course_Project.Task1
{
    public struct Train
    {
        private string destinationName;

        private int trainNumber;

        private DateTime departureTime;

        public Train(string destinationName, int trainNumber, DateTime departureTime)
        {
            if (trainNumber == 0)
                throw new ArgumentException(nameof(trainNumber));

            if (string.IsNullOrWhiteSpace(destinationName))
                throw new ArgumentException(nameof(destinationName));

            this.destinationName = destinationName;
            this.trainNumber = trainNumber;
            this.departureTime = departureTime;
        }

        public int GetTrainNumber() => this.trainNumber;

        public string GetDestination() => this.destinationName;

        public DateTime GetDepartureTime() => this.departureTime;
    }
}
