using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EduCal {
	public partial class frmMain : Form {
        private object calendarControl;

        public frmMain () {
			InitializeComponent ();
		}

        private void Form1_Load(object sender, EventArgs e)
        {
            // Initialize the calendar to the current date
            calendarControl.SetDate(DateTime.Today);


            private void btnPreviousMonth_Click(object sender, EventArgs e)
        {
           
                // Get the current displayed date
                DateTime currentDisplayedDate = calendarControl.SelectionStart;

                // Calculate the previous month
                DateTime previousMonth = currentDisplayedDate.AddMonths(-1);

            }

        private void btnNextMonth_Click(object sender, EventArgs e)
        {
            
            {
                // Get the current displayed date
                DateTime currentDisplayedDate = calendarControl.SelectionStart;

                // Calculate the next month
                DateTime nextMonth = currentDisplayedDate.AddMonths(1);

            }

            private void label3_Click(object sender, EventArgs e)
        {
            
           
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        
        private void panel20_Paint(object sender, PaintEventArgs e)
        {
            
           
        }

        
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        
        private void panel14_Paint(object sender, PaintEventArgs e)
        {
            
        }
        
        
    }
}
