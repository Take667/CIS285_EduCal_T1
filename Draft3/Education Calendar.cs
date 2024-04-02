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
        private Label lbEventsList;
        private Label lbEvent1;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private TextBox textBox8;
        private Label label5;
        private Label label6;
        private Label label7;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        private Panel panel7;
        private Panel panel9;
        private Panel panel10;
        private Panel panel11;
        private Panel panel12;
        private Panel panel13;
        private Panel panel14;
        private Panel panel8;
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
        private Panel panel31;
        private Panel panel32;
        private Panel panel33;
        private Panel panel34;
        private Panel panel35;
        private Panel panel36;
        private Panel panel37;
        private Panel panel38;
        private Panel panel39;
        private Label lbSun;
        private Label lbMon;
        private Label lbTues;
        private Label lbWedns;
        private Label Thurs;
        private Label lbFri;
        private Label lbSat;
        private Label lbMonth;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem toolStripMenuItem3;
        private Label label8;

        public frmMain () {
			InitializeComponent ();
		}

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.panel14 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
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
            this.panel31 = new System.Windows.Forms.Panel();
            this.panel32 = new System.Windows.Forms.Panel();
            this.panel33 = new System.Windows.Forms.Panel();
            this.panel34 = new System.Windows.Forms.Panel();
            this.panel35 = new System.Windows.Forms.Panel();
            this.panel36 = new System.Windows.Forms.Panel();
            this.panel37 = new System.Windows.Forms.Panel();
            this.panel38 = new System.Windows.Forms.Panel();
            this.panel39 = new System.Windows.Forms.Panel();
            this.lbEventsList = new System.Windows.Forms.Label();
            this.lbEvent1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbSun = new System.Windows.Forms.Label();
            this.lbMon = new System.Windows.Forms.Label();
            this.lbTues = new System.Windows.Forms.Label();
            this.lbWedns = new System.Windows.Forms.Label();
            this.Thurs = new System.Windows.Forms.Label();
            this.lbFri = new System.Windows.Forms.Label();
            this.lbSat = new System.Windows.Forms.Label();
            this.lbMonth = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.flowLayoutPanel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
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
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Controls.Add(this.panel2);
            this.flowLayoutPanel1.Controls.Add(this.panel3);
            this.flowLayoutPanel1.Controls.Add(this.panel4);
            this.flowLayoutPanel1.Controls.Add(this.panel5);
            this.flowLayoutPanel1.Controls.Add(this.panel6);
            this.flowLayoutPanel1.Controls.Add(this.panel7);
            this.flowLayoutPanel1.Controls.Add(this.panel9);
            this.flowLayoutPanel1.Controls.Add(this.panel10);
            this.flowLayoutPanel1.Controls.Add(this.panel11);
            this.flowLayoutPanel1.Controls.Add(this.panel12);
            this.flowLayoutPanel1.Controls.Add(this.panel13);
            this.flowLayoutPanel1.Controls.Add(this.panel14);
            this.flowLayoutPanel1.Controls.Add(this.panel8);
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
            this.flowLayoutPanel1.Controls.Add(this.panel32);
            this.flowLayoutPanel1.Controls.Add(this.panel33);
            this.flowLayoutPanel1.Controls.Add(this.panel34);
            this.flowLayoutPanel1.Controls.Add(this.panel35);
            this.flowLayoutPanel1.Controls.Add(this.panel36);
            this.flowLayoutPanel1.Controls.Add(this.panel37);
            this.flowLayoutPanel1.Controls.Add(this.panel38);
            this.flowLayoutPanel1.Controls.Add(this.panel39);
            resources.ApplyResources(this.flowLayoutPanel1, "flowLayoutPanel1");
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
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
            this.panel12.Paint += new System.Windows.Forms.PaintEventHandler(this.panel12_Paint);
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
            // panel8
            // 
            resources.ApplyResources(this.panel8, "panel8");
            this.panel8.Name = "panel8";
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
            // panel30
            // 
            resources.ApplyResources(this.panel30, "panel30");
            this.panel30.Name = "panel30";
            // 
            // panel31
            // 
            resources.ApplyResources(this.panel31, "panel31");
            this.panel31.Name = "panel31";
            // 
            // panel32
            // 
            resources.ApplyResources(this.panel32, "panel32");
            this.panel32.Name = "panel32";
            // 
            // panel33
            // 
            resources.ApplyResources(this.panel33, "panel33");
            this.panel33.Name = "panel33";
            // 
            // panel34
            // 
            resources.ApplyResources(this.panel34, "panel34");
            this.panel34.Name = "panel34";
            // 
            // panel35
            // 
            resources.ApplyResources(this.panel35, "panel35");
            this.panel35.Name = "panel35";
            // 
            // panel36
            // 
            resources.ApplyResources(this.panel36, "panel36");
            this.panel36.Name = "panel36";
            // 
            // panel37
            // 
            resources.ApplyResources(this.panel37, "panel37");
            this.panel37.Name = "panel37";
            // 
            // panel38
            // 
            resources.ApplyResources(this.panel38, "panel38");
            this.panel38.Name = "panel38";
            // 
            // panel39
            // 
            resources.ApplyResources(this.panel39, "panel39");
            this.panel39.Name = "panel39";
            // 
            // lbEventsList
            // 
            resources.ApplyResources(this.lbEventsList, "lbEventsList");
            this.lbEventsList.Name = "lbEventsList";
            // 
            // lbEvent1
            // 
            resources.ApplyResources(this.lbEvent1, "lbEvent1");
            this.lbEvent1.Name = "lbEvent1";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
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
            // textBox5
            // 
            resources.ApplyResources(this.textBox5, "textBox5");
            this.textBox5.Name = "textBox5";
            // 
            // textBox6
            // 
            resources.ApplyResources(this.textBox6, "textBox6");
            this.textBox6.Name = "textBox6";
            // 
            // textBox7
            // 
            resources.ApplyResources(this.textBox7, "textBox7");
            this.textBox7.Name = "textBox7";
            // 
            // textBox8
            // 
            resources.ApplyResources(this.textBox8, "textBox8");
            this.textBox8.Name = "textBox8";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
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
            // lbWedns
            // 
            resources.ApplyResources(this.lbWedns, "lbWedns");
            this.lbWedns.Name = "lbWedns";
            // 
            // Thurs
            // 
            resources.ApplyResources(this.Thurs, "Thurs");
            this.Thurs.Name = "Thurs";
            this.Thurs.Click += new System.EventHandler(this.label12_Click);
            // 
            // lbFri
            // 
            resources.ApplyResources(this.lbFri, "lbFri");
            this.lbFri.Name = "lbFri";
            this.lbFri.Click += new System.EventHandler(this.label13_Click);
            // 
            // lbSat
            // 
            resources.ApplyResources(this.lbSat, "lbSat");
            this.lbSat.Name = "lbSat";
            // 
            // lbMonth
            // 
            resources.ApplyResources(this.lbMonth, "lbMonth");
            this.lbMonth.Name = "lbMonth";
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            resources.ApplyResources(this.toolStripMenuItem1, "toolStripMenuItem1");
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            resources.ApplyResources(this.toolStripMenuItem2, "toolStripMenuItem2");
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            resources.ApplyResources(this.toolStripMenuItem3, "toolStripMenuItem3");
            // 
            // frmMain
            // 
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.lbMonth);
            this.Controls.Add(this.lbSat);
            this.Controls.Add(this.lbFri);
            this.Controls.Add(this.Thurs);
            this.Controls.Add(this.lbWedns);
            this.Controls.Add(this.lbTues);
            this.Controls.Add(this.lbMon);
            this.Controls.Add(this.lbSun);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbEvent1);
            this.Controls.Add(this.lbEventsList);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel12_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
    }
}
