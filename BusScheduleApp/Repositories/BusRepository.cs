using System;
using System.Collections.Generic;
using System.Data.SQLite;
using BusScheduleApp.Models;

namespace BusScheduleApp.Repositories
{
    class BusRepository : DatabaseConnector, IRepository<Bus>
    {
        public List<Bus> GetAllBusSchedules()
        {
            List<Bus> busScheduleList = new List<Bus>();

            OpenBusDbConnection();
            string sql = "select * from BusSchedules";
            SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Bus bus = new Bus();
                bus.BusNumber = reader["bus_number"].ToString();
                bus.DepartingStation = reader["departing_station"].ToString();
                bus.DestinationStation = reader["destination_station"].ToString();
                DateTime depDate = DateTime.ParseExact(reader["departing_time"].ToString(), "dd/MM/yyyy HH:mm",
                    System.Globalization.CultureInfo.InvariantCulture);
                bus.DepartingTime = depDate;
                DateTime arrDate = DateTime.ParseExact(reader["arrival_time"].ToString(), "dd/MM/yyyy HH:mm",
                    System.Globalization.CultureInfo.InvariantCulture);
                bus.ArrivalTime = arrDate;
                busScheduleList.Add(bus);
            }

            CloseBusDbConnection();
            return busScheduleList;
        }

        public Bus GetBusByBusNumber(string busNumber)
        {
            throw new System.NotImplementedException();
        }


        public void Create(Bus bus)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(Bus bus)
        {
            throw new System.NotImplementedException();
        }

        public void Update(Bus bus)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteAll()
        {
            throw new System.NotImplementedException();
        }
    }
}