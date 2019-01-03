using System;

namespace BusScheduleApp.Models
{
    internal class Bus
    {
        public string BusNumber { get; set; }
        public string DepartingStation { get; set; }
        public string DestinationStation { get; set; }
        public DateTime DepartingTime { get; set; }
        public DateTime ArrivalTime { get; set; }
    }
}