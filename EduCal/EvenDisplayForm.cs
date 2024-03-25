// EventDisplayForm.cs
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace EduCal
{
    public partial class EventDisplayForm : Form
    {
        private Label lblEventDetails;

        public EventDisplayForm(string date, List<EventForm> events)
        {
            //InitializeComponent();
            InitializeForm(date, events);
        }

        private void InitializeForm(string date, List<EventForm> events)
        {
            lblEventDetails = new Label();
            lblEventDetails.Text = $"Events for {date}:";

            foreach (var ev in events)
            {
                // Customize the format based on your event properties
                lblEventDetails.Text += $"\n- {ev.Title}: {ev.ShortDescription}";
            }

            this.Controls.Add(lblEventDetails);
        }
    }
}
