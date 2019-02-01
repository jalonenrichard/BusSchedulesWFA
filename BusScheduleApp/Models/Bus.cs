using System;

namespace BusScheduleApp.Models
{
    public class Bus
    {
        public string BusId { get; set; }
        public string BusNumber { get; set; }
        public string DepartingStation { get; set; }
        public string DestinationStation { get; set; }
        public DateTime DepartingTime { get; set; }
        public DateTime ArrivalTime { get; set; }

        public override string ToString()
        {
            return $"[{BusId}, {BusNumber}]";
        }
    }
}