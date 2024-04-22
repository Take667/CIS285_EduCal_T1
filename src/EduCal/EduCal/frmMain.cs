using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

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
        public void AddEventToList(EventForm newEvent)
        {
            eventsList.Add(newEvent);

            // Implement any additional logic you need
            // For example, update the UI to reflect the new event
        }
        private void NewCalendar_Click(object sender, EventArgs e)
        {
            // Create and show the CalendarForm when "New Calendar" is clicked
            Calendar calendar = new Calendar();
            //calendar.Show();
            calendar.BuildNewCalendar(); // Build the new calendar
        }
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
            // Serialize the list of events to JSON
            string json = Newtonsoft.Json.JsonConvert.SerializeObject(events);

            // Specify the file path
            string fileName = "calendar.json";

            // Write the JSON data to the file
            System.IO.File.WriteAllText(fileName, json);

            MessageBox.Show("File saved successfully");
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
                try
                {
                    // Get the selected file name
                    string fileName = saveFileDialog.FileName;

                    // Call the method to save the calendar data to the selected file
                    // For example, if you have a list of events, you can serialize it to JSON
                    // Replace 'events' with your actual data
                    string jsonData = JsonConvert.SerializeObject(events); // Using JSON.NET for serialization

                    // Write the JSON data to the file
                    File.WriteAllText(fileName, jsonData);

                    MessageBox.Show("File saved successfully.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while saving the file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        public frmMain()
        {
            InitializeComponent();
            InitializeMenu();
        }
    }
}
