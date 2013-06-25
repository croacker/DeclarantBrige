using System.Data;
using com.asf.declarantbrige.service;
using System.Data.SqlServerCe;

namespace com.asf.declarantbrige.service {
    
    /// <summary>
    /// Сервис непосредственного выполнения запросов
    /// </summary>
    class SqlService:AbstractService
    {
        private SqlCeConnection connection = new SqlCeConnection();

        public static class Query {
            public static string GET_ALL_TABLE = "SELECT * FROM {0}";
        }

        /// <summary>
        /// Строка подключения к БД
        /// </summary>
        public string ConnectionString { 
            get { return connection.ConnectionString; }
            set { connection.ConnectionString = value; }
        }

        /// <summary>
        /// Подключение к БД
        /// </summary>
        /// <param name="forceReopen"></param>
        /// <returns></returns>
        private SqlCeConnection getConnection(bool forceReopen = false)
        {
            if (connection == null || forceReopen) {
                closeConnection(connection);
                connection = new SqlCeConnection(ConnectionString);
            }
            return connection;
        }

        /// <summary>
        /// Открыть соединение с БД
        /// </summary>
        /// <param name="forceReopen"></param>
        /// <returns></returns>
        public SqlCeConnection openConnection(bool forceReopen = false)
        {
            getConnection(forceReopen);
            connection.Open();
            return connection;
        }

        /// <summary>
        /// Закрыть соединение с БД
        /// </summary>
        private void closeConnection(SqlCeConnection connection)
        {
            if(connection != null &&
                connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }

        /// <summary>
        /// Закрыть соединение с БД
        /// </summary>
        private void closeConnection()
        {
            closeConnection(connection);
        }

        /// <summary>
        /// Создать объекь команда
        /// </summary>
        /// <param name="que"></param>
        /// <returns></returns>
        private SqlCeCommand getCommand(string que)
        {
            SqlCeCommand command = new SqlCeCommand(que, openConnection());
            return command;
        }

        /// <summary>
        /// Получить таблицу
        /// </summary>
        /// <param name="tableName"></param>
        /// <returns></returns>
        public DataTable getTable(string tableName)
        {
            SqlCeDataAdapter adapter = new SqlCeDataAdapter(getCommand(string.Format(Query.GET_ALL_TABLE, tableName)));
            DataTable table = new DataTable();
            adapter.Fill(table);
            closeConnection();
            return table;
        }

        /// <summary>
        /// Получить ридер
        /// </summary>
        /// <param name="que"></param>
        /// <returns></returns>
        public SqlCeDataReader getReader(string que)
        {
            SqlCeCommand command = getCommand(que);
            SqlCeDataReader reader = command.ExecuteReader();
            return reader;
        }

    }
}
