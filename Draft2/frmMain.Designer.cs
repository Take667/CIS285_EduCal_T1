using System;
using System.Collections.Generic;
using System.Windows.Forms;
using EduCal;

namespace EduCal
{
    partial class frmMain : Form
    {
        private List<EventForm> events = new List<EventForm>(); // Assuming you have a list to store events

   


        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1924, 1061);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(48, 22, 48, 22);
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Education Calendar";
            this.ResumeLayout(false);

        }

       /* private void NewCalendar_Click(object sender, EventArgs e)
        {
            // Implement logic for creating a new calendar
            MessageBox.Show("Implement logic for creating a new calendar");
        }*/



    }
}
