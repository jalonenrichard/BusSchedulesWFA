using System.Collections.Generic;

namespace BusScheduleApp.Repositories
{
    interface IRepository<T>
    {
        T GetBusByBusNumber(string busNumber);
        List<T> GetAllBusSchedules();
        void Create(T bus);
        void Delete(T bus);
        void Update(T bus);
        void DeleteAll();
    }
}