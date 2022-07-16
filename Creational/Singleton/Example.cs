namespace Patterns.Creational.Singleton
{
    class Example
    {
        public void Example1()
        {
            DbConnectionSingleton connection = DbConnectionSingleton.getInstance("Connect to MsSql database#1");

            connection.CheckConnection();

            DbConnectionSingleton newConnection = DbConnectionSingleton.getInstance("Connect to PostgreSql database#2");

            newConnection.CheckConnection();
        }
    }
}
