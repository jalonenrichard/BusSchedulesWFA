using System.Collections.Generic;
using BusScheduleApp.Models;
using BusScheduleApp.Repositories;

namespace BusScheduleApp.Services
{
    class BusService
    {
        private BusRepository busRepository;

        public BusService()
        {
            busRepository = new BusRepository();
        }

        public List<Bus> GetAllBusSchedules()
        {
            return busRepository.GetAllBusSchedules();
        }
    }
}