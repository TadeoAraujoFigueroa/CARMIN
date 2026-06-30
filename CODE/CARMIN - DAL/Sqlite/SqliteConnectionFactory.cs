using CARMIN___DAL.Configuration;
using Microsoft.Data.Sqlite;

namespace CARMIN___DAL.Sqlite
{
    public class SqliteConnectionFactory
    {
        public SqliteConnection Create()
        {
            return new SqliteConnection(SqliteConfiguration.GetConnectionString());
        }
    }
}
