namespace BusScheduleApp.Models
{
    public class Bus
    {
        public string BusNumber { get; set; }
        public string DepartingStation { get; set; }
        public string DestinationStation { get; set; }
        public string DepartingTime { get; set; }
        public string ArrivalTime { get; set; }
    }
}