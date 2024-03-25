using System;
using System.Collections.Generic;
using System.Windows.Forms;

public partial class SettingsForm : Form
{
    private IniFileManager _iniFileManager;
    private Dictionary<string, string> _defaultSettings;
    private string _userName;
    private Button button1;
    private TextBox textBox1;


    public SettingsForm()
    {
        InitializeComponent();
        _iniFileManager = new IniFileManager();
        _defaultSettings = _iniFileManager.ReadDefaultSettings();
        _userName = Environment.UserName;
    }

    private void SettingsForm_Load(object sender, EventArgs e)
    {
        LoadDefaultSettings();
        LoadUserSettings();
    }
    private void InitializeComponent()
    {
        // Create controls
        this.button1 = new System.Windows.Forms.Button();
        this.textBox1 = new System.Windows.Forms.TextBox();

        // Set control properties
        this.button1.Location = new System.Drawing.Point(12, 12);
        this.button1.Name = "button1";
        this.button1.Size = new System.Drawing.Size(75, 23);
        this.button1.Text = "Click Me";
        this.button1.UseVisualStyleBackColor = true;
        this.button1.Click += new System.EventHandler(this.button1_Click);

        this.textBox1.Location = new System.Drawing.Point(93, 14);
        this.textBox1.Name = "textBox1";
        this.textBox1.Size = new System.Drawing.Size(100, 20);

        // Add controls to form
        this.Controls.Add(this.button1);
        this.Controls.Add(this.textBox1);

        // Form settings
        this.ClientSize = new System.Drawing.Size(200, 50);
        this.Name = "MyForm";
        this.Text = "My Form";

        // Event handler
        this.button1.Click += new System.EventHandler(this.button1_Click);
    }


    private void LoadDefaultSettings()
    {
        foreach (var kvp in _defaultSettings)
        {
            // Display default settings in the GUI
            // You can use labels, text boxes, or other controls to display settings
            // For example:
            // label1.Text = _defaultSettings["AppName"];
        }
    }

    private void LoadUserSettings()
    {
        Dictionary<string, string> userSettings = _iniFileManager.ReadUserSettings(_userName);
        foreach (var kvp in userSettings)
        {
            // Display user-specific settings in the GUI
        }
    }
    private void button1_Click(object sender, EventArgs e)
    {
        // Handle button click event
        MessageBox.Show("Button clicked!");
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
        // Save user settings
        Dictionary<string, string> userSettings = new Dictionary<string, string>();
        // Collect user settings from GUI controls and store them in userSettings dictionary
        _iniFileManager.WriteUserSettings(_userName, userSettings);
        MessageBox.Show("Settings saved successfully.");
    }
}
