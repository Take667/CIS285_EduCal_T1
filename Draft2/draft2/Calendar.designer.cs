using System.Windows.Forms;

namespace EduCal
{
    partial class Calendar : Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }


        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblMonthYear = new System.Windows.Forms.Label();
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.btnNextMonth = new System.Windows.Forms.Button();
            this.btnPrevMonth = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMonthYear
            // 
            this.lblMonthYear.AutoSize = true;
            this.lblMonthYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonthYear.Location = new System.Drawing.Point(12, 9);
            this.lblMonthYear.Name = "lblMonthYear";
            this.lblMonthYear.Size = new System.Drawing.Size(152, 24);
            this.lblMonthYear.TabIndex = 0;
            this.lblMonthYear.Text = "Month and Year";
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.Location = new System.Drawing.Point(12, 42);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(360, 208);
            this.flowLayoutPanel.TabIndex = 1;
            // 
            // btnNextMonth
            // 
            this.btnNextMonth.Location = new System.Drawing.Point(297, 9);
            this.btnNextMonth.Name = "btnNextMonth";
            this.btnNextMonth.Size = new System.Drawing.Size(75, 23);
            this.btnNextMonth.TabIndex = 2;
            this.btnNextMonth.Text = "Next Month";
            this.btnNextMonth.UseVisualStyleBackColor = true;
            this.btnNextMonth.Click += new System.EventHandler(this.btnNextMonth_Click);
            // 
            // btnPrevMonth
            // 
            this.btnPrevMonth.Location = new System.Drawing.Point(216, 9);
            this.btnPrevMonth.Name = "btnPrevMonth";
            this.btnPrevMonth.Size = new System.Drawing.Size(75, 23);
            this.btnPrevMonth.TabIndex = 3;
            this.btnPrevMonth.Text = "Previous Month";
            this.btnPrevMonth.UseVisualStyleBackColor = true;
            this.btnPrevMonth.Click += new System.EventHandler(this.btnPrevMonth_Click);
            // 
            // CalendarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.btnPrevMonth);
            this.Controls.Add(this.btnNextMonth);
            this.Controls.Add(this.flowLayoutPanel);
            this.Controls.Add(this.lblMonthYear);
            this.Name = "Calendar";
            this.Text = "Calendar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}
