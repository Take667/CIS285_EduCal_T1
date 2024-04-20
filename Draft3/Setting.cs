using System;
using System.Windows.Forms;

namespace YourNamespace
{
    public partial class frmAbout : Form
    {
        public frmAbout()
        {
            InitializeComponent();
        }

        private void btnSaveSettings_Click(object sender, EventArgs e)
        {
            // Save settings
            Properties.Settings.Default.Setting1 = textBoxSetting1.Text;
            Properties.Settings.Default.Setting2 = checkBoxSetting2.Checked;
            Properties.Settings.Default.Save();
            MessageBox.Show("Settings saved.");
        }

        private void frmAbout_Load(object sender, EventArgs e)
        {
            // Load settings when the form is loaded
            textBoxSetting1.Text = Properties.Settings.Default.Setting1;
            checkBoxSetting2.Checked = Properties.Settings.Default.Setting2;
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmAbout
            // 
            this.ClientSize = new System.Drawing.Size(444, 261);
            this.Name = "frmAbout";
            this.ResumeLayout(false);

        }
    }
}
