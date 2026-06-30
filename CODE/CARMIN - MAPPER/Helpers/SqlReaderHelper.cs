using Microsoft.Data.Sqlite;

namespace CARMIN___MAPPER.Helpers
{
    public static class SqlReaderHelper
    {
        public static string GetString(SqliteDataReader reader, string columnName)
        {
            return reader.GetString(reader.GetOrdinal(columnName));
        }

        public static string? GetNullableString(SqliteDataReader reader, string columnName)
        {
            var ordinal = reader.GetOrdinal(columnName);
            return reader.IsDBNull(ordinal) ? null : reader.GetString(ordinal);
        }

        public static int GetInt32(SqliteDataReader reader, string columnName)
        {
            return reader.GetInt32(reader.GetOrdinal(columnName));
        }

        public static int? GetNullableInt32(SqliteDataReader reader, string columnName)
        {
            var ordinal = reader.GetOrdinal(columnName);
            return reader.IsDBNull(ordinal) ? null : reader.GetInt32(ordinal);
        }

        public static decimal GetDecimal(SqliteDataReader reader, string columnName)
        {
            return reader.GetDecimal(reader.GetOrdinal(columnName));
        }

        public static decimal? GetNullableDecimal(SqliteDataReader reader, string columnName)
        {
            var ordinal = reader.GetOrdinal(columnName);
            return reader.IsDBNull(ordinal) ? null : reader.GetDecimal(ordinal);
        }

        public static bool GetBoolean(SqliteDataReader reader, string columnName)
        {
            return reader.GetBoolean(reader.GetOrdinal(columnName));
        }

        public static bool? GetNullableBoolean(SqliteDataReader reader, string columnName)
        {
            var ordinal = reader.GetOrdinal(columnName);
            return reader.IsDBNull(ordinal) ? null : reader.GetBoolean(ordinal);
        }

        public static DateTime GetDateTime(SqliteDataReader reader, string columnName)
        {
            return reader.GetDateTime(reader.GetOrdinal(columnName));
        }
    }
}
