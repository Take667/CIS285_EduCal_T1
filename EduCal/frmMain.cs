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
        public frmMain()
        {
            InitializeComponent();
        }


        private void NewCalendar_Click(object sender, EventArgs e)
        {
            // Create and show the CalendarForm when "New Calendar" is clicked
            Calendar calendar = new Calendar();
            calendar.Show();
            calendar.BuildNewCalendar(); // Build the new calendar
        }
    }
}
