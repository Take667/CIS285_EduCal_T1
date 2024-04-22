using System;
using System.Collections.Generic;
using System.Windows.Forms;

public partial class SettingsForm : Form
{
    private IniFileManager _iniFileManager;
    private Dictionary<string, string> _defaultSettings;
    private string _userName;
    private Button btnSave;
    private TextBox txtDefaultLocation;
    private TextBox txtDefaultExtension;
    private TextBox txtFileFormat;
    private TextBox txtDefaultSettings;
    private TextBox txtUserSettings;

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
        // Initialize GUI controls
        btnSave = new Button();
        btnSave.Location = new System.Drawing.Point(12, 12);
        btnSave.Size = new System.Drawing.Size(75, 23);
        btnSave.Text = "Save";
        btnSave.Click += new EventHandler(btnSave_Click);

        txtDefaultLocation = new TextBox();
        txtDefaultLocation.Location = new System.Drawing.Point(12, 50);
        txtDefaultLocation.Size = new System.Drawing.Size(200, 20);

        txtDefaultExtension = new TextBox();
        txtDefaultExtension.Location = new System.Drawing.Point(12, 90);
        txtDefaultExtension.Size = new System.Drawing.Size(200, 20);

        txtFileFormat = new TextBox();
        txtFileFormat.Location = new System.Drawing.Point(12, 130);
        txtFileFormat.Size = new System.Drawing.Size(200, 20);

        txtDefaultSettings = new TextBox();
        txtDefaultSettings.Location = new System.Drawing.Point(12, 170);
        txtDefaultSettings.Size = new System.Drawing.Size(200, 20);

        txtUserSettings = new TextBox();
        txtUserSettings.Location = new System.Drawing.Point(12, 210);
        txtUserSettings.Size = new System.Drawing.Size(200, 100);
        txtUserSettings.Multiline = true;
        txtUserSettings.ReadOnly = true;

        // Add controls to form
        this.Controls.Add(btnSave);
        this.Controls.Add(txtDefaultLocation);
        this.Controls.Add(txtDefaultExtension);
        this.Controls.Add(txtFileFormat);
        this.Controls.Add(txtDefaultSettings);
        this.Controls.Add(txtUserSettings);

        
    }

    private void LoadDefaultSettings()
    {
        // Load default settings into GUI controls
        txtDefaultLocation.Text = _defaultSettings["DefaultLocation"];
        txtDefaultExtension.Text = _defaultSettings["DefaultExtension"];
        txtFileFormat.Text = _defaultSettings["FileFormat"];
    }

    private void LoadUserSettings()
    {
        // Load user-specific settings into GUI controls
        Dictionary<string, string> userSettings = _iniFileManager.ReadUserSettings(_userName);
        // Display user-specific settings in the GUI
        txtUserSettings.Text = string.Join(Environment.NewLine, userSettings);
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
        // Save user settings
        Dictionary<string, string> userSettings = new Dictionary<string, string>();
        // Collect user settings from GUI controls and store them in userSettings dictionary
        userSettings["DefaultLocation"] = txtDefaultLocation.Text;
        userSettings["DefaultExtension"] = txtDefaultExtension.Text;
        userSettings["FileFormat"] = txtFileFormat.Text;
        _iniFileManager.WriteUserSettings(_userName, userSettings);
        MessageBox.Show("Settings saved successfully.");
    }
}
