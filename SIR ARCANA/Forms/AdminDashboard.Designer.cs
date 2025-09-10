namespace SIR_ARCANA.Forms
{
	partial class AdminDashboard
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
            headerPanel = new Panel();
            welcomeLabel = new Label();
            roleLabel = new Label();
            dateTimeLabel = new Label();
            sidebarPanel = new Panel();
            sidebarTitleLabel = new Label();
            manageUsersButton = new Button();
            syncNowButton = new Button();
            storeButton = new Button();
            logoutButton = new Button();
            contentPanel = new Panel();
            usersSectionLabel = new Label();
            _usersDataGridView = new DataGridView();
            userButtonsPanel = new Panel();
            addUserButton = new Button();
            editUserButton = new Button();
            deleteUserButton = new Button();
            refreshButton = new Button();
            headerPanel.SuspendLayout();
            sidebarPanel.SuspendLayout();
            contentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)_usersDataGridView).BeginInit();
            userButtonsPanel.SuspendLayout();
            SuspendLayout();
            // 
            // headerPanel
            // 
            headerPanel.BackColor = Color.LightBlue;
            headerPanel.BorderStyle = BorderStyle.FixedSingle;
            headerPanel.Controls.Add(welcomeLabel);
            headerPanel.Controls.Add(roleLabel);
            headerPanel.Controls.Add(dateTimeLabel);
            headerPanel.Location = new Point(10, 5);
            headerPanel.Name = "headerPanel";
            headerPanel.Size = new Size(1029, 68);
            headerPanel.TabIndex = 0;
            // 
            // welcomeLabel
            // 
            welcomeLabel.Font = new Font("Arial", 16F, FontStyle.Bold);
            welcomeLabel.ForeColor = Color.DarkBlue;
            welcomeLabel.Location = new Point(20, 5);
            welcomeLabel.Name = "welcomeLabel";
            welcomeLabel.Size = new Size(400, 30);
            welcomeLabel.TabIndex = 0;
            welcomeLabel.Text = "Welcome, Admin!";
            // 
            // roleLabel
            // 
            roleLabel.Font = new Font("Arial", 12F);
            roleLabel.ForeColor = Color.DarkSlateGray;
            roleLabel.Location = new Point(20, 35);
            roleLabel.Name = "roleLabel";
            roleLabel.Size = new Size(400, 25);
            roleLabel.TabIndex = 1;
            roleLabel.Text = "Administrator Access - Full System Control";
            // 
            // dateTimeLabel
            // 
            dateTimeLabel.Font = new Font("Arial", 10F, FontStyle.Bold);
            dateTimeLabel.ForeColor = Color.Black;
            dateTimeLabel.Location = new Point(700, 10);
            dateTimeLabel.Name = "dateTimeLabel";
            dateTimeLabel.Size = new Size(260, 25);
            dateTimeLabel.TabIndex = 2;
            dateTimeLabel.Text = "Date :                                               ";
            dateTimeLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // sidebarPanel
            // 
            sidebarPanel.BackColor = Color.LightGray;
            sidebarPanel.BorderStyle = BorderStyle.FixedSingle;
            sidebarPanel.Controls.Add(sidebarTitleLabel);
            sidebarPanel.Controls.Add(manageUsersButton);
            sidebarPanel.Controls.Add(syncNowButton);
            sidebarPanel.Controls.Add(storeButton);
            sidebarPanel.Controls.Add(logoutButton);
            sidebarPanel.Location = new Point(10, 79);
            sidebarPanel.Name = "sidebarPanel";
            sidebarPanel.Size = new Size(200, 565);
            sidebarPanel.TabIndex = 1;
            // 
            // sidebarTitleLabel
            // 
            sidebarTitleLabel.Font = new Font("Arial", 12F, FontStyle.Bold);
            sidebarTitleLabel.ForeColor = Color.DarkBlue;
            sidebarTitleLabel.Location = new Point(10, 10);
            sidebarTitleLabel.Name = "sidebarTitleLabel";
            sidebarTitleLabel.Size = new Size(180, 25);
            sidebarTitleLabel.TabIndex = 0;
            sidebarTitleLabel.Text = "Navigation";
            sidebarTitleLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // manageUsersButton
            // 
            manageUsersButton.BackColor = Color.DodgerBlue;
            manageUsersButton.FlatStyle = FlatStyle.Flat;
            manageUsersButton.Font = new Font("Arial", 10F, FontStyle.Bold);
            manageUsersButton.ForeColor = Color.White;
            manageUsersButton.Location = new Point(20, 50);
            manageUsersButton.Name = "manageUsersButton";
            manageUsersButton.Size = new Size(160, 35);
            manageUsersButton.TabIndex = 1;
            manageUsersButton.Text = "Manage Users";
            manageUsersButton.UseVisualStyleBackColor = false;
            // 
            // syncNowButton
            // 
            syncNowButton.BackColor = Color.Green;
            syncNowButton.FlatStyle = FlatStyle.Flat;
            syncNowButton.Font = new Font("Arial", 10F, FontStyle.Bold);
            syncNowButton.ForeColor = Color.White;
            syncNowButton.Location = new Point(20, 95);
            syncNowButton.Name = "syncNowButton";
            syncNowButton.Size = new Size(160, 35);
            syncNowButton.TabIndex = 2;
            syncNowButton.Text = "Sync Now";
            syncNowButton.UseVisualStyleBackColor = false;
            // 
            // storeButton
            // 
            storeButton.BackColor = Color.MediumPurple;
            storeButton.FlatStyle = FlatStyle.Flat;
            storeButton.Font = new Font("Arial", 10F, FontStyle.Bold);
            storeButton.ForeColor = Color.White;
            storeButton.Location = new Point(20, 140);
            storeButton.Name = "storeButton";
            storeButton.Size = new Size(160, 35);
            storeButton.TabIndex = 3;
            storeButton.Text = "Store";
            storeButton.UseVisualStyleBackColor = false;
            storeButton.Click += storeButton_Click;
            // 
            // logoutButton
            // 
            logoutButton.BackColor = Color.OrangeRed;
            logoutButton.FlatStyle = FlatStyle.Flat;
            logoutButton.Font = new Font("Arial", 10F, FontStyle.Bold);
            logoutButton.ForeColor = Color.White;
            logoutButton.Location = new Point(20, 521);
            logoutButton.Name = "logoutButton";
            logoutButton.Size = new Size(160, 35);
            logoutButton.TabIndex = 3;
            logoutButton.Text = "Logout";
            logoutButton.UseVisualStyleBackColor = false;
            // 
            // contentPanel
            // 
            contentPanel.BorderStyle = BorderStyle.FixedSingle;
            contentPanel.Controls.Add(usersSectionLabel);
            contentPanel.Controls.Add(_usersDataGridView);
            contentPanel.Controls.Add(userButtonsPanel);
            contentPanel.Location = new Point(220, 79);
            contentPanel.Name = "contentPanel";
            contentPanel.Size = new Size(819, 565);
            contentPanel.TabIndex = 2;
            // 
            // usersSectionLabel
            // 
            usersSectionLabel.Font = new Font("Arial", 14F, FontStyle.Bold);
            usersSectionLabel.ForeColor = Color.DarkBlue;
            usersSectionLabel.Location = new Point(20, 4);
            usersSectionLabel.Name = "usersSectionLabel";
            usersSectionLabel.Size = new Size(200, 30);
            usersSectionLabel.TabIndex = 0;
            usersSectionLabel.Text = "User Management";
            // 
            // _usersDataGridView
            // 
            _usersDataGridView.AllowUserToAddRows = false;
            _usersDataGridView.AllowUserToDeleteRows = false;
            _usersDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            _usersDataGridView.BackgroundColor = Color.White;
            _usersDataGridView.BorderStyle = BorderStyle.Fixed3D;
            _usersDataGridView.Location = new Point(20, 35);
            _usersDataGridView.MultiSelect = false;
            _usersDataGridView.Name = "_usersDataGridView";
            _usersDataGridView.ReadOnly = true;
            _usersDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            _usersDataGridView.Size = new Size(774, 469);
            _usersDataGridView.TabIndex = 1;
            // 
            // userButtonsPanel
            // 
            userButtonsPanel.Controls.Add(addUserButton);
            userButtonsPanel.Controls.Add(editUserButton);
            userButtonsPanel.Controls.Add(deleteUserButton);
            userButtonsPanel.Controls.Add(refreshButton);
            userButtonsPanel.Location = new Point(20, 510);
            userButtonsPanel.Name = "userButtonsPanel";
            userButtonsPanel.Size = new Size(794, 50);
            userButtonsPanel.TabIndex = 2;
            // 
            // addUserButton
            // 
            addUserButton.BackColor = Color.Green;
            addUserButton.FlatStyle = FlatStyle.Flat;
            addUserButton.Font = new Font("Arial", 10F, FontStyle.Bold);
            addUserButton.ForeColor = Color.White;
            addUserButton.Location = new Point(0, 8);
            addUserButton.Name = "addUserButton";
            addUserButton.Size = new Size(100, 35);
            addUserButton.TabIndex = 0;
            addUserButton.Text = "Add User";
            addUserButton.UseVisualStyleBackColor = false;
            addUserButton.Click += addUserButton_Click_1;
            // 
            // editUserButton
            // 
            editUserButton.BackColor = Color.DodgerBlue;
            editUserButton.FlatStyle = FlatStyle.Flat;
            editUserButton.Font = new Font("Arial", 10F, FontStyle.Bold);
            editUserButton.ForeColor = Color.White;
            editUserButton.Location = new Point(110, 8);
            editUserButton.Name = "editUserButton";
            editUserButton.Size = new Size(100, 35);
            editUserButton.TabIndex = 1;
            editUserButton.Text = "Edit User";
            editUserButton.UseVisualStyleBackColor = false;
            // 
            // deleteUserButton
            // 
            deleteUserButton.BackColor = Color.Red;
            deleteUserButton.FlatStyle = FlatStyle.Flat;
            deleteUserButton.Font = new Font("Arial", 10F, FontStyle.Bold);
            deleteUserButton.ForeColor = Color.White;
            deleteUserButton.Location = new Point(220, 8);
            deleteUserButton.Name = "deleteUserButton";
            deleteUserButton.Size = new Size(100, 35);
            deleteUserButton.TabIndex = 2;
            deleteUserButton.Text = "Delete User";
            deleteUserButton.UseVisualStyleBackColor = false;
            // 
            // refreshButton
            // 
            refreshButton.BackColor = Color.Gray;
            refreshButton.FlatStyle = FlatStyle.Flat;
            refreshButton.Font = new Font("Arial", 10F, FontStyle.Bold);
            refreshButton.ForeColor = Color.White;
            refreshButton.Location = new Point(330, 8);
            refreshButton.Name = "refreshButton";
            refreshButton.Size = new Size(100, 35);
            refreshButton.TabIndex = 3;
            refreshButton.Text = "Refresh";
            refreshButton.UseVisualStyleBackColor = false;
            // 
            // AdminDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1051, 648);
            Controls.Add(contentPanel);
            Controls.Add(sidebarPanel);
            Controls.Add(headerPanel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "AdminDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inventory Management System - Admin Dashboard";
            headerPanel.ResumeLayout(false);
            sidebarPanel.ResumeLayout(false);
            contentPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)_usersDataGridView).EndInit();
            userButtonsPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel headerPanel;
		private System.Windows.Forms.Label welcomeLabel;
		private System.Windows.Forms.Label roleLabel;
		private System.Windows.Forms.Label dateTimeLabel;
		private System.Windows.Forms.Panel sidebarPanel;
		private System.Windows.Forms.Label sidebarTitleLabel;
		private System.Windows.Forms.Button manageUsersButton;
		private System.Windows.Forms.Button syncNowButton;
		private System.Windows.Forms.Button logoutButton;
		private System.Windows.Forms.Panel contentPanel;
		private System.Windows.Forms.Label usersSectionLabel;
		private System.Windows.Forms.Panel userButtonsPanel;
		private System.Windows.Forms.Button addUserButton;
		private System.Windows.Forms.Button editUserButton;
		private System.Windows.Forms.Button deleteUserButton;
		private System.Windows.Forms.Button refreshButton;
		private System.Windows.Forms.Button storeButton;
	}
}
