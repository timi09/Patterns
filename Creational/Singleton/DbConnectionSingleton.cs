namespace Patterns.Creational.Singleton
{
    class DbConnectionSingleton
    {
        private static DbConnectionSingleton? _instance;

        private string _connection;
        private DbConnectionSingleton(string connection)
        {
            _connection = connection;
        }

        public static DbConnectionSingleton getInstance(string connection) 
        {
            if (_instance == null)
                _instance = new DbConnectionSingleton(connection);
            return _instance;
        }

        public void CheckConnection() 
        {
            Console.WriteLine(_connection);
        }
    }
}
