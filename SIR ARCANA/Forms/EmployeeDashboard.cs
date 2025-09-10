using System;
using System.Drawing;
using System.Windows.Forms;
using SIR_ARCANA.Models;

namespace SIR_ARCANA.Forms
{
    /// <summary>
    /// Employee dashboard with limited access
    /// </summary>
    public partial class EmployeeDashboard : Form
    {
        private readonly User _currentUser;

        public EmployeeDashboard(User currentUser)
        {
            _currentUser = currentUser ?? throw new ArgumentNullException(nameof(currentUser));
            InitializeComponent();
            UpdateHeader();
            var timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000;
            timer.Tick += (s, e) => UpdateHeader();
            timer.Start();
        }

        /* obsolete */ private void InitializeComponent_Old()
        {
            // Form properties
            this.Text = "Inventory Management System - Employee Dashboard";
            this.Size = new Size(600, 400);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.BackColor = Color.White;

            // Header panel
            var headerPanel = this.Controls.OfType<Panel>().FirstOrDefault(p => p.Name == "headerPanel") ?? new Panel
            {
                Size = new Size(580, 80),
                Location = new Point(10, 10),
                BackColor = Color.LightBlue,
                BorderStyle = BorderStyle.FixedSingle
            };

            // Welcome label
            var welcomeLabel = new Label
            {
                Text = $"Welcome, {_currentUser.Username}!",
                Font = new Font("Arial", 16, FontStyle.Bold),
                ForeColor = Color.DarkBlue,
                Size = new Size(400, 30),
                Location = new Point(20, 20)
            };

            // Role label
            var roleLabel = new Label
            {
                Text = "Employee Access - Limited Features",
                Font = new Font("Arial", 12),
                ForeColor = Color.DarkSlateGray,
                Size = new Size(400, 25),
                Location = new Point(20, 50)
            };

            // Main content panel
            var contentPanel = this.Controls.OfType<Panel>().FirstOrDefault(p => p.Name == "contentPanel") ?? new Panel
            {
                Size = new Size(580, 280),
                Location = new Point(10, 100),
                BackColor = Color.White,
                BorderStyle = BorderStyle.FixedSingle
            };

            // Limited access message
            var messageLabel = new Label
            {
                Text = "Employee Dashboard\n\nWelcome to your dashboard!\n\nAvailable features:\n• View inventory (coming soon)\n• Basic reporting (coming soon)\n• Profile management (coming soon)",
                Font = new Font("Arial", 11),
                ForeColor = Color.Black,
                Size = new Size(540, 200),
                Location = new Point(20, 20),
                TextAlign = ContentAlignment.TopLeft
            };

            // Logout button
            var logoutButton = new Button
            {
                Text = "Logout",
                Size = new Size(100, 35),
                Location = new Point(470, 320),
                Font = new Font("Arial", 10, FontStyle.Bold),
                BackColor = Color.OrangeRed,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat
            };

            // Add controls to panels
            headerPanel.Controls.AddRange(new Control[] { welcomeLabel, roleLabel });
            contentPanel.Controls.Add(messageLabel);

            // Add panels and button to form
            this.Controls.AddRange(new Control[] { headerPanel, contentPanel, logoutButton });

            // Event handlers
            logoutButton.Click += LogoutButton_Click;
            this.FormClosing += EmployeeDashboard_FormClosing;
        }

        private void UpdateHeader()
        {
            var header = this.Controls.OfType<System.Windows.Forms.Panel>().FirstOrDefault(p => p.Name == "headerPanel");
            if (header != null)
            {
                var dtLabel = header.Controls.OfType<System.Windows.Forms.Label>().FirstOrDefault(l => l.Name == "dateTimeLabel");
                var welcome = header.Controls.OfType<System.Windows.Forms.Label>().FirstOrDefault(l => l.Name == "welcomeLabel");
                if (dtLabel != null)
                {
                    dtLabel.Text = DateTime.Now.ToString("dddd, MMMM d, yyyy  h:mm:ss tt");
                }
                if (welcome != null)
                {
                    welcome.Text = $"Welcome, {_currentUser.Username}!";
                }
            }
        }

        private void LogoutButton_Click(object? sender, EventArgs e)
        {
            var result = MessageBox.Show(
                "Are you sure you want to logout?",
                "Logout Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void EmployeeDashboard_FormClosing(object? sender, FormClosingEventArgs e)
        {
            // Show login form when this form closes
            var loginForm = new LoginForm();
            loginForm.Show();
        }
    }
}
