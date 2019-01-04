using System.Collections.Generic;
using BusScheduleApp.Models;
using BusScheduleApp.Repositories;

namespace BusScheduleApp.Services
{
    class BusService
    {
        private IRepository<Bus> busRepository;

        public BusService()
        {
            busRepository = new BusRepository();
        }

        public List<Bus> GetAllBusSchedules()
        {
            return busRepository.GetAllBusSchedules();
        }

        public void AddNewBus(Bus bus)
        {
            busRepository.Create(bus);
        }

        public void DeleteAllBuses()
        {
            busRepository.DeleteAll();
        }
    }
}