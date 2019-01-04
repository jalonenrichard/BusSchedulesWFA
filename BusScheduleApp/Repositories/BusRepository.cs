﻿using System.Collections.Generic;
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
            string sql = "select * from BusSchedules";
            SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Bus bus = new Bus();
                bus.BusNumber = reader["bus_number"].ToString();
                bus.DepartingStation = reader["departing_station"].ToString();
                bus.DestinationStation = reader["destination_station"].ToString();
                /*DateTime depDate = DateTime.ParseExact(reader["departing_time"].ToString(), "dd.MM.yyyy HH:mm:ss",
                    System.Globalization.CultureInfo.InvariantCulture);*/
                bus.DepartingTime = reader["departing_time"].ToString();
                /*DateTime arrDate = DateTime.ParseExact(reader["arrival_time"].ToString(), "dd.MM.yyyy HH:mm:ss",
                    System.Globalization.CultureInfo.InvariantCulture);*/
                bus.ArrivalTime = reader["arrival_time"].ToString();
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
            string sql =
                "insert into BusSchedules (bus_number, departing_station, destination_station, departing_time, arrival_time) " +
                "values (@param1, @param2, @param3, @param4, @param5 )";
            OpenBusDbConnection();
            SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
            command.CommandText = sql;
            command.CommandType = CommandType.Text;
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
            throw new System.NotImplementedException();
        }

        public void Update(Bus bus)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteAll()
        {
            string sql = "delete from BusSchedules where 1=1";
            OpenBusDbConnection();
            SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
            command.ExecuteNonQuery();
            CloseBusDbConnection();
        }
    }
}