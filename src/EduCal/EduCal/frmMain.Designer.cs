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
            

            ToolStripMenuItem newEventItem = new ToolStripMenuItem("New Event");
            
        

            ToolStripMenuItem openFileItem = new ToolStripMenuItem("Open");
        
            ToolStripMenuItem saveFileItem = new ToolStripMenuItem("Save");
            


            ToolStripMenuItem saveAsFileItem = new ToolStripMenuItem("Save As...");
            

            ToolStripMenuItem exitItem = new ToolStripMenuItem("Exit");
    

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
            

            editMenu.DropDownItems.Add(eventForm);
            editMenu.DropDownItems.Add(settings);

            menuStrip.Items.Add(editMenu);
            ToolStripMenuItem aboutMenu = new ToolStripMenuItem("About");

            ToolStripMenuItem aboutForm = new ToolStripMenuItem("About Form");
    
            aboutMenu.DropDownItems.Add(aboutForm);
            menuStrip.Items.Add(aboutMenu);

            this.Controls.Add(menuStrip);

           
        }
        private void Exit_Click(object sender, EventArgs e)
        {
            // Display a confirmation dialog before exiting
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Check the user's response
            if (result == DialogResult.Yes)
            {
                // Exit the application
                Application.Exit();
            }
        }

        private void SaveAsFile_Click(object sender, EventArgs e)
        {
            // Create a SaveFileDialog instance
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            // Set properties of the save file dialog
            saveFileDialog.Filter = "iCal files (*.ical)|*.ical|All files (*.*)|*.*";
            saveFileDialog.FilterIndex = 1;
            saveFileDialog.RestoreDirectory = true;

            // Show the save file dialog
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Get the selected file name
                string fileName = saveFileDialog.FileName;

                // Call the method to save the calendar data to the selected file
                // Replace calendarData with the actual calendar data you want to save
                // ExportHelper.ExportToICal(fileName, calendarData);
            }
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
