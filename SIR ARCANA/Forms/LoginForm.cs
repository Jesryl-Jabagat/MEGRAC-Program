using System;
using System.Windows.Forms;
using SIR_ARCANA.Repositories;

namespace SIR_ARCANA.Forms
{
    /// <summary>
    /// Login form for user authentication
    /// </summary>
    public partial class LoginForm : Form
    {
        private readonly UserRepository _userRepository;

        public LoginForm()
        {
            _userRepository = new UserRepository();
            InitializeComponent();
        }

        private void LoginButton_Click(object? sender, EventArgs e)
        {
            PerformLogin();
        }

        private void PasswordTextBox_KeyPress(object? sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                PerformLogin();
            }
        }

        private void UsernameTextBox_KeyPress(object? sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                passwordTextBox.Focus();
            }
        }

        private void PerformLogin()
        {
            try
            {
                // Clear previous error
                errorLabel.Visible = false;

                // Validate input
                if (string.IsNullOrWhiteSpace(usernameTextBox.Text))
                {
                    ShowError("Please enter username");
                    usernameTextBox.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(passwordTextBox.Text))
                {
                    ShowError("Please enter password");
                    passwordTextBox.Focus();
                    return;
                }

                // Authenticate user
                Models.User? user = null;
                
                if (skipDatabaseCheckBox.Checked)
                {
                    // Mock authentication for testing
                    user = GetMockUser(usernameTextBox.Text.Trim(), passwordTextBox.Text);
                }
                else
                {
                    // Real database authentication
                    user = _userRepository.AuthenticateUser(usernameTextBox.Text.Trim(), passwordTextBox.Text);
                }

                if (user != null)
                {
                    // Hide login form
                    this.Hide();

                    // Check if user is admin - skip Money Manager for admins
                    if (user.IsAdmin)
                    {
                        // Admin goes directly to dashboard
                        var adminDashboard = new AdminDashboard(user);
                        adminDashboard.ShowDialog();
                    }
                    else
                    {
                        // Employees must go through Money Manager
                        var moneyManager = new MoneyManager(user);
                        var moneyResult = moneyManager.ShowDialog();

                        if (moneyResult == DialogResult.OK)
                        {
                            // User confirmed money amount, proceed to employee dashboard
                            var employeeDashboard = new EmployeeDashboard(user);
                            employeeDashboard.ShowDialog();
                        }
                        else if (moneyResult == DialogResult.Cancel)
                        {
                            // User cancelled, return to login screen
                            this.Show();
                            usernameTextBox.Clear();
                            passwordTextBox.Clear();
                            usernameTextBox.Focus();
                            return;
                        }
                    }

                    // Close login form when dashboard closes
                    this.Close();
                }
                else
                {
                    ShowError("Invalid username or password");
                    passwordTextBox.Clear();
                    passwordTextBox.Focus();
                }
            }
            catch (Exception ex)
            {
                ShowError($"Login error: {ex.Message}");
            }
        }

        private void ShowError(string message)
        {
            errorLabel.Text = message;
            errorLabel.Visible = true;
        }

        /// <summary>
        /// Mock authentication for testing without database
        /// </summary>
        private Models.User? GetMockUser(string username, string password)
        {
            // Mock users for testing
            if (username == "admin" && password == "admin123")
            {
                return new Models.User
                {
                    UserId = 1,
                    Username = "admin",
                    PasswordHash = "mock_hash",
                    Role = "Admin",
                    CreatedAt = DateTime.Now
                };
            }
            else if (username == "employee" && password == "emp123")
            {
                return new Models.User
                {
                    UserId = 2,
                    Username = "employee",
                    PasswordHash = "mock_hash",
                    Role = "Employee",
                    CreatedAt = DateTime.Now
                };
            }
            else if (username == "test" && password == "test")
            {
                return new Models.User
                {
                    UserId = 3,
                    Username = "test",
                    PasswordHash = "mock_hash",
                    Role = "Employee",
                    CreatedAt = DateTime.Now
                };
            }
            else if (username == "Jesryl" && password == "emp123")
            {
                return new Models.User
                {
                    UserId = 4,
                    Username = "Jesryl",
                    PasswordHash = "mock_hash",
                    Role = "Employee",
                    CreatedAt = DateTime.Now
                };
            }

            return null;
        }

        private void titleLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
