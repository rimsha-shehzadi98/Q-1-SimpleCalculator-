using System;
using System.Windows;

namespace WPFCalculator
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // Parse input numbers
                int num1 = int.Parse(FirstNumberTextBox.Text);
                int num2 = int.Parse(SecondNumberTextBox.Text);

                // Perform addition
                int result = num1 + num2;

                // Display result
                ResultTextBox.Text = result.ToString();
            }
            catch (Exception)
            {
                // Show error message if input is invalid
                MessageBox.Show("Please enter valid numbers.");
            }
        }

        private void MultiplyButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // Parse input numbers
                int num1 = int.Parse(FirstNumberTextBox.Text);
                int num2 = int.Parse(SecondNumberTextBox.Text);

                // Perform multiplication
                int result = num1 * num2;

                // Display result
                ResultTextBox.Text = result.ToString();
            }
            catch (Exception)
            {
                // Show error message if input is invalid
                MessageBox.Show("Please enter valid numbers.");
            }
        }

        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            // Clear the text boxes
            FirstNumberTextBox.Text = "";
            SecondNumberTextBox.Text = "";
            ResultTextBox.Text = "";
        }
    }
}