using System;
using System.Collections.Generic;
using System.Windows.Forms;
using EduCal;

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

            fileMenu.DropDownItems.Add(newCalendarItem);
            fileMenu.DropDownItems.Add(newEventItem);
            fileMenu.DropDownItems.Add(openFileItem);
            fileMenu.DropDownItems.Add(saveFileItem);

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

        private void NewEvent_Click(object sender, EventArgs e)
        {
            // Implement logic for creating a new Event
            EventForm eventForm = new EventForm(); // Assuming you have an EventForm for data entry
            if (eventForm.ShowDialog() == DialogResult.OK)
            {
                EventForm newEvent = eventForm.GetEvent(); // Implement a method in EventForm to get the created event
                events.Add(newEvent);
            }
        }
        private void NewEventForm_Click(object sender, EventArgs e)
        {
            // Implement logic for creating a new Event
            EventForm eventForm = new EventForm(); // Assuming you have an EventForm for data entry
            if (eventForm.ShowDialog() == DialogResult.OK)
            {
                EventForm newEvent = eventForm.GetEvent(); // Implement a method in EventForm to get the created event
                events.Add(newEvent);
            }
        }
        private void NewSettings_Click(object sender, EventArgs e)
        {
            // Create an instance of the SettingsForm
            SettingsForm settingsForm = new SettingsForm();

            // Show the SettingsForm
            settingsForm.Show();
        }


        private void OpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Implement logic for opening the file
                MessageBox.Show($"Opening file: {openFileDialog.FileName}");
            }
        }
        private void NewAboutForm_Click(object sender, EventArgs e)
        {
            // Create an instance of the SettingsForm
            frmAbout aboutForm = new frmAbout();
            aboutForm.Show();
        }
        private void SaveFile_Click(object sender, EventArgs e)
        {
            // TODO: Replace 'yourCalendarData' with the actual variable containing your calendar data
            List<EventForm> yourCalendarData = events; // Replace this line

            string fileName = "calendar.json"; // Provide the desired file path

            FileHelper.SaveToFile(fileName, yourCalendarData);
            MessageBox.Show("File saved successfully");
        }


    }
}
