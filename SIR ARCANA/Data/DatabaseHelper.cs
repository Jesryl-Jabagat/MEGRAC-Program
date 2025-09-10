using System;
using System.Data.SQLite;
using System.IO;

namespace SIR_ARCANA.Data
{
    /// <summary>
    /// Database helper class for SQLite operations
    /// </summary>
    public static class DatabaseHelper
    {
        private static string _connectionString = string.Empty;
        private static readonly string _dbPath = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
            "InventoryManagement",
            "inventory.db"
        );

        /// <summary>
        /// Get the connection string for the database
        /// </summary>
        public static string ConnectionString
        {
            get
            {
                if (string.IsNullOrEmpty(_connectionString))
                {
                    // Ensure the directory exists
                    var directory = Path.GetDirectoryName(_dbPath);
                    if (!Directory.Exists(directory))
                    {
                        Directory.CreateDirectory(directory!);
                    }

                    _connectionString = $"Data Source={_dbPath};Version=3;";
                }
                return _connectionString;
            }
        }

        /// <summary>
        /// Initialize the database and create tables if they don't exist
        /// </summary>
        public static void InitializeDatabase()
        {
            try
            {
                using var connection = new SQLiteConnection(ConnectionString);
                connection.Open();

                // Create Users table
                var createUsersTable = @"
                    CREATE TABLE IF NOT EXISTS Users (
                        UserId INTEGER PRIMARY KEY AUTOINCREMENT,
                        Username TEXT UNIQUE NOT NULL,
                        PasswordHash TEXT NOT NULL,
                        Role TEXT NOT NULL CHECK (Role IN ('Admin', 'Employee')),
                        LastSynced DATETIME,
                        CreatedAt DATETIME DEFAULT CURRENT_TIMESTAMP
                    )";

                using var command = new SQLiteCommand(createUsersTable, connection);
                command.ExecuteNonQuery();

                // Insert default users if they don't exist
                InsertDefaultUsers(connection);

                Console.WriteLine("Database initialized successfully.");
            }
            catch (Exception ex)
            {
                throw new Exception($"Failed to initialize database: {ex.Message}", ex);
            }
        }

        /// <summary>
        /// Insert default users (admin and employee) if they don't exist
        /// </summary>
        private static void InsertDefaultUsers(SQLiteConnection connection)
        {
            // Check if users already exist
            var checkUsersCommand = new SQLiteCommand("SELECT COUNT(*) FROM Users", connection);
            var userCount = Convert.ToInt32(checkUsersCommand.ExecuteScalar());

            if (userCount == 0)
            {
                // Insert admin user
                var adminCommand = new SQLiteCommand(
                    "INSERT INTO Users (Username, PasswordHash, Role) VALUES (@username, @password, @role)",
                    connection);
                adminCommand.Parameters.AddWithValue("@username", "admin");
                adminCommand.Parameters.AddWithValue("@password", BCrypt.Net.BCrypt.HashPassword("admin123"));
                adminCommand.Parameters.AddWithValue("@role", "Admin");
                adminCommand.ExecuteNonQuery();

                // Insert employee user
                var employeeCommand = new SQLiteCommand(
                    "INSERT INTO Users (Username, PasswordHash, Role) VALUES (@username, @password, @role)",
                    connection);
                employeeCommand.Parameters.AddWithValue("@username", "employee");
                employeeCommand.Parameters.AddWithValue("@password", BCrypt.Net.BCrypt.HashPassword("emp123"));
                employeeCommand.Parameters.AddWithValue("@role", "Employee");
                employeeCommand.ExecuteNonQuery();

                Console.WriteLine("Default users created successfully.");
            }
        }

        /// <summary>
        /// Test database connection
        /// </summary>
        public static bool TestConnection()
        {
            try
            {
                using var connection = new SQLiteConnection(ConnectionString);
                connection.Open();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}


