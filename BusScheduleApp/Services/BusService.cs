using System.Collections.Generic;
using BusScheduleApp.Models;
using BusScheduleApp.Repositories;

namespace BusScheduleApp.Services
{
    class BusService
    {
        private readonly IRepository<Bus> _busRepository;

        public BusService()
        {
            _busRepository = new BusRepository();
        }

        public List<Bus> GetAllBusSchedules()
        {
            return _busRepository.GetAllBusSchedules();
        }

        public void AddNewBus(Bus bus)
        {
            _busRepository.Create(bus);
        }

        public void DeleteAllBuses()
        {
            _busRepository.DeleteAll();
        }

        public void DeleteBus(Bus bus)
        {
            _busRepository.Delete(bus);
        }
    }
}