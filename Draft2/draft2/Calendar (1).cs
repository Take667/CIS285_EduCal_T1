using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace EduCal
{
    public partial class Calendarform : Form
    {
        private System.Windows.Forms.Label lblMonthYear;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private System.Windows.Forms.Button btnNextMonth;
        private System.Windows.Forms.Button btnPrevMonth;
        private Button btnPrevious;
        private Button btnNext;
        private Label lbMonth;
        private Panel panel8;
        private Panel panel7;
        private Panel panel6;
        private Panel panel5;
        private Panel panel4;
        private Panel panel3;
        private Panel panel2;
        private Panel panel1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel9;
        private Panel panel10;
        private Panel panel11;
        private Panel panel12;
        private Panel panel13;
        private Panel panel14;
        private Panel panel15;
        private Panel panel16;
        private Panel panel17;
        private Panel panel18;
        private Panel panel19;
        private Panel panel20;
        private Panel panel21;
        private Panel panel22;
        private Panel panel23;
        private Panel panel24;
        private Panel panel25;
        private Panel panel26;
        private Panel panel27;
        private Panel panel28;
        private Panel panel29;
        private Panel panel30;
        private DateTime currentMonth;

        public Calendarform()
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

        private void InitializeComponent()
        {
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.lbMonth = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.panel14 = new System.Windows.Forms.Panel();
            this.panel15 = new System.Windows.Forms.Panel();
            this.panel16 = new System.Windows.Forms.Panel();
            this.panel17 = new System.Windows.Forms.Panel();
            this.panel18 = new System.Windows.Forms.Panel();
            this.panel19 = new System.Windows.Forms.Panel();
            this.panel20 = new System.Windows.Forms.Panel();
            this.panel21 = new System.Windows.Forms.Panel();
            this.panel22 = new System.Windows.Forms.Panel();
            this.panel23 = new System.Windows.Forms.Panel();
            this.panel24 = new System.Windows.Forms.Panel();
            this.panel25 = new System.Windows.Forms.Panel();
            this.panel26 = new System.Windows.Forms.Panel();
            this.panel27 = new System.Windows.Forms.Panel();
            this.panel28 = new System.Windows.Forms.Panel();
            this.panel29 = new System.Windows.Forms.Panel();
            this.panel30 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(12, 37);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(75, 23);
            this.btnPrevious.TabIndex = 0;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(661, 37);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 1;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            // 
            // lbMonth
            // 
            this.lbMonth.AutoSize = true;
            this.lbMonth.Location = new System.Drawing.Point(379, 47);
            this.lbMonth.Name = "lbMonth";
            this.lbMonth.Size = new System.Drawing.Size(37, 13);
            this.lbMonth.TabIndex = 2;
            this.lbMonth.Text = "Month";
            // 
            // panel8
            // 
            this.panel8.Location = new System.Drawing.Point(3, 92);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(78, 83);
            this.panel8.TabIndex = 7;
            // 
            // panel7
            // 
            this.panel7.Location = new System.Drawing.Point(502, 3);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(77, 83);
            this.panel7.TabIndex = 6;
            // 
            // panel6
            // 
            this.panel6.Location = new System.Drawing.Point(419, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(77, 83);
            this.panel6.TabIndex = 5;
            // 
            // panel5
            // 
            this.panel5.Location = new System.Drawing.Point(336, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(77, 83);
            this.panel5.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(253, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(77, 83);
            this.panel4.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(170, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(77, 83);
            this.panel3.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(87, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(77, 83);
            this.panel2.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(78, 83);
            this.panel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Controls.Add(this.panel2);
            this.flowLayoutPanel1.Controls.Add(this.panel3);
            this.flowLayoutPanel1.Controls.Add(this.panel4);
            this.flowLayoutPanel1.Controls.Add(this.panel5);
            this.flowLayoutPanel1.Controls.Add(this.panel6);
            this.flowLayoutPanel1.Controls.Add(this.panel7);
            this.flowLayoutPanel1.Controls.Add(this.panel8);
            this.flowLayoutPanel1.Controls.Add(this.panel9);
            this.flowLayoutPanel1.Controls.Add(this.panel10);
            this.flowLayoutPanel1.Controls.Add(this.panel11);
            this.flowLayoutPanel1.Controls.Add(this.panel12);
            this.flowLayoutPanel1.Controls.Add(this.panel13);
            this.flowLayoutPanel1.Controls.Add(this.panel14);
            this.flowLayoutPanel1.Controls.Add(this.panel15);
            this.flowLayoutPanel1.Controls.Add(this.panel16);
            this.flowLayoutPanel1.Controls.Add(this.panel17);
            this.flowLayoutPanel1.Controls.Add(this.panel18);
            this.flowLayoutPanel1.Controls.Add(this.panel19);
            this.flowLayoutPanel1.Controls.Add(this.panel20);
            this.flowLayoutPanel1.Controls.Add(this.panel21);
            this.flowLayoutPanel1.Controls.Add(this.panel22);
            this.flowLayoutPanel1.Controls.Add(this.panel23);
            this.flowLayoutPanel1.Controls.Add(this.panel24);
            this.flowLayoutPanel1.Controls.Add(this.panel25);
            this.flowLayoutPanel1.Controls.Add(this.panel26);
            this.flowLayoutPanel1.Controls.Add(this.panel27);
            this.flowLayoutPanel1.Controls.Add(this.panel28);
            this.flowLayoutPanel1.Controls.Add(this.panel29);
            this.flowLayoutPanel1.Controls.Add(this.panel30);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(140, 120);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(596, 444);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // panel9
            // 
            this.panel9.Location = new System.Drawing.Point(87, 92);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(78, 83);
            this.panel9.TabIndex = 8;
            // 
            // panel10
            // 
            this.panel10.Location = new System.Drawing.Point(171, 92);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(78, 83);
            this.panel10.TabIndex = 9;
            // 
            // panel11
            // 
            this.panel11.Location = new System.Drawing.Point(255, 92);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(78, 83);
            this.panel11.TabIndex = 10;
            // 
            // panel12
            // 
            this.panel12.Location = new System.Drawing.Point(339, 92);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(78, 83);
            this.panel12.TabIndex = 11;
            // 
            // panel13
            // 
            this.panel13.Location = new System.Drawing.Point(423, 92);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(78, 83);
            this.panel13.TabIndex = 12;
            // 
            // panel14
            // 
            this.panel14.Location = new System.Drawing.Point(507, 92);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(78, 83);
            this.panel14.TabIndex = 13;
            // 
            // panel15
            // 
            this.panel15.Location = new System.Drawing.Point(3, 181);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(78, 83);
            this.panel15.TabIndex = 14;
            // 
            // panel16
            // 
            this.panel16.Location = new System.Drawing.Point(87, 181);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(78, 83);
            this.panel16.TabIndex = 15;
            // 
            // panel17
            // 
            this.panel17.Location = new System.Drawing.Point(171, 181);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(78, 83);
            this.panel17.TabIndex = 16;
            // 
            // panel18
            // 
            this.panel18.Location = new System.Drawing.Point(255, 181);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(78, 83);
            this.panel18.TabIndex = 17;
            // 
            // panel19
            // 
            this.panel19.Location = new System.Drawing.Point(339, 181);
            this.panel19.Name = "panel19";
            this.panel19.Size = new System.Drawing.Size(78, 83);
            this.panel19.TabIndex = 18;
            // 
            // panel20
            // 
            this.panel20.Location = new System.Drawing.Point(423, 181);
            this.panel20.Name = "panel20";
            this.panel20.Size = new System.Drawing.Size(78, 83);
            this.panel20.TabIndex = 19;
            // 
            // panel21
            // 
            this.panel21.Location = new System.Drawing.Point(507, 181);
            this.panel21.Name = "panel21";
            this.panel21.Size = new System.Drawing.Size(78, 83);
            this.panel21.TabIndex = 20;
            // 
            // panel22
            // 
            this.panel22.Location = new System.Drawing.Point(3, 270);
            this.panel22.Name = "panel22";
            this.panel22.Size = new System.Drawing.Size(78, 83);
            this.panel22.TabIndex = 21;
            // 
            // panel23
            // 
            this.panel23.Location = new System.Drawing.Point(87, 270);
            this.panel23.Name = "panel23";
            this.panel23.Size = new System.Drawing.Size(78, 83);
            this.panel23.TabIndex = 22;
            // 
            // panel24
            // 
            this.panel24.Location = new System.Drawing.Point(171, 270);
            this.panel24.Name = "panel24";
            this.panel24.Size = new System.Drawing.Size(78, 83);
            this.panel24.TabIndex = 23;
            // 
            // panel25
            // 
            this.panel25.Location = new System.Drawing.Point(255, 270);
            this.panel25.Name = "panel25";
            this.panel25.Size = new System.Drawing.Size(78, 83);
            this.panel25.TabIndex = 24;
            // 
            // panel26
            // 
            this.panel26.Location = new System.Drawing.Point(339, 270);
            this.panel26.Name = "panel26";
            this.panel26.Size = new System.Drawing.Size(78, 83);
            this.panel26.TabIndex = 25;
            // 
            // panel27
            // 
            this.panel27.Location = new System.Drawing.Point(423, 270);
            this.panel27.Name = "panel27";
            this.panel27.Size = new System.Drawing.Size(78, 83);
            this.panel27.TabIndex = 26;
            // 
            // panel28
            // 
            this.panel28.Location = new System.Drawing.Point(507, 270);
            this.panel28.Name = "panel28";
            this.panel28.Size = new System.Drawing.Size(78, 83);
            this.panel28.TabIndex = 27;
            // 
            // panel29
            // 
            this.panel29.Location = new System.Drawing.Point(3, 359);
            this.panel29.Name = "panel29";
            this.panel29.Size = new System.Drawing.Size(78, 83);
            this.panel29.TabIndex = 28;
            // 
            // panel30
            // 
            this.panel30.Location = new System.Drawing.Point(87, 359);
            this.panel30.Name = "panel30";
            this.panel30.Size = new System.Drawing.Size(78, 83);
            this.panel30.TabIndex = 29;
            // 
            // Calendarform
            // 
            this.ClientSize = new System.Drawing.Size(782, 749);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.lbMonth);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Name = "Calendarform";
            this.Load += new System.EventHandler(this.Calendarform_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Calendarform_Load(object sender, EventArgs e)
        {

        }
    }
}
