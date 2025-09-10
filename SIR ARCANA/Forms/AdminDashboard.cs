using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using SIR_ARCANA.Models;
using SIR_ARCANA.Repositories;

namespace SIR_ARCANA.Forms
{
    /// <summary>
    /// Admin dashboard with user management capabilities
    /// </summary>
    public partial class AdminDashboard : Form
    {
        private readonly User _currentUser;
        private readonly UserRepository _userRepository;
        private DataGridView _usersDataGridView = null!;
        private List<User> _users;

        public AdminDashboard(User currentUser)
        {
            _currentUser = currentUser ?? throw new ArgumentNullException(nameof(currentUser));
            _userRepository = new UserRepository();
            _users = new List<User>();
            InitializeComponent();
            // Initialize dynamic header content
            UpdateHeader();
            var timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000;
            timer.Tick += (s, e) => UpdateHeader();
            timer.Start();
            LoadUsers();
        }

        /* obsolete */
        private void InitializeComponent_Old()
        {
            // Form properties
            this.Text = "Inventory Management System - Admin Dashboard";
            this.Size = new Size(1000, 600);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.BackColor = Color.White;

            // Header panel
            var headerPanel = this.Controls.OfType<Panel>().FirstOrDefault(p => p.Name == "headerPanel") ?? new Panel
            {
                Size = new Size(980, 80),
                Location = new Point(10, 10),
                BackColor = Color.LightBlue,
                BorderStyle = BorderStyle.FixedSingle
            };

            // Welcome label
            var welcomeLabel = new Label
            {
                Text = $"Welcome, {_currentUser.Username}! (Admin)",
                Font = new Font("Arial", 16, FontStyle.Bold),
                ForeColor = Color.DarkBlue,
                Size = new Size(400, 30),
                Location = new Point(20, 20)
            };

            // Role label
            var roleLabel = new Label
            {
                Text = "Administrator Access - Full System Control",
                Font = new Font("Arial", 12),
                ForeColor = Color.DarkSlateGray,
                Size = new Size(400, 25),
                Location = new Point(20, 50)
            };

            // Sidebar panel
            var sidebarPanel = this.Controls.OfType<Panel>().FirstOrDefault(p => p.Name == "sidebarPanel") ?? new Panel
            {
                Size = new Size(200, 480),
                Location = new Point(10, 100),
                BackColor = Color.LightGray,
                BorderStyle = BorderStyle.FixedSingle
            };

            // Sidebar title
            var sidebarTitleLabel = new Label
            {
                Text = "Navigation",
                Font = new Font("Arial", 12, FontStyle.Bold),
                ForeColor = Color.DarkBlue,
                Size = new Size(180, 25),
                Location = new Point(10, 10),
                TextAlign = ContentAlignment.MiddleCenter
            };

            // Manage Users button
            var manageUsersButton = new Button
            {
                Text = "Manage Users",
                Size = new Size(160, 35),
                Location = new Point(20, 50),
                Font = new Font("Arial", 10, FontStyle.Bold),
                BackColor = Color.DodgerBlue,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat
            };

            // Sync Now button
            var syncNowButton = new Button
            {
                Text = "Sync Now",
                Size = new Size(160, 35),
                Location = new Point(20, 95),
                Font = new Font("Arial", 10, FontStyle.Bold),
                BackColor = Color.Green,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat
            };

            // Logout button
            var logoutButton = new Button
            {
                Text = "Logout",
                Size = new Size(160, 35),
                Location = new Point(20, 140),
                Font = new Font("Arial", 10, FontStyle.Bold),
                BackColor = Color.OrangeRed,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat
            };

            // Main content panel
            var contentPanel = this.Controls.OfType<Panel>().FirstOrDefault(p => p.Name == "contentPanel") ?? new Panel
            {
                Size = new Size(760, 480),
                Location = new Point(220, 100),
                BackColor = Color.White,
                BorderStyle = BorderStyle.FixedSingle
            };

            // Users management section
            var usersSectionLabel = new Label
            {
                Text = "User Management",
                Font = new Font("Arial", 14, FontStyle.Bold),
                ForeColor = Color.DarkBlue,
                Size = new Size(200, 30),
                Location = new Point(20, 20)
            };

            // Users data grid view
            _usersDataGridView = new DataGridView
            {
                Size = new Size(700, 300),
                Location = new Point(20, 60),
                AllowUserToAddRows = false,
                AllowUserToDeleteRows = false,
                ReadOnly = true,
                SelectionMode = DataGridViewSelectionMode.FullRowSelect,
                MultiSelect = false,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                BackgroundColor = Color.White,
                BorderStyle = BorderStyle.Fixed3D
            };

            // User management buttons panel
            var userButtonsPanel = new Panel
            {
                Size = new Size(700, 50),
                Location = new Point(20, 370),
                BackColor = Color.Transparent
            };

            // Add User button
            var addUserButton = new Button
            {
                Text = "Add User",
                Size = new Size(100, 35),
                Location = new Point(0, 8),
                Font = new Font("Arial", 10, FontStyle.Bold),
                BackColor = Color.Green,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat
            };

            // Edit User button
            var editUserButton = new Button
            {
                Text = "Edit User",
                Size = new Size(100, 35),
                Location = new Point(110, 8),
                Font = new Font("Arial", 10, FontStyle.Bold),
                BackColor = Color.DodgerBlue,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat
            };

            // Delete User button
            var deleteUserButton = new Button
            {
                Text = "Delete User",
                Size = new Size(100, 35),
                Location = new Point(220, 8),
                Font = new Font("Arial", 10, FontStyle.Bold),
                BackColor = Color.Red,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat
            };

            // Refresh button
            var refreshButton = new Button
            {
                Text = "Refresh",
                Size = new Size(100, 35),
                Location = new Point(330, 8),
                Font = new Font("Arial", 10, FontStyle.Bold),
                BackColor = Color.Gray,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat
            };

            // Add buttons to user buttons panel
            userButtonsPanel.Controls.AddRange(new Control[] { addUserButton, editUserButton, deleteUserButton, refreshButton });

            // Add controls to panels
            headerPanel.Controls.AddRange(new Control[] { welcomeLabel, roleLabel });
            sidebarPanel.Controls.AddRange(new Control[] { sidebarTitleLabel, manageUsersButton, syncNowButton, logoutButton });
            contentPanel.Controls.AddRange(new Control[] { usersSectionLabel, _usersDataGridView, userButtonsPanel });

            // Add panels to form
            this.Controls.AddRange(new Control[] { headerPanel, sidebarPanel, contentPanel });

            // Event handlers
            addUserButton.Click += AddUserButton_Click;
            editUserButton.Click += EditUserButton_Click;
            deleteUserButton.Click += DeleteUserButton_Click;
            refreshButton.Click += RefreshButton_Click;
            manageUsersButton.Click += ManageUsersButton_Click;
            syncNowButton.Click += SyncNowButton_Click;
            logoutButton.Click += LogoutButton_Click;
            var storeBtn = this.Controls.OfType<Panel>().FirstOrDefault(p=>p.Name=="sidebarPanel")?.Controls.OfType<Button>().FirstOrDefault(b=>b.Name=="storeButton");
            if (storeBtn != null) storeBtn.Click += storeButton_Click;
            this.FormClosing += AdminDashboard_FormClosing;

            // Configure data grid view
            ConfigureDataGridView();
        }

