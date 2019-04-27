using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Course_Project.Task1
{
    class TrainScheduler
    {
        private const int TrainMaxNumbers = 2;

        private Train[] trainList;

        public TrainScheduler()
        {
            this.trainList = new Train[TrainScheduler.TrainMaxNumbers];
        }

        public void Execute()
        {
            for (int i = 0; i < TrainScheduler.TrainMaxNumbers; i++)
                this.trainList[i] = this.GetNewTrain();

            int selectedTrainNumber = this.AskTrainNumber();

            this.DisplayTrainInfo(selectedTrainNumber);
        }

        private int AskTrainNumber()
        {
            int trainNumber = 0;
            while (true)
            {
                Console.WriteLine("Please, enter the train number that you want to find:");
                if (Int32.TryParse(Console.ReadLine(), out trainNumber))
                    break;
            }

            return trainNumber;
        }

        private void DisplayTrainInfo(int trainNumber)
        {
            Train selectedTrain = new Train();
            for (int i = 0; i < TrainScheduler.TrainMaxNumbers; i++)
            {
                int selectedTrainNumber = this.trainList[i].GetTrainNumber();
                if (selectedTrainNumber == trainNumber)
                    selectedTrain = this.trainList[i];
            }
            
            if (selectedTrain.GetTrainNumber() == 0)
            {
                Console.WriteLine($"Train number {trainNumber} was not found on the list of trains");
                return;
            }

            Console.WriteLine($"Train {trainNumber} is departuring to {selectedTrain.GetDestination()} at {selectedTrain.GetDepartureTime()}");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private Train GetNewTrain() // пользовательский возвращаемый тип
        {
            int trainNumber = 0;
            while (true)
            {
                Console.WriteLine("Enter the train numbers: ");

                if (Int32.TryParse(Console.ReadLine(), out trainNumber))
                    break;
            }

            DateTime departureTime;
            while (true)
            {
                Console.WriteLine("Enter the departure time of a train: ");

                if (DateTime.TryParse(Console.ReadLine(), out departureTime))
                    break;
            }

            string destinationName = string.Empty;
            while (true)
            {
                Console.WriteLine("Enter the final destination: ");

                destinationName = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(destinationName))
                    break;
            }

            return new Train(destinationName, trainNumber, departureTime);
        }
    }
}
