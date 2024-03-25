namespace EduCaldraft2
{
    partial class frmAbout
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
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.statusMain = new System.Windows.Forms.StatusStrip();
            this.mnuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuMain
            // 
            this.mnuMain.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.mnuMain.Dock = System.Windows.Forms.DockStyle.None;
            this.mnuMain.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.mnuMain.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuEdit,
            this.mnuAbout});
            this.mnuMain.Location = new System.Drawing.Point(-3, 9);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Size = new System.Drawing.Size(198, 33);
            this.mnuMain.TabIndex = 0;
            this.mnuMain.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.mnuMain_ItemClicked);
            // 
            // mnuFile
            // 
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(54, 29);
            this.mnuFile.Text = "File";
            // 
            // mnuEdit
            // 
            this.mnuEdit.Name = "mnuEdit";
            this.mnuEdit.Size = new System.Drawing.Size(58, 29);
            this.mnuEdit.Text = "Edit";
            // 
            // mnuAbout
            // 
            this.mnuAbout.Name = "mnuAbout";
            this.mnuAbout.Size = new System.Drawing.Size(78, 29);
            this.mnuAbout.Text = "Abou&t";
            // 
            // statusMain
            // 
            this.statusMain.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.statusMain.Dock = System.Windows.Forms.DockStyle.None;
            this.statusMain.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusMain.Location = new System.Drawing.Point(510, 495);
            this.statusMain.Name = "statusMain";
            this.statusMain.Size = new System.Drawing.Size(202, 22);
            this.statusMain.TabIndex = 3;
            this.statusMain.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked);
            // 
            // frmAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 526);
            this.Controls.Add(this.statusMain);
            this.Controls.Add(this.mnuMain);
            this.MainMenuStrip = this.mnuMain;
            this.Name = "frmAbout";
            this.Text = "frmAbout";
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.StatusStrip statusMain;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuEdit;
        private System.Windows.Forms.ToolStripMenuItem mnuAbout;
    }
}