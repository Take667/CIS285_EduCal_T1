using System;
using System.Collections.Generic;
using System.Windows.Forms;
using EduCal;
using Newtonsoft.Json;
using System.IO;


namespace EduCal
{
    partial class frmMain : Form
    {
        private List<EventForm> events = new List<EventForm>(); // Assuming you have a list to store events

   

        private void InitializeMenu()
        {
            MenuStrip menuStrip = new MenuStrip();

            ToolStripMenuItem fileMenu = new ToolStripMenuItem("File");


            ToolStripMenuItem newCalendarItem = new ToolStripMenuItem("New Calendar");
            newCalendarItem.Click += NewCalendar_Click;

            ToolStripMenuItem newEventItem = new ToolStripMenuItem("New Event");
            
            newEventItem.Click += NewEvent_Click;

            ToolStripMenuItem openFileItem = new ToolStripMenuItem("Open");
            openFileItem.Click += OpenFile_Click;
            ToolStripMenuItem saveFileItem = new ToolStripMenuItem("Save");
            saveFileItem.Click += SaveFile_Click;


            ToolStripMenuItem saveAsFileItem = new ToolStripMenuItem("Save As...");
            saveAsFileItem.Click += SaveAsFile_Click; // Event handler for Save As

            ToolStripMenuItem exitItem = new ToolStripMenuItem("Exit");
            exitItem.Click += Exit_Click; // Event handler for Exit

            fileMenu.DropDownItems.Add(newCalendarItem);
            fileMenu.DropDownItems.Add(newEventItem);
            fileMenu.DropDownItems.Add(openFileItem);
            fileMenu.DropDownItems.Add(saveFileItem);
            fileMenu.DropDownItems.Add(saveAsFileItem); // Add Save As button
            fileMenu.DropDownItems.Add(exitItem); // Add Exit button

            menuStrip.Items.Add(fileMenu);



            ToolStripMenuItem editMenu = new ToolStripMenuItem("Edit");

            ToolStripMenuItem eventForm = new ToolStripMenuItem("Event Form");
            eventForm.Click += NewEventForm_Click;
            ToolStripMenuItem settings = new ToolStripMenuItem("Settings");
            settings.Click += NewSettings_Click;

            editMenu.DropDownItems.Add(eventForm);
            editMenu.DropDownItems.Add(settings);

            menuStrip.Items.Add(editMenu);
            ToolStripMenuItem aboutMenu = new ToolStripMenuItem("About");

            ToolStripMenuItem aboutForm = new ToolStripMenuItem("About Form");
            aboutForm.Click += NewAboutForm_Click;
            aboutMenu.DropDownItems.Add(aboutForm);
            menuStrip.Items.Add(aboutMenu);

            this.Controls.Add(menuStrip);

           
        }
       
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.SuspendLayout();
            // 
            // frmMain
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.ResumeLayout(false);
        }

       /* private void NewCalendar_Click(object sender, EventArgs e)
        {
            // Implement logic for creating a new calendar
            MessageBox.Show("Implement logic for creating a new calendar");
        }*/





    }
}
