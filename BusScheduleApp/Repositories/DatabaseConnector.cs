using System.Data.SQLite;

namespace BusScheduleApp.Repositories
{
    class DatabaseConnector
    {
        protected SQLiteConnection MDbConnection;

        protected void OpenBusDbConnection()
        {
            MDbConnection = new SQLiteConnection("Data Source=../../Databases/BusDatabase.sqlite;Version=3;");
            MDbConnection.Open();
        }

        protected void CloseBusDbConnection()
        {
            MDbConnection.Close();
        }
    }
}