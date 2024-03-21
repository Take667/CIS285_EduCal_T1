using EduCal;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace EduCaldraft2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(486, 53);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(49, 62);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(628, 514);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.ResumeLayout(false);

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e) { }

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private System.Windows.Forms.Button btnNextMonth;
        private System.Windows.Forms.Button btnPrevMonth;

        private DateTime currentMonth;
        private Button button1;
        private Button button2;
        private object lblMonthYear;

        public class Education Calendar()
        
        
        {
            InitializeComponent();
            currentMonth = DateTime.Now;
            UpdateCalendar();
        }
    

        public void BuildNewCalendar()
        {
            currentMonth = DateTime.Now;
            UpdateCalendar();
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

            // Get the events for the selected date from the centralized EventsList
            List<EventForm> eventsForDate = EventManager.EventsList
                .Where(ev => ev.StartDate.Date == selectedDate.Date)
                .ToList();

            // Display the events using the new form
            EventDisplayForm eventDisplayForm = new EventDisplayForm(selectedDate.ToShortDateString(), eventsForDate);
            eventDisplayForm.Show();
        }

        private List<EventForm> GetEventsForDate(DateTime selectedDate, List<EventForm> eventsList)
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
        }


        private void btnNextMonth_Click(object sender, EventArgs e)
        {
            currentMonth = currentMonth.AddMonths(1);
            UpdateCalendar();
        }

        private void btnPrevMonth_Click(object sender, EventArgs e)
        {
            currentMonth = currentMonth.AddMonths(-1);
            UpdateCalendar();
        }
    }
}



