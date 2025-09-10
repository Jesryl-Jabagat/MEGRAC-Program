namespace SIR_ARCANA.Forms
{
    partial class UserAddEditForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            titleLabel = new Label();
            usernameLabel = new Label();
            usernameTextBox = new TextBox();
            passwordLabel = new Label();
            passwordTextBox = new TextBox();
            roleLabel = new Label();
            roleComboBox = new ComboBox();
            errorLabel = new Label();
            buttonPanel = new Panel();
            cancelButton = new Button();
            saveButton = new Button();
            buttonPanel.SuspendLayout();
            SuspendLayout();
            // 
            // titleLabel
            // 
            titleLabel.Font = new Font("Arial", 14F, FontStyle.Bold);
            titleLabel.ForeColor = Color.DarkBlue;
            titleLabel.Location = new Point(30, 20);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(250, 30);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "Add New User";
            titleLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // usernameLabel
            // 
            usernameLabel.Font = new Font("Arial", 10F, FontStyle.Bold);
            usernameLabel.Location = new Point(30, 70);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(80, 20);
            usernameLabel.TabIndex = 1;
            usernameLabel.Text = "Username:";
            // 
            // usernameTextBox
            // 
            usernameTextBox.Font = new Font("Arial", 10F);
            usernameTextBox.Location = new Point(30, 95);
            usernameTextBox.MaxLength = 50;
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(250, 23);
            usernameTextBox.TabIndex = 2;
            usernameTextBox.KeyPress += UsernameTextBox_KeyPress;
            // 
            // passwordLabel
            // 
            passwordLabel.Font = new Font("Arial", 10F, FontStyle.Bold);
            passwordLabel.Location = new Point(30, 130);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(300, 20);
            passwordLabel.TabIndex = 3;
            passwordLabel.Text = "Password:";
            // 
            // passwordTextBox
            // 
            passwordTextBox.Font = new Font("Arial", 10F);
            passwordTextBox.Location = new Point(30, 155);
            passwordTextBox.MaxLength = 100;
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.PasswordChar = '*';
            passwordTextBox.Size = new Size(250, 23);
            passwordTextBox.TabIndex = 4;
            passwordTextBox.KeyPress += PasswordTextBox_KeyPress;
            // 
            // roleLabel
            // 
            roleLabel.Font = new Font("Arial", 10F, FontStyle.Bold);
            roleLabel.Location = new Point(30, 190);
            roleLabel.Name = "roleLabel";
            roleLabel.Size = new Size(80, 20);
            roleLabel.TabIndex = 5;
            roleLabel.Text = "Role:";
            // 
            // roleComboBox
            // 
            roleComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            roleComboBox.Font = new Font("Arial", 10F);
            roleComboBox.FormattingEnabled = true;
            roleComboBox.Items.AddRange(new object[] { "Admin", "Employee" });
            roleComboBox.Location = new Point(30, 215);
            roleComboBox.Name = "roleComboBox";
            roleComboBox.Size = new Size(150, 24);
            roleComboBox.TabIndex = 6;
            // 
            // errorLabel
            // 
            errorLabel.Font = new Font("Arial", 9F);
            errorLabel.ForeColor = Color.Red;
            errorLabel.Location = new Point(30, 250);
            errorLabel.Name = "errorLabel";
            errorLabel.Size = new Size(340, 20);
            errorLabel.TabIndex = 7;
            errorLabel.TextAlign = ContentAlignment.MiddleLeft;
            errorLabel.Visible = false;
            // 
            // buttonPanel
            // 
            buttonPanel.Controls.Add(cancelButton);
            buttonPanel.Controls.Add(saveButton);
            buttonPanel.Location = new Point(61, 273);
            buttonPanel.Name = "buttonPanel";
            buttonPanel.Size = new Size(177, 40);
            buttonPanel.TabIndex = 8;
            // 
            // cancelButton
            // 
            cancelButton.BackColor = Color.Gray;
            cancelButton.FlatStyle = FlatStyle.Flat;
            cancelButton.Font = new Font("Arial", 10F, FontStyle.Bold);
            cancelButton.ForeColor = Color.White;
            cancelButton.Location = new Point(90, 5);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(80, 30);
            cancelButton.TabIndex = 1;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = false;
            cancelButton.Click += CancelButton_Click;
            // 
            // saveButton
            // 
            saveButton.BackColor = Color.DodgerBlue;
            saveButton.FlatStyle = FlatStyle.Flat;
            saveButton.Font = new Font("Arial", 10F, FontStyle.Bold);
            saveButton.ForeColor = Color.White;
            saveButton.Location = new Point(0, 5);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(80, 30);
            saveButton.TabIndex = 0;
            saveButton.Text = "Add";
            saveButton.UseVisualStyleBackColor = false;
            saveButton.Click += SaveButton_Click;
            // 
            // UserAddEditForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(307, 350);
            Controls.Add(buttonPanel);
            Controls.Add(errorLabel);
            Controls.Add(roleComboBox);
            Controls.Add(roleLabel);
            Controls.Add(passwordTextBox);
            Controls.Add(passwordLabel);
            Controls.Add(usernameTextBox);
            Controls.Add(usernameLabel);
            Controls.Add(titleLabel);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            KeyPreview = true;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "UserAddEditForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add New User";
            KeyDown += UserAddEditForm_KeyDown;
            buttonPanel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label roleLabel;
        private System.Windows.Forms.ComboBox roleComboBox;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.Panel buttonPanel;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button cancelButton;
    }
}



