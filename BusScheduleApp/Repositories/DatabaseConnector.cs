using System.Data.SQLite;

namespace BusScheduleApp.Repositories
{
    class DatabaseConnector
    {
        protected SQLiteConnection m_dbConnection;

        protected void OpenBusDbConnection()
        {
            m_dbConnection = new SQLiteConnection("Data Source=../../Databases/BusDatabase.sqlite;Version=3;");
            m_dbConnection.Open();
        }

        protected void CreateBusSchedulesTable()
        {
            string sql = "create table BusSchedules (id INT PRIMARY KEY ," +
                         "bus_number varchar(10)," +
                         "departing_station varchar(25)," +
                         "destination_station varchar(25)," +
                         "departing_time TEXT," +
                         "arrival_time TEXT)";
            SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
            command.ExecuteNonQuery();
        }

        protected void AddTestDataToBusDb()
        {
            string sql =
                "insert into BusSchedules (bus_number, departing_station, destination_station, departing_time, arrival_time) " +
                "values ('108', 'Vaana-Joesuu', 'Tallinn', '03/01/2019 08:00', '03/01/2019 08:30' )";
            SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
            command.ExecuteNonQuery();
        }

        protected void GetDataFromDb()
        {
            string sql = "select * from BusSchedules";
            SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string busNumber = reader["bus_number"].ToString();
                string depStat = reader["departing_station"].ToString();
                string depTime = reader["departing_time"].ToString();
            }
        }

        protected void CloseBusDbConnection()
        {
            m_dbConnection.Close();
        }
    }
}