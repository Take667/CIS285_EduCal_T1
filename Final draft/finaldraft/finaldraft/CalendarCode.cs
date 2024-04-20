using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EduCal
{
    internal class CalendarCode
    {
        public partial class Calendar 
        {
            private readonly object dateTimePicker;

            public Calendar()
            {
             
            }

            private void InitializeComponent()
            {
                throw new NotImplementedException();
            }

            private void MainForm_Load(object sender, EventArgs e)
            {
                // Set the default date to today
                dateTimePicker.Value = DateTime.Today;
                UpdateCalendar();
            }

            private void dateTimePicker_ValueChanged(object sender, EventArgs e)
            {
                UpdateCalendar();
            }

            private void UpdateCalendar()
            {
                // Clear any existing items in the list view
                listView.Items.Clear();

                // Get the selected date from the DateTimePicker
                DateTime selectedDate = dateTimePicker.Value;

                // Add some sample events for demonstration
                AddEvent(selectedDate);
                AddEvent(selectedDate);
                AddEvent(selectedDate);
            }

            private void AddEvent(DateTime date, string eventName, string time)
            {
                // Create a ListViewItem with event details
                string[] row = { date.ToShortDateString(), eventName, time };
                ListViewItem item = new ListViewItem(row);

                // Add the item to the ListView
                listView.Items.Add(item);
            }
        }
    }
}

