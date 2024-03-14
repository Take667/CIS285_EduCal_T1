using System;
using System.Collections.Generic;
using System.IO;

public class IniFileManager
{
    private string _defaultFilePath = "settings.ini";

    public Dictionary<string, string> ReadDefaultSettings()
    {
        return ReadSettings(_defaultFilePath);
    }

    public void WriteDefaultSettings(Dictionary<string, string> settings)
    {
        WriteSettings(settings, _defaultFilePath);
    }

    public Dictionary<string, string> ReadUserSettings(string userName)
    {
        string userFilePath = $"{userName}_settings.ini";
        return ReadSettings(userFilePath);
    }

    public void WriteUserSettings(string userName, Dictionary<string, string> settings)
    {
        string userFilePath = $"{userName}_settings.ini";
        WriteSettings(settings, userFilePath);
    }

    private Dictionary<string, string> ReadSettings(string filePath)
    {
        Dictionary<string, string> settings = new Dictionary<string, string>();
        if (File.Exists(filePath))
        {
            foreach (string line in File.ReadLines(filePath))
            {
                if (!string.IsNullOrWhiteSpace(line) && !line.StartsWith(";") && line.Contains("="))
                {
                    string[] parts = line.Split(new char[] { '=' }, 2);
                    settings[parts[0].Trim()] = parts[1].Trim();
                }
            }
        }
        return settings;
    }

    private void WriteSettings(Dictionary<string, string> settings, string filePath)
    {
        using (StreamWriter writer = new StreamWriter(filePath))
        {
            foreach (var kvp in settings)
            {
                writer.WriteLine($"{kvp.Key}={kvp.Value}");
            }
        }
    }
}
