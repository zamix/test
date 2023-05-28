using System;

namespace MyApp
{
    public class DatabaseConfig
    {
        public static string ConnectionString = "Server=myServerAddress;Database=myDatabase;User Id=myUsername;Password=My$tr0ngP@ssw0rd;";
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            string connectionString = DatabaseConfig.ConnectionString;
            
            // Use the connection string for database operations
            
            Console.WriteLine("Sensitive information accessed.");
        }
    }
}

