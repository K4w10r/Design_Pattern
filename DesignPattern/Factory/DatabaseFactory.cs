namespace DesignPattern.Factory
{
    public static class DatabaseFactory
    {
        //public static IDatabase CreateDatabase(...)
        //{
        //  ...
        //}

        public static IDatabase CreateDatabase(DatabaseType type)
        {
            if (type == DatabaseType.Oracle) return new OracleDatabase();
            return new SqlServerDatabase();
            
        }
    }
}
