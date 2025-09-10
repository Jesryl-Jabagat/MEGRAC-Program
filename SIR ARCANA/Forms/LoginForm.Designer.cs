namespace SIR_ARCANA.Forms
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            logoPictureBox = new PictureBox();
            titleLabel = new Label();
            subtitleLabel = new Label();
            usernameLabel = new Label();
            usernameTextBox = new TextBox();
            passwordLabel = new Label();
            passwordTextBox = new TextBox();
            loginButton = new Button();
            errorLabel = new Label();
            label1 = new Label();
            skipDatabaseCheckBox = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)logoPictureBox).BeginInit();
            SuspendLayout();
            // 
            // logoPictureBox
            // 
            logoPictureBox.BackColor = Color.Transparent;
            logoPictureBox.Image = (Image)resources.GetObject("logoPictureBox.Image");
            logoPictureBox.Location = new Point(100, 46);
            logoPictureBox.Margin = new Padding(0);
            logoPictureBox.Name = "logoPictureBox";
            logoPictureBox.Size = new Size(192, 59);
            logoPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            logoPictureBox.TabIndex = 0;
            logoPictureBox.TabStop = false;
            // 
            // titleLabel
            // 
            titleLabel.Font = new Font("Arial", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            titleLabel.ForeColor = Color.Black;
            titleLabel.Location = new Point(110, 419);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(154, 20);
            titleLabel.TabIndex = 2;
            titleLabel.Text = "MEGRAC Inventory";
            titleLabel.TextAlign = ContentAlignment.MiddleCenter;
            titleLabel.Click += titleLabel_Click;
            // 
            // subtitleLabel
            // 
            subtitleLabel.Font = new Font("Arial", 10F);
            subtitleLabel.ForeColor = Color.DarkSlateGray;
            subtitleLabel.Location = new Point(21, 102);
            subtitleLabel.Name = "subtitleLabel";
            subtitleLabel.Size = new Size(360, 20);
            subtitleLabel.TabIndex = 3;
            subtitleLabel.Text = "Please login to continue";
            subtitleLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // usernameLabel
            // 
            usernameLabel.Font = new Font("Arial", 10F, FontStyle.Bold);
            usernameLabel.Location = new Point(78, 140);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(80, 20);
            usernameLabel.TabIndex = 4;
            usernameLabel.Text = "Username:";
            // 
            // usernameTextBox
            // 
            usernameTextBox.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            usernameTextBox.Location = new Point(78, 162);
            usernameTextBox.Multiline = true;
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(250, 32);
            usernameTextBox.TabIndex = 5;
            usernameTextBox.KeyPress += UsernameTextBox_KeyPress;
            // 
            // passwordLabel
            // 
            passwordLabel.Font = new Font("Arial", 10F, FontStyle.Bold);
            passwordLabel.Location = new Point(78, 210);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(80, 20);
            passwordLabel.TabIndex = 6;
            passwordLabel.Text = "Password:";
            // 
            // passwordTextBox
            // 
            passwordTextBox.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passwordTextBox.Location = new Point(78, 232);
            passwordTextBox.Multiline = true;
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.PasswordChar = '*';
            passwordTextBox.Size = new Size(250, 32);
            passwordTextBox.TabIndex = 7;
            passwordTextBox.KeyPress += PasswordTextBox_KeyPress;
            // 
            // loginButton
            // 
            loginButton.BackColor = Color.DodgerBlue;
            loginButton.FlatStyle = FlatStyle.Flat;
            loginButton.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            loginButton.ForeColor = Color.White;
            loginButton.Location = new Point(153, 277);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(100, 35);
            loginButton.TabIndex = 8;
            loginButton.Text = "Login";
            loginButton.UseVisualStyleBackColor = false;
            loginButton.Click += LoginButton_Click;
            // 
            // errorLabel
            // 
            errorLabel.Font = new Font("Arial", 9F);
            errorLabel.ForeColor = Color.Red;
            errorLabel.Location = new Point(45, 384);
            errorLabel.Name = "errorLabel";
            errorLabel.Size = new Size(312, 35);
            errorLabel.TabIndex = 9;
            errorLabel.TextAlign = ContentAlignment.MiddleCenter;
            errorLabel.Visible = false;
            // 
            // label1
            // 
            label1.Font = new Font("Arial", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkBlue;
            label1.Location = new Point(240, 419);
            label1.Name = "label1";
            label1.Size = new Size(38, 20);
            label1.TabIndex = 10;
            label1.Text = "v1.0.1";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // skipDatabaseCheckBox
            // 
            skipDatabaseCheckBox.AutoSize = true;
            skipDatabaseCheckBox.Font = new Font("Arial", 9F);
            skipDatabaseCheckBox.ForeColor = Color.DarkBlue;
            skipDatabaseCheckBox.Location = new Point(78, 329);
            skipDatabaseCheckBox.Name = "skipDatabaseCheckBox";
            skipDatabaseCheckBox.Size = new Size(141, 19);
            skipDatabaseCheckBox.TabIndex = 11;
            skipDatabaseCheckBox.Text = "Skip Database (Test)";
            skipDatabaseCheckBox.UseVisualStyleBackColor = true;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(400, 439);
            Controls.Add(skipDatabaseCheckBox);
            Controls.Add(label1);
            Controls.Add(errorLabel);
            Controls.Add(loginButton);
            Controls.Add(passwordTextBox);
            Controls.Add(passwordLabel);
            Controls.Add(usernameTextBox);
            Controls.Add(usernameLabel);
            Controls.Add(subtitleLabel);
            Controls.Add(titleLabel);
            Controls.Add(logoPictureBox);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MEGRAC INVENTORY SYSTEM";
            ((System.ComponentModel.ISupportInitialize)logoPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label subtitleLabel;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Label errorLabel;
        private Label label1;
        private System.Windows.Forms.CheckBox skipDatabaseCheckBox;
    }
}
