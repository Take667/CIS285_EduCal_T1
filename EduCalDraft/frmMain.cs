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
        private DateTime currentMonth;



        public frmMain () {
			InitializeComponent ();
            currentMonth = DateTime.Today; // Initialize currentMonth to the current month
            DisplayCalendar(currentMonth);
        }


        private void DisplayCalendar(DateTime currentMonth)
        {
            throw new NotImplementedException();
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

        private void frmMain_Load(object sender, EventArgs e)
        {

        }
    }
}
