using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabInvoiceGenerator
{
    public class InvoiceGenerator    {
        public double Distance;
        public int Time;
        public double[] Ride;
        public double TotalFare;
        public double AvgFare;
        public int NoOfRide;
        private readonly double CostPerKilometer;
        private readonly int CostPerTime;
        private readonly double MinimumFare;

        public InvoiceGenerator()
        {
            CostPerKilometer = 10;
            CostPerTime = 1;
            MinimumFare = 5;
        }
        public double CalculateFare(double Distance, int Time)
        {
            TotalFare = 0;
            TotalFare = (Distance * CostPerKilometer) + (CostPerTime * Time);
            return TotalFare;
        }
        public double CalculateFare(MultipleRides[] ride)
        {
            double totalfare = 0;
            foreach (MultipleRides rides in ride)
            {
                Console.WriteLine(totalfare);
                totalfare = totalfare + CalculateFare(rides.distance, rides.time);
                Console.WriteLine(totalfare);
            }
            
            return totalfare;
        }
    }
}
