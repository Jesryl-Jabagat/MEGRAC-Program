using System;
using System.Drawing;
using System.Windows.Forms;
using SIR_ARCANA.Models;
using SIR_ARCANA.Repositories;

namespace SIR_ARCANA.Forms
{
    /// <summary>
    /// Modal dialog for adding or editing users
    /// </summary>
    public partial class UserAddEditForm : Form
    {
        private readonly UserRepository _userRepository;
        private readonly User? _existingUser;
        private readonly bool _isEditMode;

        public UserAddEditForm(User? existingUser = null)
        {
            _userRepository = new UserRepository();
            _existingUser = existingUser;
            _isEditMode = existingUser != null;
            InitializeComponent();
            
            // Set form properties based on mode
            this.Text = _isEditMode ? "Edit User" : "Add New User";
            titleLabel.Text = _isEditMode ? "Edit User Information" : "Add New User";
            passwordLabel.Text = _isEditMode ? "New Password (leave blank to keep current):" : "Password:";
            saveButton.Text = _isEditMode ? "Update" : "Add";

            // Load existing user data if in edit mode
            if (_isEditMode && _existingUser != null)
            {
                usernameTextBox.Text = _existingUser.Username;
                roleComboBox.SelectedItem = _existingUser.Role;
            }
            else
            {
                // Default to Employee for new users
                roleComboBox.SelectedIndex = 1;
            }

            // Focus on username textbox
            usernameTextBox.Focus();
        }

        private void SaveButton_Click(object? sender, EventArgs e)
        {
            try
            {
                // Clear previous error
                errorLabel.Visible = false;

                // Validate input
                if (string.IsNullOrWhiteSpace(usernameTextBox.Text))
                {
                    ShowError("Username is required");
                    usernameTextBox.Focus();
                    return;
                }

                if (!_isEditMode && string.IsNullOrWhiteSpace(passwordTextBox.Text))
                {
                    ShowError("Password is required for new users");
                    passwordTextBox.Focus();
                    return;
                }

                if (roleComboBox.SelectedItem == null)
                {
                    ShowError("Please select a role");
                    roleComboBox.Focus();
                    return;
                }

                // Check if username already exists
                if (_userRepository.UsernameExists(usernameTextBox.Text.Trim(), _isEditMode ? _existingUser?.UserId : null))
                {
                    ShowError("Username already exists");
                    usernameTextBox.Focus();
                    return;
                }

                // Create or update user
                var user = new User
                {
                    Username = usernameTextBox.Text.Trim(),
                    Role = roleComboBox.SelectedItem.ToString()!
                };

                if (_isEditMode && _existingUser != null)
                {
                    user.UserId = _existingUser.UserId;
                    user.LastSynced = _existingUser.LastSynced;
                    user.CreatedAt = _existingUser.CreatedAt;

                    // Update user
                    bool success = _userRepository.UpdateUser(user, 
                        string.IsNullOrWhiteSpace(passwordTextBox.Text) ? null : passwordTextBox.Text);

                    if (success)
                    {
                        MessageBox.Show("User updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        ShowError("Failed to update user");
                    }
                }
                else
                {
                    // Add new user
                    bool success = _userRepository.AddUser(user, passwordTextBox.Text);

                    if (success)
                    {
                        MessageBox.Show("User added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        ShowError("Failed to add user");
                    }
                }
            }
            catch (Exception ex)
            {
                ShowError($"Error: {ex.Message}");
            }
        }

        private void CancelButton_Click(object? sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void UsernameTextBox_KeyPress(object? sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                passwordTextBox.Focus();
            }
        }

        private void PasswordTextBox_KeyPress(object? sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                roleComboBox.Focus();
            }
        }

        private void UserAddEditForm_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SaveButton_Click(sender, e);
            }
            else if (e.KeyCode == Keys.Escape)
            {
                CancelButton_Click(sender, e);
            }
        }

        private void ShowError(string message)
        {
            errorLabel.Text = message;
            errorLabel.Visible = true;
        }
    }
}
