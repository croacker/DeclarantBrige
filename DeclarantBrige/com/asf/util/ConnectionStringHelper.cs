namespace com.asf.util {

    /// <summary>
    /// Построитель строки соединения
    /// </summary>
    class ConnectionStringHelper {

        public static class ConnectionPatterns
        {
            public const string SQL_CE = "Data Source={0};Password='{1}';";
            public const string SQL_CE_SHORT = "Data Source={0}";
        }
        
        public static string getSqlCe(string dbFile)
        {
            return string.Format(ConnectionPatterns.SQL_CE_SHORT, dbFile);
        }

        public static string getSqlCe(string dbFile, string dbPassword) {
            return string.Format(ConnectionPatterns.SQL_CE, dbFile, dbPassword);
        }
    }
}
