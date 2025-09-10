namespace SIR_ARCANA.Forms
{
	partial class EmployeeDashboard
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
            contentPanel = new Panel();
            logoutButton = new Button();
            messageLabel = new Label();
            headerPanel.SuspendLayout();
            contentPanel.SuspendLayout();
            SuspendLayout();
            // 
            // headerPanel
            // 
            headerPanel.BackColor = Color.LightBlue;
            headerPanel.BorderStyle = BorderStyle.FixedSingle;
            headerPanel.Controls.Add(welcomeLabel);
            headerPanel.Controls.Add(roleLabel);
            headerPanel.Controls.Add(dateTimeLabel);
            headerPanel.Location = new Point(10, 10);
            headerPanel.Name = "headerPanel";
            headerPanel.Size = new Size(1029, 80);
            headerPanel.TabIndex = 0;
            // 
            // welcomeLabel
            // 
            welcomeLabel.Font = new Font("Arial", 16F, FontStyle.Bold);
            welcomeLabel.ForeColor = Color.DarkBlue;
            welcomeLabel.Location = new Point(20, 20);
            welcomeLabel.Name = "welcomeLabel";
            welcomeLabel.Size = new Size(400, 30);
            welcomeLabel.TabIndex = 0;
            welcomeLabel.Text = "Welcome, Employee!";
            // 
            // roleLabel
            // 
            roleLabel.Font = new Font("Arial", 12F);
            roleLabel.ForeColor = Color.DarkSlateGray;
            roleLabel.Location = new Point(20, 50);
            roleLabel.Name = "roleLabel";
            roleLabel.Size = new Size(400, 25);
            roleLabel.TabIndex = 1;
            roleLabel.Text = "Employee Access - Limited Features";
            // 
            // dateTimeLabel
            // 
            dateTimeLabel.Font = new Font("Arial", 10F, FontStyle.Bold);
            dateTimeLabel.ForeColor = Color.Black;
            dateTimeLabel.Location = new Point(731, 25);
            dateTimeLabel.Name = "dateTimeLabel";
            dateTimeLabel.Size = new Size(293, 25);
            dateTimeLabel.TabIndex = 2;
            dateTimeLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // contentPanel
            // 
            contentPanel.BackColor = Color.White;
            contentPanel.BorderStyle = BorderStyle.FixedSingle;
            contentPanel.Controls.Add(logoutButton);
            contentPanel.Controls.Add(messageLabel);
            contentPanel.Location = new Point(10, 100);
            contentPanel.Name = "contentPanel";
            contentPanel.Size = new Size(1029, 536);
            contentPanel.TabIndex = 1;
            // 
            // logoutButton
            // 
            logoutButton.BackColor = Color.OrangeRed;
            logoutButton.FlatStyle = FlatStyle.Flat;
            logoutButton.Font = new Font("Arial", 10F, FontStyle.Bold);
            logoutButton.ForeColor = Color.White;
            logoutButton.Location = new Point(924, 496);
            logoutButton.Name = "logoutButton";
            logoutButton.Size = new Size(100, 35);
            logoutButton.TabIndex = 2;
            logoutButton.Text = "Logout";
            logoutButton.UseVisualStyleBackColor = false;
            // 
            // messageLabel
            // 
            messageLabel.Font = new Font("Arial", 11F);
            messageLabel.ForeColor = Color.Black;
            messageLabel.Location = new Point(20, 20);
            messageLabel.Name = "messageLabel";
            messageLabel.Size = new Size(540, 200);
            messageLabel.TabIndex = 0;
            messageLabel.Text = "Employee Dashboard\n\nWelcome to your dashboard!\n\nAvailable features:\n• View inventory (coming soon)\n• Basic reporting (coming soon)\n• Profile management (coming soon)";
            // 
            // EmployeeDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1051, 648);
            Controls.Add(contentPanel);
            Controls.Add(headerPanel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "EmployeeDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inventory Management System - Employee Dashboard";
            headerPanel.ResumeLayout(false);
            contentPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel headerPanel;
		private System.Windows.Forms.Label welcomeLabel;
		private System.Windows.Forms.Label roleLabel;
		private System.Windows.Forms.Label dateTimeLabel;
		private System.Windows.Forms.Panel contentPanel;
		private System.Windows.Forms.Label messageLabel;
		private System.Windows.Forms.Button logoutButton;
	}
}
