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
	public partial class frmMain : Form
    {
        private Button btnNext;
        private Button btnPrevious;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label lbEventList;
        private Label lbEvent1;
        private Label lbEvent2;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label5;
        private Label lbEvent3;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        private Panel panel7;
        private Panel panel8;
        private Panel panel14;
        private Panel panel9;
        private Panel panel10;
        private Panel panel11;
        private Panel panel12;
        private Panel panel13;
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
        private Label lbSun;
        private Label lbMon;
        private Label lbTues;
        private Label lbWeds;
        private Label lbThurs;
        private Panel panel30;
        private Panel panel31;
        private Label lbFri;
        private Label lbSat;
        private Label label1;
        private Label lbMonth;

        public frmMain () {
			InitializeComponent ();
		}

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.lbMonth = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lbEventList = new System.Windows.Forms.Label();
            this.lbEvent1 = new System.Windows.Forms.Label();
            this.lbEvent2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lbEvent3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
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
            this.lbSun = new System.Windows.Forms.Label();
            this.lbMon = new System.Windows.Forms.Label();
            this.lbTues = new System.Windows.Forms.Label();
            this.lbWeds = new System.Windows.Forms.Label();
            this.lbThurs = new System.Windows.Forms.Label();
            this.panel30 = new System.Windows.Forms.Panel();
            this.panel31 = new System.Windows.Forms.Panel();
            this.lbFri = new System.Windows.Forms.Label();
            this.lbSat = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNext
            // 
            resources.ApplyResources(this.btnNext, "btnNext");
            this.btnNext.Name = "btnNext";
            this.btnNext.UseVisualStyleBackColor = true;
            // 
            // btnPrevious
            // 
            resources.ApplyResources(this.btnPrevious, "btnPrevious");
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.UseVisualStyleBackColor = true;
            // 
            // lbMonth
            // 
            resources.ApplyResources(this.lbMonth, "lbMonth");
            this.lbMonth.Name = "lbMonth";
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
            this.flowLayoutPanel1.Controls.Add(this.panel14);
            this.flowLayoutPanel1.Controls.Add(this.panel9);
            this.flowLayoutPanel1.Controls.Add(this.panel10);
            this.flowLayoutPanel1.Controls.Add(this.panel11);
            this.flowLayoutPanel1.Controls.Add(this.panel12);
            this.flowLayoutPanel1.Controls.Add(this.panel13);
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
            this.flowLayoutPanel1.Controls.Add(this.panel31);
            resources.ApplyResources(this.flowLayoutPanel1, "flowLayoutPanel1");
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            // 
            // lbEventList
            // 
            resources.ApplyResources(this.lbEventList, "lbEventList");
            this.lbEventList.Name = "lbEventList";
            // 
            // lbEvent1
            // 
            resources.ApplyResources(this.lbEvent1, "lbEvent1");
            this.lbEvent1.Name = "lbEvent1";
            // 
            // lbEvent2
            // 
            resources.ApplyResources(this.lbEvent2, "lbEvent2");
            this.lbEvent2.Name = "lbEvent2";
            // 
            // textBox1
            // 
            resources.ApplyResources(this.textBox1, "textBox1");
            this.textBox1.Name = "textBox1";
            // 
            // textBox2
            // 
            resources.ApplyResources(this.textBox2, "textBox2");
            this.textBox2.Name = "textBox2";
            // 
            // textBox3
            // 
            resources.ApplyResources(this.textBox3, "textBox3");
            this.textBox3.Name = "textBox3";
            // 
            // textBox4
            // 
            resources.ApplyResources(this.textBox4, "textBox4");
            this.textBox4.Name = "textBox4";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // lbEvent3
            // 
            resources.ApplyResources(this.lbEvent3, "lbEvent3");
            this.lbEvent3.Name = "lbEvent3";
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // panel2
            // 
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // panel3
            // 
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.Name = "panel3";
            // 
            // panel4
            // 
            resources.ApplyResources(this.panel4, "panel4");
            this.panel4.Name = "panel4";
            // 
            // panel5
            // 
            resources.ApplyResources(this.panel5, "panel5");
            this.panel5.Name = "panel5";
            // 
            // panel6
            // 
            resources.ApplyResources(this.panel6, "panel6");
            this.panel6.Name = "panel6";
            // 
            // panel7
            // 
            resources.ApplyResources(this.panel7, "panel7");
            this.panel7.Name = "panel7";
            // 
            // panel8
            // 
            resources.ApplyResources(this.panel8, "panel8");
            this.panel8.Name = "panel8";
            // 
            // panel9
            // 
            resources.ApplyResources(this.panel9, "panel9");
            this.panel9.Name = "panel9";
            // 
            // panel10
            // 
            resources.ApplyResources(this.panel10, "panel10");
            this.panel10.Name = "panel10";
            // 
            // panel11
            // 
            resources.ApplyResources(this.panel11, "panel11");
            this.panel11.Name = "panel11";
            // 
            // panel12
            // 
            resources.ApplyResources(this.panel12, "panel12");
            this.panel12.Name = "panel12";
            // 
            // panel13
            // 
            resources.ApplyResources(this.panel13, "panel13");
            this.panel13.Name = "panel13";
            // 
            // panel14
            // 
            resources.ApplyResources(this.panel14, "panel14");
            this.panel14.Name = "panel14";
            // 
            // panel15
            // 
            resources.ApplyResources(this.panel15, "panel15");
            this.panel15.Name = "panel15";
            // 
            // panel16
            // 
            resources.ApplyResources(this.panel16, "panel16");
            this.panel16.Name = "panel16";
            // 
            // panel17
            // 
            resources.ApplyResources(this.panel17, "panel17");
            this.panel17.Name = "panel17";
            // 
            // panel18
            // 
            resources.ApplyResources(this.panel18, "panel18");
            this.panel18.Name = "panel18";
            // 
            // panel19
            // 
            resources.ApplyResources(this.panel19, "panel19");
            this.panel19.Name = "panel19";
            // 
            // panel20
            // 
            resources.ApplyResources(this.panel20, "panel20");
            this.panel20.Name = "panel20";
            // 
            // panel21
            // 
            resources.ApplyResources(this.panel21, "panel21");
            this.panel21.Name = "panel21";
            // 
            // panel22
            // 
            resources.ApplyResources(this.panel22, "panel22");
            this.panel22.Name = "panel22";
            // 
            // panel23
            // 
            resources.ApplyResources(this.panel23, "panel23");
            this.panel23.Name = "panel23";
            // 
            // panel24
            // 
            resources.ApplyResources(this.panel24, "panel24");
            this.panel24.Name = "panel24";
            // 
            // panel25
            // 
            resources.ApplyResources(this.panel25, "panel25");
            this.panel25.Name = "panel25";
            // 
            // panel26
            // 
            resources.ApplyResources(this.panel26, "panel26");
            this.panel26.Name = "panel26";
            // 
            // panel27
            // 
            resources.ApplyResources(this.panel27, "panel27");
            this.panel27.Name = "panel27";
            // 
            // panel28
            // 
            resources.ApplyResources(this.panel28, "panel28");
            this.panel28.Name = "panel28";
            // 
            // panel29
            // 
            resources.ApplyResources(this.panel29, "panel29");
            this.panel29.Name = "panel29";
            // 
            // lbSun
            // 
            resources.ApplyResources(this.lbSun, "lbSun");
            this.lbSun.Name = "lbSun";
            // 
            // lbMon
            // 
            resources.ApplyResources(this.lbMon, "lbMon");
            this.lbMon.Name = "lbMon";
            // 
            // lbTues
            // 
            resources.ApplyResources(this.lbTues, "lbTues");
            this.lbTues.Name = "lbTues";
            // 
            // lbWeds
            // 
            resources.ApplyResources(this.lbWeds, "lbWeds");
            this.lbWeds.Name = "lbWeds";
            // 
            // lbThurs
            // 
            resources.ApplyResources(this.lbThurs, "lbThurs");
            this.lbThurs.Name = "lbThurs";
            // 
            // panel30
            // 
            resources.ApplyResources(this.panel30, "panel30");
            this.panel30.Name = "panel30";
            // 
            // panel31
            // 
            resources.ApplyResources(this.panel31, "panel31");
            this.panel31.Name = "panel31";
            this.panel31.Paint += new System.Windows.Forms.PaintEventHandler(this.panel31_Paint);
            // 
            // lbFri
            // 
            resources.ApplyResources(this.lbFri, "lbFri");
            this.lbFri.Name = "lbFri";
            // 
            // lbSat
            // 
            resources.ApplyResources(this.lbSat, "lbSat");
            this.lbSat.Name = "lbSat";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // frmMain
            // 
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbSat);
            this.Controls.Add(this.lbFri);
            this.Controls.Add(this.lbThurs);
            this.Controls.Add(this.lbWeds);
            this.Controls.Add(this.lbTues);
            this.Controls.Add(this.lbMon);
            this.Controls.Add(this.lbSun);
            this.Controls.Add(this.lbMonth);
            this.Controls.Add(this.lbEvent3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbEvent2);
            this.Controls.Add(this.lbEvent1);
            this.Controls.Add(this.lbEventList);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnNext);
            this.Name = "frmMain";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void panel31_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
