using System;
using System.Collections.Generic;
using System.Data.SQLite;
using SIR_ARCANA.Models;

namespace SIR_ARCANA.Repositories
{
    /// <summary>
    /// Repository class for User CRUD operations
    /// </summary>
    public class UserRepository
    {
        /// <summary>
        /// Authenticate user with username and password
        /// </summary>
        /// <param name="username">Username</param>
        /// <param name="password">Plain text password</param>
        /// <returns>User object if authentication successful, null otherwise</returns>
        public User? AuthenticateUser(string username, string password)
        {
            try
            {
                using var connection = new SQLiteConnection(Data.DatabaseHelper.ConnectionString);
                connection.Open();

                var command = new SQLiteCommand(
                    "SELECT UserId, Username, PasswordHash, Role, LastSynced, CreatedAt FROM Users WHERE Username = @username",
                    connection);
                command.Parameters.AddWithValue("@username", username);

                using var reader = command.ExecuteReader();
                if (reader.Read())
                {
                    var user = new User
                    {
                        UserId = reader.GetInt32(0),
                        Username = reader.GetString(1),
                        PasswordHash = reader.GetString(2),
                        Role = reader.GetString(3),
                        LastSynced = reader.IsDBNull(4) ? null : reader.GetDateTime(4),
                        CreatedAt = reader.GetDateTime(5)
                    };

                    // Verify password
                    if (BCrypt.Net.BCrypt.Verify(password, user.PasswordHash))
                    {
                        return user;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Authentication failed: {ex.Message}", ex);
            }

            return null;
        }

        /// <summary>
        /// Get all users
        /// </summary>
        /// <returns>List of all users</returns>
        public List<User> GetAllUsers()
        {
            var users = new List<User>();

            try
            {
                using var connection = new SQLiteConnection(Data.DatabaseHelper.ConnectionString);
                connection.Open();

                var command = new SQLiteCommand(
                    "SELECT UserId, Username, PasswordHash, Role, LastSynced, CreatedAt FROM Users ORDER BY CreatedAt DESC",
                    connection);

                using var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    users.Add(new User
                    {
                        UserId = reader.GetInt32(0),
                        Username = reader.GetString(1),
                        PasswordHash = reader.GetString(2),
                        Role = reader.GetString(3),
                        LastSynced = reader.IsDBNull(4) ? null : reader.GetDateTime(4),
                        CreatedAt = reader.GetDateTime(5)
                    });
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Failed to retrieve users: {ex.Message}", ex);
            }

            return users;
        }

        /// <summary>
        /// Get user by ID
        /// </summary>
        /// <param name="userId">User ID</param>
        /// <returns>User object or null if not found</returns>
        public User? GetUserById(int userId)
        {
            try
            {
                using var connection = new SQLiteConnection(Data.DatabaseHelper.ConnectionString);
                connection.Open();

                var command = new SQLiteCommand(
                    "SELECT UserId, Username, PasswordHash, Role, LastSynced, CreatedAt FROM Users WHERE UserId = @userId",
                    connection);
                command.Parameters.AddWithValue("@userId", userId);

                using var reader = command.ExecuteReader();
                if (reader.Read())
                {
                    return new User
                    {
                        UserId = reader.GetInt32(0),
                        Username = reader.GetString(1),
                        PasswordHash = reader.GetString(2),
                        Role = reader.GetString(3),
                        LastSynced = reader.IsDBNull(4) ? null : reader.GetDateTime(4),
                        CreatedAt = reader.GetDateTime(5)
                    };
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Failed to retrieve user: {ex.Message}", ex);
            }

            return null;
        }

        /// <summary>
        /// Add a new user
        /// </summary>
        /// <param name="user">User object to add</param>
        /// <param name="password">Plain text password</param>
        /// <returns>True if successful</returns>
        public bool AddUser(User user, string password)
        {
            try
            {
                using var connection = new SQLiteConnection(Data.DatabaseHelper.ConnectionString);
                connection.Open();

                var command = new SQLiteCommand(
                    "INSERT INTO Users (Username, PasswordHash, Role, LastSynced) VALUES (@username, @passwordHash, @role, @lastSynced)",
                    connection);
                command.Parameters.AddWithValue("@username", user.Username);
                command.Parameters.AddWithValue("@passwordHash", BCrypt.Net.BCrypt.HashPassword(password));
                command.Parameters.AddWithValue("@role", user.Role);
                command.Parameters.AddWithValue("@lastSynced", user.LastSynced ?? (object)DBNull.Value);

                return command.ExecuteNonQuery() > 0;
            }
            catch (Exception ex)
            {
                throw new Exception($"Failed to add user: {ex.Message}", ex);
            }
        }

        /// <summary>
        /// Update an existing user
        /// </summary>
        /// <param name="user">User object to update</param>
        /// <param name="newPassword">New password (optional, null to keep existing)</param>
        /// <returns>True if successful</returns>
        public bool UpdateUser(User user, string? newPassword = null)
        {
            try
            {
                using var connection = new SQLiteConnection(Data.DatabaseHelper.ConnectionString);
                connection.Open();

                string updateQuery = "UPDATE Users SET Username = @username, Role = @role, LastSynced = @lastSynced";
                if (!string.IsNullOrEmpty(newPassword))
                {
                    updateQuery += ", PasswordHash = @passwordHash";
                }
                updateQuery += " WHERE UserId = @userId";

                var command = new SQLiteCommand(updateQuery, connection);
                command.Parameters.AddWithValue("@username", user.Username);
                command.Parameters.AddWithValue("@role", user.Role);
                command.Parameters.AddWithValue("@lastSynced", user.LastSynced ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@userId", user.UserId);

                if (!string.IsNullOrEmpty(newPassword))
                {
                    command.Parameters.AddWithValue("@passwordHash", BCrypt.Net.BCrypt.HashPassword(newPassword));
                }

                return command.ExecuteNonQuery() > 0;
            }
            catch (Exception ex)
            {
                throw new Exception($"Failed to update user: {ex.Message}", ex);
            }
        }

        /// <summary>
        /// Delete a user
        /// </summary>
        /// <param name="userId">User ID to delete</param>
        /// <returns>True if successful</returns>
        public bool DeleteUser(int userId)
        {
            try
            {
                using var connection = new SQLiteConnection(Data.DatabaseHelper.ConnectionString);
                connection.Open();

                var command = new SQLiteCommand("DELETE FROM Users WHERE UserId = @userId", connection);
                command.Parameters.AddWithValue("@userId", userId);

                return command.ExecuteNonQuery() > 0;
            }
            catch (Exception ex)
            {
                throw new Exception($"Failed to delete user: {ex.Message}", ex);
            }
        }

        /// <summary>
        /// Check if username already exists
        /// </summary>
        /// <param name="username">Username to check</param>
        /// <param name="excludeUserId">User ID to exclude from check (for updates)</param>
        /// <returns>True if username exists</returns>
        public bool UsernameExists(string username, int? excludeUserId = null)
        {
            try
            {
                using var connection = new SQLiteConnection(Data.DatabaseHelper.ConnectionString);
                connection.Open();

                string query = "SELECT COUNT(*) FROM Users WHERE Username = @username";
                if (excludeUserId.HasValue)
                {
                    query += " AND UserId != @excludeUserId";
                }

                var command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@username", username);
                if (excludeUserId.HasValue)
                {
                    command.Parameters.AddWithValue("@excludeUserId", excludeUserId.Value);
                }

                return Convert.ToInt32(command.ExecuteScalar()) > 0;
            }
            catch (Exception ex)
            {
                throw new Exception($"Failed to check username: {ex.Message}", ex);
            }
        }
    }
}
