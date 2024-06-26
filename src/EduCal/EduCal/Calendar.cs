﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace EduCal
{
    public partial class Calendar : Form
    {
        private System.Windows.Forms.Label lblMonthYear;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private System.Windows.Forms.Button btnNextMonth;
        private System.Windows.Forms.Button btnPrevMonth;

        private DateTime currentMonth;

        public Calendar()
        {
            InitializeComponent();
            currentMonth = DateTime.Now;
            UpdateCalendar();
        }

        public void BuildNewCalendar()
        {
            currentMonth = DateTime.Now;
            UpdateCalendar();
            Show();
        }


        private void UpdateCalendar()
        {
            lblMonthYear.Text = currentMonth.ToString("MMMM yyyy");
            flowLayoutPanel.Controls.Clear();

            int daysInMonth = DateTime.DaysInMonth(currentMonth.Year, currentMonth.Month);
            DateTime firstDayOfMonth = new DateTime(currentMonth.Year, currentMonth.Month, 1);
            int startingDay = (int)firstDayOfMonth.DayOfWeek;

            Console.WriteLine($"Days in month: {daysInMonth}");
            Console.WriteLine($"First day of month: {firstDayOfMonth}");
            Console.WriteLine($"Starting day index: {startingDay}");

            for (int i = 0; i < startingDay; i++)
            {
                Label emptyLabel = new Label();
                emptyLabel.Text = "";
                flowLayoutPanel.Controls.Add(emptyLabel);
            }

            for (int day = 1; day <= daysInMonth; day++)
            {
                Button dayButton = new Button();
                dayButton.Text = day.ToString();
                DateTime dayDate = new DateTime(currentMonth.Year, currentMonth.Month, day);
                dayButton.Tag = dayDate;
                dayButton.Click += DayButton_Click;
                dayButton.Size = new Size(40, 40); // Adjust the size as needed

                Console.WriteLine($"Adding button for day: {dayDate.ToShortDateString()}");

                flowLayoutPanel.Controls.Add(dayButton);
            }
        }


        private void DayButton_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            DateTime selectedDate = (DateTime)clickedButton.Tag;

            // Create a new instance of EventForm
            EventForm eventForm = new EventForm(selectedDate);

            // Show the EventForm for entering new event details
            eventForm.Show();
        }

        /* private List<EventForm> GetEventsForDate(DateTime selectedDate, List<EventForm> eventsList)
         {
             List<EventForm> eventsForSelectedDay = new List<EventForm>();

             foreach (EventForm eventForm in eventsList)
             {
                 // Check if the day of the month is the same
                 if (eventForm.StartDate.Date.Day == selectedDate.Day)
                 {
                     // TODO: Add any additional conditions if needed
                     eventsForSelectedDay.Add(eventForm);
                 }
             }

             return eventsForSelectedDay;
         }*/

        private void UpdateMonth(int monthChange)
        {
            currentMonth = currentMonth.AddMonths(monthChange);
            UpdateCalendar();
        }

        private void btnNextMonth_Click(object sender, EventArgs e)
        {
            UpdateMonth(1); // Move to the next month (increase by 1)
        }

        private void btnPrevMonth_Click(object sender, EventArgs e)
        {
            UpdateMonth(-1); // Move to the previous month (decrease by 1)
        }

    }
}
