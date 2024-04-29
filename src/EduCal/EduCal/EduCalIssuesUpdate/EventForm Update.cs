using EduCal;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace EduCal
{

    public class EventForm : Form
    {

        private Label lblTitle;
        private TextBox txtTitle;
        private Label lblShortDescription;
        private TextBox txtShortDescription;
        private Label lblLongDescription;
        private TextBox txtLongDescription;
        private Label lblStartDate;
        private DateTimePicker dpStartDate;
        private Label lblEndDate;
        private Label lblLocation;
        private DateTimePicker dateTimePicker1;
        private TextBox txtLocation;
        private Button btnAdd;

        // Event Fields

        public string Title { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; } // Nullable if applicable
        public string Location { get; set; }

        // New properties for event repetition
        public RecurrencePattern Recurrence { get; set; }

        // Color coordination properties
        public string Color { get; set; }

        // Categorization properties
        public List<string> Categories { get; set; } = new List<string>();

        public EventForm()
        {
            // Initialize your form components here
            InitializeComponent();
        }


        // Method to retrieve the created event
        public EventForm GetEvent()
        {
            // Create and populate an Event instance with the form data
            EventForm newEvent = new EventForm
            {
                Title = this.Title,
                ShortDescription = this.ShortDescription,
                LongDescription = this.LongDescription,
                StartDate = this.StartDate,
                EndDate = this.EndDate,
                Location = this.Location,
                Recurrence = this.Recurrence,
                Color = this.Color,
                Categories = this.Categories
            };

            return newEvent;
        }




        // Add your other methods or event handlers here

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblShortDescription = new System.Windows.Forms.Label();
            this.txtShortDescription = new System.Windows.Forms.TextBox();
            this.lblLongDescription = new System.Windows.Forms.Label();
            this.txtLongDescription = new System.Windows.Forms.TextBox();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.dpStartDate = new System.Windows.Forms.DateTimePicker();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.lblLocation = new System.Windows.Forms.Label();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(28, 23);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Title:";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(34, 0);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(97, 20);
            this.txtTitle.TabIndex = 1;
            this.txtTitle.TextChanged += new System.EventHandler(this.txtTitle_TextChanged);
            // 
            // lblShortDescription
            // 
            this.lblShortDescription.Location = new System.Drawing.Point(0, 34);
            this.lblShortDescription.Name = "lblShortDescription";
            this.lblShortDescription.Size = new System.Drawing.Size(100, 23);
            this.lblShortDescription.TabIndex = 2;
            this.lblShortDescription.Text = "Short Description:";
            // 
            // txtShortDescription
            // 
            this.txtShortDescription.Location = new System.Drawing.Point(0, 60);
            this.txtShortDescription.Name = "txtShortDescription";
            this.txtShortDescription.Size = new System.Drawing.Size(100, 20);
            this.txtShortDescription.TabIndex = 3;
            // 
            // lblLongDescription
            // 
            this.lblLongDescription.Location = new System.Drawing.Point(3, 97);
            this.lblLongDescription.Name = "lblLongDescription";
            this.lblLongDescription.Size = new System.Drawing.Size(100, 23);
            this.lblLongDescription.TabIndex = 4;
            this.lblLongDescription.Text = "Long Description:";
            // 
            // txtLongDescription
            // 
            this.txtLongDescription.Location = new System.Drawing.Point(-3, 123);
            this.txtLongDescription.Multiline = true;
            this.txtLongDescription.Name = "txtLongDescription";
            this.txtLongDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLongDescription.Size = new System.Drawing.Size(159, 69);
            this.txtLongDescription.TabIndex = 5;
            // 
            // lblStartDate
            // 
            this.lblStartDate.Location = new System.Drawing.Point(321, 9);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(66, 23);
            this.lblStartDate.TabIndex = 6;
            this.lblStartDate.Text = "Start Date:";
            // 
            // dpStartDate
            // 
            this.dpStartDate.Location = new System.Drawing.Point(393, 19);
            this.dpStartDate.Name = "dpStartDate";
            this.dpStartDate.Size = new System.Drawing.Size(437, 20);
            this.dpStartDate.TabIndex = 7;
            // 
            // lblEndDate
            // 
            this.lblEndDate.Location = new System.Drawing.Point(321, 51);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(66, 23);
            this.lblEndDate.TabIndex = 8;
            this.lblEndDate.Text = "End Date:";
            // 
            // lblLocation
            // 
            this.lblLocation.Location = new System.Drawing.Point(0, 206);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(100, 23);
            this.lblLocation.TabIndex = 10;
            this.lblLocation.Text = "Location:";
            // 
            // txtLocation
            // 
            this.txtLocation.Location = new System.Drawing.Point(3, 232);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(100, 20);
            this.txtLocation.TabIndex = 11;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(393, 45);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(437, 20);
            this.dateTimePicker1.TabIndex = 12;
            // 
            // EventForm
            // 
            this.ClientSize = new System.Drawing.Size(1071, 602);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.lblShortDescription);
            this.Controls.Add(this.txtShortDescription);
            this.Controls.Add(this.lblLongDescription);
            this.Controls.Add(this.txtLongDescription);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.dpStartDate);
            this.Controls.Add(this.lblEndDate);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.txtLocation);
            this.Name = "EventForm";
            this.Text = "Add New Event";
            // btnAdd
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnAdd.Location = new System.Drawing.Point(10, 300); // Adjust the location as needed
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 30); // Adjust the size as needed
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "Add Event";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);

            this.Controls.Add(this.btnAdd);

            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void txtTitle_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // ... (your existing code)

            // Add logic to save the event details
            // You can use the GetEvent() method to get the event details
            EventForm newEvent = GetEvent();

            // Add the event to the centralized EventsList
            EventManager.AddEvent(newEvent);

            // Optionally, you can close the form after adding the event
            this.Close();
        }


        
        

        }
    }