        private void UpdateHeader()
        {
            // Update welcome label (if needed in the future) and datetime in readable format
            var formControls = this.Controls;
            var header = formControls.OfType<System.Windows.Forms.Panel>().FirstOrDefault(p => p.Name == "headerPanel");
            if (header != null)
            {
                var dtLabel = header.Controls.OfType<System.Windows.Forms.Label>().FirstOrDefault(l => l.Name == "dateTimeLabel");
                if (dtLabel != null)
                {
                    dtLabel.Text = DateTime.Now.ToString("dddd, MMMM d, yyyy  h:mm:ss tt");
                }
            }
        }

        private void ConfigureDataGridView()
        {
            _usersDataGridView.Columns.Clear();
            _usersDataGridView.Columns.Add("UserId", "ID");
            _usersDataGridView.Columns.Add("Username", "Username");
            _usersDataGridView.Columns.Add("Role", "Role");
            _usersDataGridView.Columns.Add("CreatedAt", "Created At");
            _usersDataGridView.Columns.Add("LastSynced", "Last Synced");

            // Set column properties
            _usersDataGridView.Columns["UserId"].Width = 50;
            _usersDataGridView.Columns["Username"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            _usersDataGridView.Columns["Role"].Width = 100;
            _usersDataGridView.Columns["CreatedAt"].Width = 120;
            _usersDataGridView.Columns["LastSynced"].Width = 120;

            // Hide password column (we don't display it)
            _usersDataGridView.Columns["UserId"].Visible = false;
        }

        private void LoadUsers()
        {
            try
            {
                _users = _userRepository.GetAllUsers();
                RefreshDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load users: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RefreshDataGridView()
        {
            _usersDataGridView.Rows.Clear();
            foreach (var user in _users)
            {
                _usersDataGridView.Rows.Add(
                    user.UserId,
                    user.Username,
                    user.Role,
                    user.CreatedAt.ToString("yyyy-MM-dd HH:mm"),
                    user.LastSynced?.ToString("yyyy-MM-dd HH:mm") ?? "Never"
                );
            }
        }

        private void AddUserButton_Click(object? sender, EventArgs e)
        {
            var addUserForm = new UserAddEditForm();
            if (addUserForm.ShowDialog() == DialogResult.OK)
            {
                LoadUsers();
            }
        }

        private void EditUserButton_Click(object? sender, EventArgs e)
        {
            if (_usersDataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a user to edit.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedUserId = (int)_usersDataGridView.SelectedRows[0].Cells["UserId"].Value;
            var userToEdit = _users.FirstOrDefault(u => u.UserId == selectedUserId);

            if (userToEdit != null)
            {
                var editUserForm = new UserAddEditForm(userToEdit);
                if (editUserForm.ShowDialog() == DialogResult.OK)
                {
                    LoadUsers();
                }
            }
        }

        private void DeleteUserButton_Click(object? sender, EventArgs e)
        {
            if (_usersDataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a user to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedUserId = (int)_usersDataGridView.SelectedRows[0].Cells["UserId"].Value;
            var userToDelete = _users.FirstOrDefault(u => u.UserId == selectedUserId);

            if (userToDelete != null)
            {
                // Prevent deleting the current user
                if (userToDelete.UserId == _currentUser.UserId)
                {
                    MessageBox.Show("You cannot delete your own account.", "Cannot Delete", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var result = MessageBox.Show(
                    $"Are you sure you want to delete user '{userToDelete.Username}'?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        if (_userRepository.DeleteUser(selectedUserId))
                        {
                            MessageBox.Show("User deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadUsers();
                        }
                        else
                        {
                            MessageBox.Show("Failed to delete user.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error deleting user: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void RefreshButton_Click(object? sender, EventArgs e)
        {
            LoadUsers();
        }

        private void ManageUsersButton_Click(object? sender, EventArgs e)
        {
            // This is already the users management view, so just refresh
            LoadUsers();
        }

        private void SyncNowButton_Click(object? sender, EventArgs e)
        {
            MessageBox.Show("Cloud sync functionality will be implemented in future updates.", "Sync Not Available", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void AdminDashboard_FormClosing(object? sender, FormClosingEventArgs e)
        {
            // Show login form when this form closes
            var loginForm = new LoginForm();
            loginForm.Show();
        }

        private void addUserButton_Click_1(object sender, EventArgs e)
        {
            var UserAddEditForm = new UserAddEditForm();
            UserAddEditForm.Show();
        }

        private void storeButton_Click(object? sender, EventArgs e)
        {
            this.Hide();
            try
            {
                using var storeForm = new StoreForm(_currentUser);
                storeForm.StartPosition = FormStartPosition.CenterScreen;
                storeForm.ShowDialog(this);
            }
            finally
            {
                this.Show();
            }
        }
    }
}
