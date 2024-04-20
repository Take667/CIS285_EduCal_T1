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
		public frmMain () {
			InitializeComponent ();
		}
        
      
          //Event handler for when label3 is clicked
        private void label3_Click(object sender, EventArgs e)
        {
            //Add code here to respond to the label3 click event
            MessageBox.Show("Label 3 was clicked!");
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        // Event handler for when label5 is clicked
        private void panel20_Paint(object sender, PaintEventArgs e)
        {
            // Add code here to respond to the label5 click event
            MessageBox.Show("Label 5 was clicked!");
        }

        // Event handler for when panel2 is painted
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        // Event handler for when panel14 is painted
        private void panel14_Paint(object sender, PaintEventArgs e)
        {
            
        }
    }
}
