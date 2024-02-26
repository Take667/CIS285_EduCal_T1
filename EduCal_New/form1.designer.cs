using static System.Net.Mime.MediaTypeNames;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace EduCal
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            flowLayoutPanel15 = new FlowLayoutPanel();
            flowLayoutPanel8 = new FlowLayoutPanel();
            flowLayoutPanel7 = new FlowLayoutPanel();
            flowLayoutPanel6 = new FlowLayoutPanel();
            flowLayoutPanel4 = new FlowLayoutPanel();
            flowLayoutPanel3 = new FlowLayoutPanel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            flowLayoutPanel5 = new FlowLayoutPanel();
            flowLayoutPanel9 = new FlowLayoutPanel();
            flowLayoutPanel10 = new FlowLayoutPanel();
            flowLayoutPanel11 = new FlowLayoutPanel();
            flowLayoutPanel12 = new FlowLayoutPanel();
            flowLayoutPanel13 = new FlowLayoutPanel();
            flowLayoutPanel14 = new FlowLayoutPanel();
            flowLayoutPanel16 = new FlowLayoutPanel();
            flowLayoutPanel17 = new FlowLayoutPanel();
            flowLayoutPanel18 = new FlowLayoutPanel();
            flowLayoutPanel19 = new FlowLayoutPanel();
            flowLayoutPanel20 = new FlowLayoutPanel();
            flowLayoutPanel21 = new FlowLayoutPanel();
            flowLayoutPanel22 = new FlowLayoutPanel();
            flowLayoutPanel23 = new FlowLayoutPanel();
            flowLayoutPanel24 = new FlowLayoutPanel();
            flowLayoutPanel25 = new FlowLayoutPanel();
            flowLayoutPanel26 = new FlowLayoutPanel();
            flowLayoutPanel27 = new FlowLayoutPanel();
            flowLayoutPanel28 = new FlowLayoutPanel();
            flowLayoutPanel29 = new FlowLayoutPanel();
            flowLayoutPanel30 = new FlowLayoutPanel();
            flowLayoutPanel31 = new FlowLayoutPanel();
            flowLayoutPanel32 = new FlowLayoutPanel();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(1161, 636);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 1;
            button1.Text = "Next";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(1027, 636);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 2;
            button2.Text = "Previous";
            button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(91, 74);
            label1.Name = "label1";
            label1.Size = new Size(81, 25);
            label1.TabIndex = 3;
            label1.Text = "SUNDAY";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(277, 74);
            label2.Name = "label2";
            label2.Size = new Size(89, 25);
            label2.TabIndex = 4;
            label2.Text = "MONDAY";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(441, 74);
            label3.Name = "label3";
            label3.Size = new Size(86, 25);
            label3.TabIndex = 5;
            label3.Text = "TUESDAY";
            label3.Click += label3_Click_1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(613, 74);
            label4.Name = "label4";
            label4.Size = new Size(108, 25);
            label4.TabIndex = 6;
            label4.Text = "WEDNSDAY";
            label4.Click += label4_Click_2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(789, 74);
            label5.Name = "label5";
            label5.Size = new Size(101, 25);
            label5.TabIndex = 7;
            label5.Text = "THURSDAY";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(951, 74);
            label6.Name = "label6";
            label6.Size = new Size(71, 25);
            label6.TabIndex = 8;
            label6.Text = "FRIDAY";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(1100, 74);
            label7.Name = "label7";
            label7.Size = new Size(99, 25);
            label7.TabIndex = 9;
            label7.Text = "SATURDAY";
            // 
            // flowLayoutPanel15
            // 
            flowLayoutPanel15.Location = new Point(1026, 3);
            flowLayoutPanel15.Name = "flowLayoutPanel15";
            flowLayoutPanel15.Size = new Size(140, 108);
            flowLayoutPanel15.TabIndex = 22;
            flowLayoutPanel15.Paint += flowLayoutPanel15_Paint;
            // 
            // flowLayoutPanel8
            // 
            flowLayoutPanel8.Location = new Point(863, 3);
            flowLayoutPanel8.Name = "flowLayoutPanel8";
            flowLayoutPanel8.Size = new Size(157, 108);
            flowLayoutPanel8.TabIndex = 14;
            // 
            // flowLayoutPanel7
            // 
            flowLayoutPanel7.Location = new Point(700, 3);
            flowLayoutPanel7.Name = "flowLayoutPanel7";
            flowLayoutPanel7.Size = new Size(157, 108);
            flowLayoutPanel7.TabIndex = 13;
            // 
            // flowLayoutPanel6
            // 
            flowLayoutPanel6.Location = new Point(533, 3);
            flowLayoutPanel6.Name = "flowLayoutPanel6";
            flowLayoutPanel6.Size = new Size(161, 108);
            flowLayoutPanel6.TabIndex = 12;
            flowLayoutPanel6.Paint += flowLayoutPanel6_Paint;
            // 
            // flowLayoutPanel4
            // 
            flowLayoutPanel4.Location = new Point(358, 3);
            flowLayoutPanel4.Name = "flowLayoutPanel4";
            flowLayoutPanel4.Size = new Size(169, 108);
            flowLayoutPanel4.TabIndex = 10;
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.Location = new Point(183, 3);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(169, 108);
            flowLayoutPanel3.TabIndex = 9;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Location = new Point(3, 3);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(174, 108);
            flowLayoutPanel2.TabIndex = 8;
            flowLayoutPanel2.Paint += flowLayoutPanel2_Paint;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(flowLayoutPanel2);
            flowLayoutPanel1.Controls.Add(flowLayoutPanel3);
            flowLayoutPanel1.Controls.Add(flowLayoutPanel4);
            flowLayoutPanel1.Controls.Add(flowLayoutPanel6);
            flowLayoutPanel1.Controls.Add(flowLayoutPanel7);
            flowLayoutPanel1.Controls.Add(flowLayoutPanel8);
            flowLayoutPanel1.Controls.Add(flowLayoutPanel15);
            flowLayoutPanel1.Controls.Add(flowLayoutPanel5);
            flowLayoutPanel1.Controls.Add(flowLayoutPanel9);
            flowLayoutPanel1.Controls.Add(flowLayoutPanel10);
            flowLayoutPanel1.Controls.Add(flowLayoutPanel11);
            flowLayoutPanel1.Controls.Add(flowLayoutPanel12);
            flowLayoutPanel1.Controls.Add(flowLayoutPanel13);
            flowLayoutPanel1.Controls.Add(flowLayoutPanel14);
            flowLayoutPanel1.Controls.Add(flowLayoutPanel16);
            flowLayoutPanel1.Controls.Add(flowLayoutPanel17);
            flowLayoutPanel1.Controls.Add(flowLayoutPanel18);
            flowLayoutPanel1.Controls.Add(flowLayoutPanel19);
            flowLayoutPanel1.Controls.Add(flowLayoutPanel20);
            flowLayoutPanel1.Controls.Add(flowLayoutPanel21);
            flowLayoutPanel1.Controls.Add(flowLayoutPanel22);
            flowLayoutPanel1.Controls.Add(flowLayoutPanel23);
            flowLayoutPanel1.Controls.Add(flowLayoutPanel24);
            flowLayoutPanel1.Controls.Add(flowLayoutPanel25);
            flowLayoutPanel1.Controls.Add(flowLayoutPanel26);
            flowLayoutPanel1.Controls.Add(flowLayoutPanel27);
            flowLayoutPanel1.Controls.Add(flowLayoutPanel28);
            flowLayoutPanel1.Controls.Add(flowLayoutPanel29);
            flowLayoutPanel1.Controls.Add(flowLayoutPanel30);
            flowLayoutPanel1.Controls.Add(flowLayoutPanel31);
            flowLayoutPanel1.Controls.Add(flowLayoutPanel32);
            flowLayoutPanel1.Location = new Point(33, 121);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1400, 493);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel5
            // 
            flowLayoutPanel5.Location = new Point(1172, 3);
            flowLayoutPanel5.Name = "flowLayoutPanel5";
            flowLayoutPanel5.Size = new Size(174, 108);
            flowLayoutPanel5.TabIndex = 23;
            // 
            // flowLayoutPanel9
            // 
            flowLayoutPanel9.Location = new Point(3, 117);
            flowLayoutPanel9.Name = "flowLayoutPanel9";
            flowLayoutPanel9.Size = new Size(174, 108);
            flowLayoutPanel9.TabIndex = 24;
            // 
            // flowLayoutPanel10
            // 
            flowLayoutPanel10.Location = new Point(183, 117);
            flowLayoutPanel10.Name = "flowLayoutPanel10";
            flowLayoutPanel10.Size = new Size(174, 108);
            flowLayoutPanel10.TabIndex = 25;
            // 
            // flowLayoutPanel11
            // 
            flowLayoutPanel11.Location = new Point(363, 117);
            flowLayoutPanel11.Name = "flowLayoutPanel11";
            flowLayoutPanel11.Size = new Size(169, 108);
            flowLayoutPanel11.TabIndex = 26;
            // 
            // flowLayoutPanel12
            // 
            flowLayoutPanel12.Location = new Point(538, 117);
            flowLayoutPanel12.Name = "flowLayoutPanel12";
            flowLayoutPanel12.Size = new Size(166, 108);
            flowLayoutPanel12.TabIndex = 27;
            // 
            // flowLayoutPanel13
            // 
            flowLayoutPanel13.Location = new Point(710, 117);
            flowLayoutPanel13.Name = "flowLayoutPanel13";
            flowLayoutPanel13.Size = new Size(159, 108);
            flowLayoutPanel13.TabIndex = 28;
            // 
            // flowLayoutPanel14
            // 
            flowLayoutPanel14.Location = new Point(875, 117);
            flowLayoutPanel14.Name = "flowLayoutPanel14";
            flowLayoutPanel14.Size = new Size(140, 108);
            flowLayoutPanel14.TabIndex = 29;
            // 
            // flowLayoutPanel16
            // 
            flowLayoutPanel16.Location = new Point(1021, 117);
            flowLayoutPanel16.Name = "flowLayoutPanel16";
            flowLayoutPanel16.Size = new Size(152, 108);
            flowLayoutPanel16.TabIndex = 30;
            // 
            // flowLayoutPanel17
            // 
            flowLayoutPanel17.Location = new Point(1179, 117);
            flowLayoutPanel17.Name = "flowLayoutPanel17";
            flowLayoutPanel17.Size = new Size(169, 108);
            flowLayoutPanel17.TabIndex = 31;
            // 
            // flowLayoutPanel18
            // 
            flowLayoutPanel18.Location = new Point(3, 231);
            flowLayoutPanel18.Name = "flowLayoutPanel18";
            flowLayoutPanel18.Size = new Size(169, 108);
            flowLayoutPanel18.TabIndex = 32;
            // 
            // flowLayoutPanel19
            // 
            flowLayoutPanel19.Location = new Point(178, 231);
            flowLayoutPanel19.Name = "flowLayoutPanel19";
            flowLayoutPanel19.Size = new Size(174, 108);
            flowLayoutPanel19.TabIndex = 33;
            // 
            // flowLayoutPanel20
            // 
            flowLayoutPanel20.Location = new Point(358, 231);
            flowLayoutPanel20.Name = "flowLayoutPanel20";
            flowLayoutPanel20.Size = new Size(169, 108);
            flowLayoutPanel20.TabIndex = 34;
            // 
            // flowLayoutPanel21
            // 
            flowLayoutPanel21.Location = new Point(533, 231);
            flowLayoutPanel21.Name = "flowLayoutPanel21";
            flowLayoutPanel21.Size = new Size(157, 108);
            flowLayoutPanel21.TabIndex = 35;
            // 
            // flowLayoutPanel22
            // 
            flowLayoutPanel22.Location = new Point(696, 231);
            flowLayoutPanel22.Name = "flowLayoutPanel22";
            flowLayoutPanel22.Size = new Size(161, 108);
            flowLayoutPanel22.TabIndex = 36;
            // 
            // flowLayoutPanel23
            // 
            flowLayoutPanel23.Location = new Point(863, 231);
            flowLayoutPanel23.Name = "flowLayoutPanel23";
            flowLayoutPanel23.Size = new Size(150, 108);
            flowLayoutPanel23.TabIndex = 37;
            // 
            // flowLayoutPanel24
            // 
            flowLayoutPanel24.Location = new Point(1019, 231);
            flowLayoutPanel24.Name = "flowLayoutPanel24";
            flowLayoutPanel24.Size = new Size(162, 108);
            flowLayoutPanel24.TabIndex = 38;
            // 
            // flowLayoutPanel25
            // 
            flowLayoutPanel25.Location = new Point(1187, 231);
            flowLayoutPanel25.Name = "flowLayoutPanel25";
            flowLayoutPanel25.Size = new Size(169, 108);
            flowLayoutPanel25.TabIndex = 39;
            // 
            // flowLayoutPanel26
            // 
            flowLayoutPanel26.Location = new Point(3, 345);
            flowLayoutPanel26.Name = "flowLayoutPanel26";
            flowLayoutPanel26.Size = new Size(174, 108);
            flowLayoutPanel26.TabIndex = 40;
            // 
            // flowLayoutPanel27
            // 
            flowLayoutPanel27.Location = new Point(183, 345);
            flowLayoutPanel27.Name = "flowLayoutPanel27";
            flowLayoutPanel27.Size = new Size(174, 108);
            flowLayoutPanel27.TabIndex = 41;
            // 
            // flowLayoutPanel28
            // 
            flowLayoutPanel28.Location = new Point(363, 345);
            flowLayoutPanel28.Name = "flowLayoutPanel28";
            flowLayoutPanel28.Size = new Size(164, 108);
            flowLayoutPanel28.TabIndex = 42;
            // 
            // flowLayoutPanel29
            // 
            flowLayoutPanel29.Location = new Point(533, 345);
            flowLayoutPanel29.Name = "flowLayoutPanel29";
            flowLayoutPanel29.Size = new Size(155, 108);
            flowLayoutPanel29.TabIndex = 43;
            // 
            // flowLayoutPanel30
            // 
            flowLayoutPanel30.Location = new Point(694, 345);
            flowLayoutPanel30.Name = "flowLayoutPanel30";
            flowLayoutPanel30.Size = new Size(163, 108);
            flowLayoutPanel30.TabIndex = 44;
            // 
            // flowLayoutPanel31
            // 
            flowLayoutPanel31.Location = new Point(863, 345);
            flowLayoutPanel31.Name = "flowLayoutPanel31";
            flowLayoutPanel31.Size = new Size(146, 108);
            flowLayoutPanel31.TabIndex = 45;
            // 
            // flowLayoutPanel32
            // 
            flowLayoutPanel32.Location = new Point(1015, 345);
            flowLayoutPanel32.Name = "flowLayoutPanel32";
            flowLayoutPanel32.Size = new Size(146, 108);
            flowLayoutPanel32.TabIndex = 46;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1231, 700);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(flowLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private Button button2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private FlowLayoutPanel flowLayoutPanel15;
        private FlowLayoutPanel flowLayoutPanel8;
        private FlowLayoutPanel flowLayoutPanel7;
        private FlowLayoutPanel flowLayoutPanel6;
        private FlowLayoutPanel flowLayoutPanel4;
        private FlowLayoutPanel flowLayoutPanel3;
        private FlowLayoutPanel flowLayoutPanel2;
        private FlowLayoutPanel flowLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel5;
        private FlowLayoutPanel flowLayoutPanel9;
        private FlowLayoutPanel flowLayoutPanel10;
        private FlowLayoutPanel flowLayoutPanel11;
        private FlowLayoutPanel flowLayoutPanel12;
        private FlowLayoutPanel flowLayoutPanel13;
        private FlowLayoutPanel flowLayoutPanel14;
        private FlowLayoutPanel flowLayoutPanel16;
        private FlowLayoutPanel flowLayoutPanel17;
        private FlowLayoutPanel flowLayoutPanel18;
        private FlowLayoutPanel flowLayoutPanel19;
        private FlowLayoutPanel flowLayoutPanel20;
        private FlowLayoutPanel flowLayoutPanel21;
        private FlowLayoutPanel flowLayoutPanel22;
        private FlowLayoutPanel flowLayoutPanel23;
        private FlowLayoutPanel flowLayoutPanel24;
        private FlowLayoutPanel flowLayoutPanel25;
        private FlowLayoutPanel flowLayoutPanel26;
        private FlowLayoutPanel flowLayoutPanel27;
        private FlowLayoutPanel flowLayoutPanel28;
        private FlowLayoutPanel flowLayoutPanel29;
        private FlowLayoutPanel flowLayoutPanel30;
        private FlowLayoutPanel flowLayoutPanel31;
        private FlowLayoutPanel flowLayoutPanel32;
    }
}
