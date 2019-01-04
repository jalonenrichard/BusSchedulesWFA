using System;
using System.Collections.Generic;
using System.Data;
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
            string sql = "SELECT * FROM BusSchedules ORDER BY departing_time";
            SQLiteCommand command = new SQLiteCommand(sql, MDbConnection);
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Bus bus = new Bus
                {
                    BusId = reader["bus_id"].ToString(),
                    BusNumber = reader["bus_number"].ToString(),
                    DepartingStation = reader["departing_station"].ToString(),
                    DestinationStation = reader["destination_station"].ToString(),
                    DepartingTime = DateTime.Parse(reader["departing_time"].ToString()),
                    ArrivalTime = DateTime.Parse(reader["arrival_time"].ToString())
                };
                busScheduleList.Add(bus);
            }

            CloseBusDbConnection();
            return busScheduleList;
        }

        public void Create(Bus bus)
        {
            string sql =
                "INSERT INTO BusSchedules (bus_number, departing_station, destination_station, departing_time, arrival_time) " +
                "VALUES (@param1, @param2, @param3, @param4, @param5 )";
            OpenBusDbConnection();
            SQLiteCommand command = new SQLiteCommand(sql, MDbConnection)
            {
                CommandText = sql, CommandType = CommandType.Text
            };
            command.Parameters.Add(new SQLiteParameter("@param1", bus.BusNumber));
            command.Parameters.Add(new SQLiteParameter("@param2", bus.DepartingStation));
            command.Parameters.Add(new SQLiteParameter("@param3", bus.DestinationStation));
            command.Parameters.Add(new SQLiteParameter("@param4", bus.DepartingTime));
            command.Parameters.Add(new SQLiteParameter("@param5", bus.ArrivalTime));
            command.ExecuteNonQuery();
            CloseBusDbConnection();
        }

        public void Delete(Bus bus)
        {
            string sql =
                "delete from BusSchedules " +
                "where bus_id = @param1 ";
            OpenBusDbConnection();
            SQLiteCommand command = new SQLiteCommand(sql, MDbConnection)
            {
                CommandText = sql, CommandType = CommandType.Text
            };
            command.Parameters.Add(new SQLiteParameter("@param1", bus.BusId));
            command.ExecuteNonQuery();
            CloseBusDbConnection();
        }

        public void DeleteAll()
        {
            string sql = "DELETE FROM BusSchedules WHERE 1=1";
            OpenBusDbConnection();
            SQLiteCommand command = new SQLiteCommand(sql, MDbConnection);
            command.ExecuteNonQuery();
            CloseBusDbConnection();
        }
    }
}