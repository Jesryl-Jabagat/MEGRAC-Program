namespace SIR_ARCANA.Forms
{
    partial class MoneyManager
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
            subtitleLabel = new Label();
            panel1 = new Panel();
            label1 = new Label();
            textBox1 = new TextBox();
            label5 = new Label();
            textBox5 = new TextBox();
            label10 = new Label();
            textBox10 = new TextBox();
            label20 = new Label();
            textBox20 = new TextBox();
            label50 = new Label();
            textBox50 = new TextBox();
            label100 = new Label();
            textBox100 = new TextBox();
            label200 = new Label();
            textBox200 = new TextBox();
            label500 = new Label();
            textBox500 = new TextBox();
            label1000 = new Label();
            textBox1000 = new TextBox();
            panel2 = new Panel();
            totalAmountLabel = new Label();
            totalLabel = new Label();
            cancelButton = new Button();
            proceedButton = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // titleLabel
            // 
            titleLabel.Font = new Font("Arial", 16F, FontStyle.Bold);
            titleLabel.ForeColor = Color.DarkBlue;
            titleLabel.Location = new Point(20, 20);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(400, 30);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "Money Manager - Cash Drawer";
            titleLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // subtitleLabel
            // 
            subtitleLabel.Font = new Font("Arial", 10F);
            subtitleLabel.ForeColor = Color.Gray;
            subtitleLabel.Location = new Point(20, 50);
            subtitleLabel.Name = "subtitleLabel";
            subtitleLabel.Size = new Size(400, 20);
            subtitleLabel.TabIndex = 1;
            subtitleLabel.Text = "Enter the number of bills and coins in each denomination";
            subtitleLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(textBox5);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(textBox10);
            panel1.Controls.Add(label20);
            panel1.Controls.Add(textBox20);
            panel1.Controls.Add(label50);
            panel1.Controls.Add(textBox50);
            panel1.Controls.Add(label100);
            panel1.Controls.Add(textBox100);
            panel1.Controls.Add(label200);
            panel1.Controls.Add(textBox200);
            panel1.Controls.Add(label500);
            panel1.Controls.Add(textBox500);
            panel1.Controls.Add(label1000);
            panel1.Controls.Add(textBox1000);
            panel1.Location = new Point(30, 90);
            panel1.Name = "panel1";
            panel1.Size = new Size(380, 294);
            panel1.TabIndex = 2;
            // 
            // label1
            // 
            label1.Font = new Font("Arial", 10F, FontStyle.Bold);
            label1.Location = new Point(20, 260);
            label1.Name = "label1";
            label1.Size = new Size(100, 20);
            label1.TabIndex = 16;
            label1.Text = "₱1 Coins:";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Arial", 10F);
            textBox1.Location = new Point(200, 260);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 17;
            textBox1.Text = "0";
            textBox1.TextAlign = HorizontalAlignment.Right;
            textBox1.TextChanged += TextBox_TextChanged;
            textBox1.KeyPress += TextBox_KeyPress;
            // 
            // label5
            // 
            label5.Font = new Font("Arial", 10F, FontStyle.Bold);
            label5.Location = new Point(20, 230);
            label5.Name = "label5";
            label5.Size = new Size(100, 20);
            label5.TabIndex = 14;
            label5.Text = "₱5 Coins:";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Arial", 10F);
            textBox5.Location = new Point(200, 230);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(100, 23);
            textBox5.TabIndex = 15;
            textBox5.Text = "0";
            textBox5.TextAlign = HorizontalAlignment.Right;
            textBox5.TextChanged += TextBox_TextChanged;
            textBox5.KeyPress += TextBox_KeyPress;
            // 
            // label10
            // 
            label10.Font = new Font("Arial", 10F, FontStyle.Bold);
            label10.Location = new Point(20, 200);
            label10.Name = "label10";
            label10.Size = new Size(100, 20);
            label10.TabIndex = 12;
            label10.Text = "₱10 Coins:";
            label10.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBox10
            // 
            textBox10.Font = new Font("Arial", 10F);
            textBox10.Location = new Point(200, 200);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(100, 23);
            textBox10.TabIndex = 13;
            textBox10.Text = "0";
            textBox10.TextAlign = HorizontalAlignment.Right;
            textBox10.TextChanged += TextBox_TextChanged;
            textBox10.KeyPress += TextBox_KeyPress;
            // 
            // label20
            // 
            label20.Font = new Font("Arial", 10F, FontStyle.Bold);
            label20.Location = new Point(20, 170);
            label20.Name = "label20";
            label20.Size = new Size(100, 20);
            label20.TabIndex = 10;
            label20.Text = "₱20 Bills:";
            label20.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBox20
            // 
            textBox20.Font = new Font("Arial", 10F);
            textBox20.Location = new Point(200, 170);
            textBox20.Name = "textBox20";
            textBox20.Size = new Size(100, 23);
            textBox20.TabIndex = 11;
            textBox20.Text = "0";
            textBox20.TextAlign = HorizontalAlignment.Right;
            textBox20.TextChanged += TextBox_TextChanged;
            textBox20.KeyPress += TextBox_KeyPress;
            // 
            // label50
            // 
            label50.Font = new Font("Arial", 10F, FontStyle.Bold);
            label50.Location = new Point(20, 140);
            label50.Name = "label50";
            label50.Size = new Size(100, 20);
            label50.TabIndex = 8;
            label50.Text = "₱50 Bills:";
            label50.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBox50
            // 
            textBox50.Font = new Font("Arial", 10F);
            textBox50.Location = new Point(200, 140);
            textBox50.Name = "textBox50";
            textBox50.Size = new Size(100, 23);
            textBox50.TabIndex = 9;
            textBox50.Text = "0";
            textBox50.TextAlign = HorizontalAlignment.Right;
            textBox50.TextChanged += TextBox_TextChanged;
            textBox50.KeyPress += TextBox_KeyPress;
            // 
            // label100
            // 
            label100.Font = new Font("Arial", 10F, FontStyle.Bold);
            label100.Location = new Point(20, 110);
            label100.Name = "label100";
            label100.Size = new Size(100, 20);
            label100.TabIndex = 6;
            label100.Text = "₱100 Bills:";
            label100.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBox100
            // 
            textBox100.Font = new Font("Arial", 10F);
            textBox100.Location = new Point(200, 110);
            textBox100.Name = "textBox100";
            textBox100.Size = new Size(100, 23);
            textBox100.TabIndex = 7;
            textBox100.Text = "0";
            textBox100.TextAlign = HorizontalAlignment.Right;
            textBox100.TextChanged += TextBox_TextChanged;
            textBox100.KeyPress += TextBox_KeyPress;
            // 
            // label200
            // 
            label200.Font = new Font("Arial", 10F, FontStyle.Bold);
            label200.Location = new Point(20, 80);
            label200.Name = "label200";
            label200.Size = new Size(100, 20);
            label200.TabIndex = 4;
            label200.Text = "₱200 Bills:";
            label200.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBox200
            // 
            textBox200.Font = new Font("Arial", 10F);
            textBox200.Location = new Point(200, 80);
            textBox200.Name = "textBox200";
            textBox200.Size = new Size(100, 23);
            textBox200.TabIndex = 5;
            textBox200.Text = "0";
            textBox200.TextAlign = HorizontalAlignment.Right;
            textBox200.TextChanged += TextBox_TextChanged;
            textBox200.KeyPress += TextBox_KeyPress;
            // 
            // label500
            // 
            label500.Font = new Font("Arial", 10F, FontStyle.Bold);
            label500.Location = new Point(20, 50);
            label500.Name = "label500";
            label500.Size = new Size(100, 20);
            label500.TabIndex = 2;
            label500.Text = "₱500 Bills:";
            label500.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBox500
            // 
            textBox500.Font = new Font("Arial", 10F);
            textBox500.Location = new Point(200, 50);
            textBox500.Name = "textBox500";
            textBox500.Size = new Size(100, 23);
            textBox500.TabIndex = 3;
            textBox500.Text = "0";
            textBox500.TextAlign = HorizontalAlignment.Right;
            textBox500.TextChanged += TextBox_TextChanged;
            textBox500.KeyPress += TextBox_KeyPress;
            // 
            // label1000
            // 
            label1000.Font = new Font("Arial", 10F, FontStyle.Bold);
            label1000.Location = new Point(20, 20);
            label1000.Name = "label1000";
            label1000.Size = new Size(100, 20);
            label1000.TabIndex = 0;
            label1000.Text = "₱1,000 Bills:";
            label1000.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBox1000
            // 
            textBox1000.Font = new Font("Arial", 10F);
            textBox1000.Location = new Point(200, 20);
            textBox1000.Name = "textBox1000";
            textBox1000.Size = new Size(100, 23);
            textBox1000.TabIndex = 1;
            textBox1000.Text = "0";
            textBox1000.TextAlign = HorizontalAlignment.Right;
            textBox1000.TextChanged += TextBox_TextChanged;
            textBox1000.KeyPress += TextBox_KeyPress;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(totalAmountLabel);
            panel2.Controls.Add(totalLabel);
            panel2.Location = new Point(30, 390);
            panel2.Name = "panel2";
            panel2.Size = new Size(380, 60);
            panel2.TabIndex = 3;
            // 
            // totalAmountLabel
            // 
            totalAmountLabel.Font = new Font("Arial", 16F, FontStyle.Bold);
            totalAmountLabel.ForeColor = Color.Green;
            totalAmountLabel.Location = new Point(130, 10);
            totalAmountLabel.Name = "totalAmountLabel";
            totalAmountLabel.Size = new Size(230, 30);
            totalAmountLabel.TabIndex = 1;
            totalAmountLabel.Text = "₱0.00";
            totalAmountLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // totalLabel
            // 
            totalLabel.Font = new Font("Arial", 12F, FontStyle.Bold);
            totalLabel.ForeColor = Color.DarkBlue;
            totalLabel.Location = new Point(20, 10);
            totalLabel.Name = "totalLabel";
            totalLabel.Size = new Size(100, 30);
            totalLabel.TabIndex = 0;
            totalLabel.Text = "Total Amount:";
            totalLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cancelButton
            // 
            cancelButton.BackColor = Color.Gray;
            cancelButton.FlatStyle = FlatStyle.Flat;
            cancelButton.Font = new Font("Arial", 10F, FontStyle.Bold);
            cancelButton.ForeColor = Color.White;
            cancelButton.Location = new Point(30, 470);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(100, 35);
            cancelButton.TabIndex = 4;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = false;
            cancelButton.Click += CancelButton_Click;
            // 
            // proceedButton
            // 
            proceedButton.BackColor = Color.Green;
            proceedButton.FlatStyle = FlatStyle.Flat;
            proceedButton.Font = new Font("Arial", 10F, FontStyle.Bold);
            proceedButton.ForeColor = Color.White;
            proceedButton.Location = new Point(310, 470);
            proceedButton.Name = "proceedButton";
            proceedButton.Size = new Size(100, 35);
            proceedButton.TabIndex = 5;
            proceedButton.Text = "Proceed";
            proceedButton.UseVisualStyleBackColor = false;
            proceedButton.Click += ProceedButton_Click;
            // 
            // MoneyManager
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(440, 530);
            Controls.Add(proceedButton);
            Controls.Add(cancelButton);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(subtitleLabel);
            Controls.Add(titleLabel);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MoneyManager";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Money Manager - Cash Drawer";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label subtitleLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1000;
        private System.Windows.Forms.TextBox textBox1000;
        private System.Windows.Forms.Label label500;
        private System.Windows.Forms.TextBox textBox500;
        private System.Windows.Forms.Label label200;
        private System.Windows.Forms.TextBox textBox200;
        private System.Windows.Forms.Label label100;
        private System.Windows.Forms.TextBox textBox100;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.TextBox textBox50;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox textBox20;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label totalAmountLabel;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button proceedButton;
    }
}
