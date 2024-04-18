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
        // Static instance property
        private static frmMain _instance;
        public static frmMain Instance
        {
            get
            {
                if (_instance == null || _instance.IsDisposed)
                {
                    _instance = new frmMain();
                }
                return _instance;
            }
        }

        // You might have an events list or similar data structure to store events
        private List<EventForm> eventsList = new List<EventForm>();

        // Method to add an event to the events list
      
        private void NewCalendar_Click(object sender, EventArgs e)
        {
            // Create and show the CalendarForm when "New Calendar" is clicked
            Calendar calendar = new Calendar();
            calendar.Show();
            calendar.BuildNewCalendar(); // Build the new calendar
        }
        public frmMain()
        {
            InitializeComponent();
            InitializeMenu();
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.SuspendLayout();
            // 
            // frmMain
            // 
            resources.ApplyResources(this, "$this");
            this.Name = "frmMain";
            this.ResumeLayout(false);

        }
    }
}
