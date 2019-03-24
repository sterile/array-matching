/*
 * Grading ID: M5477
 * Lab: 7
 * Due Date: Mar 24 2019
 * Course Section: 01
 * Description: This program looks through arrays to determine a grade assignment
 */
 
using System;
using System.Windows.Forms;

namespace array_matching
{
    public partial class Lab7 : Form
    {
        public Lab7()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            bool wpmTry; // A boolean for form verification
            uint wpm; // The words per minute reported by the user

            wpmTry = uint.TryParse(wpmInput.Text, out wpm);

            if (wpmTry)
            {
                uint[] wpmMinThreshold = { 0, 15, 30, 50, 75 }; // Array of lowest wpm per bracket
                string[] gradeReceived = { "F", "D", "C", "B", "A" }; // Array of related grades

                for (int x = 0; x <= wpmMinThreshold.Length - 1; ++x)
                {
                    if (wpm > wpmMinThreshold[x])
                    {
                        gradeLetterLabel.Text = gradeReceived[x];
                        x = wpmMinThreshold.Length; // Terminates loop early for efficiency
                    } 
                }
            }
            else
            {
                MessageBox.Show("Please use a valid integer when stating the words per minute.", "Form Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
    }
}
