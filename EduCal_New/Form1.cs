using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EduCal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

    }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel17_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel12_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel16_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click_2(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel32_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel27_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel15_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel14_Paint(object sender, PaintEventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;

            // Get the calendar content from the GUI form
            string calendar = GenerateCalendar(now.Year);

            // Call the SaveCalendarToFile method
            SaveCalendarToFile(calendar, now.Year);
        }

        // Other event handlers and methods...

        private void SaveCalendarToFile(string content, int year)
        {
            try
            {
                FileHandler.SaveToFile(content, year);
                MessageBox.Show($"Calendar has been saved to file: Calendar_{year}.txt", "Save Successful");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving the calendar to file: {ex.Message}", "Save Error");
            }
        }

        private string GenerateCalendar(int year)
        {
            // Create a StringBuilder to store the calendar content
            StringBuilder calendarContent = new StringBuilder();
            calendarContent.AppendLine($"Calendar for Year {year}");
            calendarContent.AppendLine("------------------------");

            // Iterate through FlowLayoutPanel controls
            foreach (Control flowLayoutPanel in flowLayoutPanel1.Controls)
            {
                if (flowLayoutPanel is FlowLayoutPanel)
                {
                    // Iterate through Label controls in each FlowLayoutPanel
                    foreach (Control label in flowLayoutPanel.Controls)
                    {
                        if (label is Label)
                        {
                            // Append label text to the calendar content
                            calendarContent.AppendLine(((Label)label).Text);
                        }
                    }
                }
            }

            return calendarContent.ToString();
        }
    }
}
