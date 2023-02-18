using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace lab6_1_Bonnie
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkEmail_Click(object sender, EventArgs e)
        {
            string email;
            email = textBox.Text;
            System.Text.RegularExpressions.Regex reg = new Regex(@"^([\w]+)@([\w]+)\.([\w]+)$");
            if (string.IsNullOrEmpty(textBox.Text))
            {
                MessageBox.Show("The text box is empty. Please inform email for validation.");
            }
            else
            {
                if (reg.IsMatch(email) == true)
                {
                    MessageBox.Show("Valid e-mail.");
                }
                else
                {
                    MessageBox.Show("Invalid e-mail.");
                }
            }            
        }

        private void checkEmail_Validating(object sender, CancelEventArgs e)
        {
            string email;
            email = textBox.Text;
            Regex reg = new Regex(@"^([\w] +)@([\w] +).([\w] +)$");

            if (reg.IsMatch(email) == true) {
                MessageBox.Show("Valid e-mail.");
            }
        }

        private void deleteExtraSpaces_Click(object sender, EventArgs e)
        {
            string input = textBox.Text;
            string pattern = "([\\s]+)";

            if (string.IsNullOrEmpty(textBox.Text))
            {
                MessageBox.Show("Text box is empty. Please, inform text.");
            }            
            else
            {
                input = Regex.Replace(input, pattern, " ");
                MessageBox.Show(input);
            }
        }

        private void validatePostalCode_Click(object sender, EventArgs e)
        {
            string postalCode;
            postalCode = textBox.Text;

            System.Text.RegularExpressions.Regex reg = new Regex(@"^[A-Z][0-9][A-Z][0-9][A-Z][0-9]$");

            if (string.IsNullOrEmpty(textBox.Text))
            {
                MessageBox.Show("Text box is empty. Please inform postal code.");
            }
            else
            {
                if (reg.IsMatch(postalCode) == true)
                {
                    MessageBox.Show("Valid postal code.");
                }
                else
                {
                    MessageBox.Show("Invalid postal code.");
                }
            }
        }

        private void deleteLetter_Click(object sender, EventArgs e)
        {
            string input = textBox.Text;
            string pattern = "[abcd]";            

            if (string.IsNullOrEmpty(textBox.Text))
            {
                MessageBox.Show("Text box is empty. Please inform text.");
            }
            else
            {
                input = Regex.Replace(input, pattern, String.Empty);
                MessageBox.Show(input);
            }
        }
        private void createArray_Click(object sender, EventArgs e)
        {
            string input = textBox.Text;

            if (string.IsNullOrEmpty(textBox.Text))
            {
                MessageBox.Show("Text box is empty. Please inform text.");
            }
            else
            {
                string[] inputString = Regex.Split(input, @"\W+");

                string showString = string.Join(Environment.NewLine, inputString);
                MessageBox.Show("Your text is now stored into an array of strings:\n\n" +
                    showString);
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to close the Application? ",
                "Exit", MessageBoxButtons.YesNo).ToString() == "Yes")
            {
                this.Close();
            }
        }
    }
}
