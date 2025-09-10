using System;
using System.Globalization;
using System.Windows.Forms;

namespace SIR_ARCANA.Forms
{
    /// <summary>
    /// Money Manager form for tracking cash drawer amounts
    /// </summary>
    public partial class MoneyManager : Form
    {
        // Denomination values
        private readonly int[] denominations = { 1000, 500, 200, 100, 50, 20, 10, 5, 1 };
        private readonly TextBox[] denominationTextBoxes;
        private readonly Models.User _currentUser;

        public MoneyManager(Models.User currentUser)
        {
            _currentUser = currentUser ?? throw new ArgumentNullException(nameof(currentUser));
            InitializeComponent();
            
            // Initialize textbox array for easy access
            denominationTextBoxes = new TextBox[]
            {
                textBox1000, textBox500, textBox200, textBox100,
                textBox50, textBox20, textBox10, textBox5, textBox1
            };

            // Calculate initial total
            CalculateTotal();
        }

        /// <summary>
        /// Calculate the total amount based on entered denominations
        /// </summary>
        private void CalculateTotal()
        {
            try
            {
                decimal total = 0;

                for (int i = 0; i < denominations.Length; i++)
                {
                    if (int.TryParse(denominationTextBoxes[i].Text, out int count))
                    {
                        total += count * denominations[i];
                    }
                }

                // Update the total display
                totalAmountLabel.Text = $"₱{total:N2}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error calculating total: {ex.Message}", "Calculation Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Clear all input fields
        /// </summary>
        private void ClearAllFields()
        {
            foreach (var textBox in denominationTextBoxes)
            {
                textBox.Text = "0";
            }
            CalculateTotal();
        }

        /// <summary>
        /// Validate and format input for denomination textboxes
        /// </summary>
        private void ValidateAndFormatInput(TextBox textBox)
        {
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.Text = "0";
                return;
            }

            // Remove any non-numeric characters except minus sign
            string cleanText = textBox.Text.Replace(",", "").Replace(" ", "");
            
            if (int.TryParse(cleanText, out int value))
            {
                // Ensure non-negative values
                if (value < 0)
                {
                    value = 0;
                }
                
                // Limit to reasonable maximum (999,999)
                if (value > 999999)
                {
                    value = 999999;
                }
                
                textBox.Text = value.ToString();
            }
            else
            {
                textBox.Text = "0";
            }
        }

        #region Event Handlers

        private void CancelButton_Click(object? sender, EventArgs e)
        {
            // Return to login screen
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void ProceedButton_Click(object? sender, EventArgs e)
        {
            // Show confirmation popup
            var result = MessageBox.Show(
                $"This will be recorded\n\nTotal Amount: {totalAmountLabel.Text}",
                "Confirm Money Amount",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Proceed to appropriate dashboard
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void TextBox_TextChanged(object? sender, EventArgs e)
        {
            if (sender is TextBox textBox)
            {
                ValidateAndFormatInput(textBox);
                CalculateTotal();
            }
        }

        private void TextBox_KeyPress(object? sender, KeyPressEventArgs e)
        {
            // Allow only digits, backspace, and delete
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// Get the current total amount
        /// </summary>
        /// <returns>Total amount as decimal</returns>
        public decimal GetTotalAmount()
        {
            decimal total = 0;
            for (int i = 0; i < denominations.Length; i++)
            {
                if (int.TryParse(denominationTextBoxes[i].Text, out int count))
                {
                    total += count * denominations[i];
                }
            }
            return total;
        }

        /// <summary>
        /// Get the count for a specific denomination
        /// </summary>
        /// <param name="denomination">The denomination value</param>
        /// <returns>Count of that denomination</returns>
        public int GetDenominationCount(int denomination)
        {
            int index = Array.IndexOf(denominations, denomination);
            if (index >= 0 && index < denominationTextBoxes.Length)
            {
                if (int.TryParse(denominationTextBoxes[index].Text, out int count))
                {
                    return count;
                }
            }
            return 0;
        }

        /// <summary>
        /// Set the count for a specific denomination
        /// </summary>
        /// <param name="denomination">The denomination value</param>
        /// <param name="count">The count to set</param>
        public void SetDenominationCount(int denomination, int count)
        {
            int index = Array.IndexOf(denominations, denomination);
            if (index >= 0 && index < denominationTextBoxes.Length)
            {
                denominationTextBoxes[index].Text = Math.Max(0, count).ToString();
                CalculateTotal();
            }
        }

        #endregion
    }
}
