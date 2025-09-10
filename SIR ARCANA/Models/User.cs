using System;

namespace SIR_ARCANA.Models
{
    /// <summary>
    /// User model representing a user in the system
    /// </summary>
    public class User
    {
        public int UserId { get; set; }
        public string Username { get; set; } = string.Empty;
        public string PasswordHash { get; set; } = string.Empty;
        public string Role { get; set; } = string.Empty;
        public DateTime? LastSynced { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        /// <summary>
        /// Check if user is an admin
        /// </summary>
        public bool IsAdmin => Role.Equals("Admin", StringComparison.OrdinalIgnoreCase);

        /// <summary>
        /// Check if user is an employee
        /// </summary>
        public bool IsEmployee => Role.Equals("Employee", StringComparison.OrdinalIgnoreCase);
    }
}


