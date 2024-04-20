using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EduCal
{
    internal class MenuCode
    {
       InitializeComponent();
            

            private void newEventToolStripMenuItem_Click(object sender, EventArgs e)
            {
                MessageBox.Show("Creating a new event...");
            }

            private void newCalendarToolStripMenuItem_Click(object sender, EventArgs e)
            {
                MessageBox.Show("Creating a new calendar...");
            }

            private void openToolStripMenuItem_Click(object sender, EventArgs e)
            {
                MessageBox.Show("Opening file dialog...");
                // Add your file open logic here
            }

            private void saveToolStripMenuItem_Click(object sender, EventArgs e)
            {
                MessageBox.Show("Saving current file...");
                // Add your file save logic here
            }

            private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
            {
                MessageBox.Show("Saving file dialog...");
                // Add your file save as logic here
            }

            private void exitToolStripMenuItem_Click(object sender, EventArgs e)
            {
                MessageBox.Show("Exiting program...");
                Application.Exit();
            }

            private void eventToolStripMenuItem_Click(object sender, EventArgs e)
            {
                MessageBox.Show("Editing event...");
                // Add your event editing logic here
            }

            private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
            {
                MessageBox.Show("Editing settings...");
                // Add your settings editing logic here
            }

            private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
            {
                MessageBox.Show("About...");
                // Add your about logic here
            }
        }
    }



