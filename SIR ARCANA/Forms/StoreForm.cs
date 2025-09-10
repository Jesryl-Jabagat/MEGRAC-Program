using System;
using System.Drawing;
using System.Windows.Forms;
using SIR_ARCANA.Models;

namespace SIR_ARCANA.Forms
{
	public partial class StoreForm : Form
	{
		private readonly User _currentUser;

		// Parameterless constructor for Designer support
		public StoreForm()
		{
			InitializeComponent();
		}

		public StoreForm(User currentUser)
		{
			_currentUser = currentUser;
			InitializeComponent();
			// Runtime-only init (keep designer size; do not override)
			titleLabel.Text = $"Store - Welcome, {_currentUser.Username}!";
			var timer = new System.Windows.Forms.Timer { Interval = 1000 };
			timer.Tick += (s, e) => dateTimeLabel.Text = DateTime.Now.ToString("dddd, MMMM d, yyyy  h:mm:ss tt");
			timer.Start();
			dateTimeLabel.Text = DateTime.Now.ToString("dddd, MMMM d, yyyy  h:mm:ss tt");
		}

		private void NavButton_Click(object? sender, EventArgs e)
		{
			if (sender is Button b) LoadSection(b.Text);
		}

		private void LoadSection(string section)
		{
			contentPanel.Controls.Clear();
			var title = new Label
			{
				Text = section,
				Font = new Font("Arial", 18, FontStyle.Bold),
				ForeColor = Color.DarkBlue,
				AutoSize = true,
				Location = new Point(20, 20)
			};
			contentPanel.Controls.Add(title);
		}
	}
}
