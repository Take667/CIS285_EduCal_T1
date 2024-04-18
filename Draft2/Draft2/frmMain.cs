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
            calendar.Show();
            calendar.BuildNewCalendar(); // Build the new calendar
        }
        public frmMain()
        {
            InitializeComponent();
            InitializeMenu();
        }

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
