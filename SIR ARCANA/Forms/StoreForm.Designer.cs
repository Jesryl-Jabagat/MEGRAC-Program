namespace SIR_ARCANA.Forms
{
	partial class StoreForm
	{
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Panel headerPanel;
		private System.Windows.Forms.Label titleLabel;
		private System.Windows.Forms.Label dateTimeLabel;
		private System.Windows.Forms.Panel navigationPanel;
		private System.Windows.Forms.Panel contentPanel;
		private System.Windows.Forms.Label sidebarTitleLabel;
		private System.Windows.Forms.Button btnDashboard;
		private System.Windows.Forms.Button btnInventory;
		private System.Windows.Forms.Button btnSales;
		private System.Windows.Forms.Button btnPurchases;
		private System.Windows.Forms.Button btnCustomers;
		private System.Windows.Forms.Button btnSuppliers;
		private System.Windows.Forms.Button btnTransactions;

		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null)) components.Dispose();
			base.Dispose(disposing);
		}

        private void InitializeComponent()
        {
            headerPanel = new Panel();
            titleLabel = new Label();
            dateTimeLabel = new Label();
            navigationPanel = new Panel();
            btnDashboard = new Button();
            btnInventory = new Button();
            btnSales = new Button();
            btnPurchases = new Button();
            btnCustomers = new Button();
            btnSuppliers = new Button();
            btnTransactions = new Button();
            sidebarTitleLabel = new Label();
            contentPanel = new Panel();
            headerPanel.SuspendLayout();
            navigationPanel.SuspendLayout();
            SuspendLayout();
            // 
            // headerPanel
            // 
            headerPanel.BackColor = Color.LightBlue;
            headerPanel.BorderStyle = BorderStyle.FixedSingle;
            headerPanel.Controls.Add(titleLabel);
            headerPanel.Controls.Add(dateTimeLabel);
            headerPanel.Dock = DockStyle.Top;
            headerPanel.Location = new Point(0, 0);
            headerPanel.Name = "headerPanel";
            headerPanel.Size = new Size(1051, 80);
            headerPanel.TabIndex = 0;
            // 
            // titleLabel
            // 
            titleLabel.Dock = DockStyle.Left;
            titleLabel.Font = new Font("Arial", 16F, FontStyle.Bold);
            titleLabel.ForeColor = Color.DarkBlue;
            titleLabel.Location = new Point(0, 0);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(500, 78);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "Store";
            titleLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dateTimeLabel
            // 
            dateTimeLabel.Dock = DockStyle.Right;
            dateTimeLabel.Font = new Font("Arial", 10F, FontStyle.Bold);
            dateTimeLabel.ForeColor = Color.Black;
            dateTimeLabel.Location = new Point(744, 0);
            dateTimeLabel.Name = "dateTimeLabel";
            dateTimeLabel.Size = new Size(305, 78);
            dateTimeLabel.TabIndex = 1;
            dateTimeLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // navigationPanel
            // 
            navigationPanel.BackColor = Color.LightGray;
            navigationPanel.BorderStyle = BorderStyle.FixedSingle;
            navigationPanel.Controls.Add(btnDashboard);
            navigationPanel.Controls.Add(btnInventory);
            navigationPanel.Controls.Add(btnSales);
            navigationPanel.Controls.Add(btnPurchases);
            navigationPanel.Controls.Add(btnCustomers);
            navigationPanel.Controls.Add(btnSuppliers);
            navigationPanel.Controls.Add(btnTransactions);
            navigationPanel.Controls.Add(sidebarTitleLabel);
            navigationPanel.Dock = DockStyle.Left;
            navigationPanel.Location = new Point(0, 80);
            navigationPanel.Name = "navigationPanel";
            navigationPanel.Size = new Size(220, 568);
            navigationPanel.TabIndex = 1;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.DodgerBlue;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Arial", 10F, FontStyle.Bold);
            btnDashboard.ForeColor = Color.White;
            btnDashboard.Location = new Point(20, 44);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(180, 36);
            btnDashboard.TabIndex = 6;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = false;
            btnDashboard.Click += NavButton_Click;
            // 
            // btnInventory
            // 
            btnInventory.BackColor = Color.MediumPurple;
            btnInventory.FlatStyle = FlatStyle.Flat;
            btnInventory.Font = new Font("Arial", 10F, FontStyle.Bold);
            btnInventory.ForeColor = Color.White;
            btnInventory.Location = new Point(20, 88);
            btnInventory.Name = "btnInventory";
            btnInventory.Size = new Size(180, 36);
            btnInventory.TabIndex = 5;
            btnInventory.Text = "Inventory";
            btnInventory.UseVisualStyleBackColor = false;
            btnInventory.Click += NavButton_Click;
            // 
            // btnSales
            // 
            btnSales.BackColor = Color.Green;
            btnSales.FlatStyle = FlatStyle.Flat;
            btnSales.Font = new Font("Arial", 10F, FontStyle.Bold);
            btnSales.ForeColor = Color.White;
            btnSales.Location = new Point(20, 132);
            btnSales.Name = "btnSales";
            btnSales.Size = new Size(180, 36);
            btnSales.TabIndex = 4;
            btnSales.Text = "Sales";
            btnSales.UseVisualStyleBackColor = false;
            btnSales.Click += NavButton_Click;
            // 
            // btnPurchases
            // 
            btnPurchases.BackColor = Color.OrangeRed;
            btnPurchases.FlatStyle = FlatStyle.Flat;
            btnPurchases.Font = new Font("Arial", 10F, FontStyle.Bold);
            btnPurchases.ForeColor = Color.White;
            btnPurchases.Location = new Point(20, 176);
            btnPurchases.Name = "btnPurchases";
            btnPurchases.Size = new Size(180, 36);
            btnPurchases.TabIndex = 3;
            btnPurchases.Text = "Purchases";
            btnPurchases.UseVisualStyleBackColor = false;
            btnPurchases.Click += NavButton_Click;
            // 
            // btnCustomers
            // 
            btnCustomers.BackColor = Color.DodgerBlue;
            btnCustomers.FlatStyle = FlatStyle.Flat;
            btnCustomers.Font = new Font("Arial", 10F, FontStyle.Bold);
            btnCustomers.ForeColor = Color.White;
            btnCustomers.Location = new Point(20, 220);
            btnCustomers.Name = "btnCustomers";
            btnCustomers.Size = new Size(180, 36);
            btnCustomers.TabIndex = 2;
            btnCustomers.Text = "Customers";
            btnCustomers.UseVisualStyleBackColor = false;
            btnCustomers.Click += NavButton_Click;
            // 
            // btnSuppliers
            // 
            btnSuppliers.BackColor = Color.MediumPurple;
            btnSuppliers.FlatStyle = FlatStyle.Flat;
            btnSuppliers.Font = new Font("Arial", 10F, FontStyle.Bold);
            btnSuppliers.ForeColor = Color.White;
            btnSuppliers.Location = new Point(20, 264);
            btnSuppliers.Name = "btnSuppliers";
            btnSuppliers.Size = new Size(180, 36);
            btnSuppliers.TabIndex = 1;
            btnSuppliers.Text = "Suppliers";
            btnSuppliers.UseVisualStyleBackColor = false;
            btnSuppliers.Click += NavButton_Click;
            // 
            // btnTransactions
            // 
            btnTransactions.BackColor = Color.Gray;
            btnTransactions.FlatStyle = FlatStyle.Flat;
            btnTransactions.Font = new Font("Arial", 10F, FontStyle.Bold);
            btnTransactions.ForeColor = Color.White;
            btnTransactions.Location = new Point(20, 308);
            btnTransactions.Name = "btnTransactions";
            btnTransactions.Size = new Size(180, 36);
            btnTransactions.TabIndex = 0;
            btnTransactions.Text = "Transactions";
            btnTransactions.UseVisualStyleBackColor = false;
            btnTransactions.Click += NavButton_Click;
            // 
            // sidebarTitleLabel
            // 
            sidebarTitleLabel.Font = new Font("Arial", 12F, FontStyle.Bold);
            sidebarTitleLabel.ForeColor = Color.DarkBlue;
            sidebarTitleLabel.Location = new Point(10, 8);
            sidebarTitleLabel.Name = "sidebarTitleLabel";
            sidebarTitleLabel.Size = new Size(200, 25);
            sidebarTitleLabel.TabIndex = 7;
            sidebarTitleLabel.Text = "Navigation";
            sidebarTitleLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // contentPanel
            // 
            contentPanel.BackColor = Color.White;
            contentPanel.BorderStyle = BorderStyle.FixedSingle;
            contentPanel.Dock = DockStyle.Fill;
            contentPanel.Location = new Point(220, 80);
            contentPanel.Name = "contentPanel";
            contentPanel.Size = new Size(831, 568);
            contentPanel.TabIndex = 2;
            // 
            // StoreForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1051, 648);
            Controls.Add(contentPanel);
            Controls.Add(navigationPanel);
            Controls.Add(headerPanel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "StoreForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Store";
            headerPanel.ResumeLayout(false);
            navigationPanel.ResumeLayout(false);
            ResumeLayout(false);
        }
    }
}
