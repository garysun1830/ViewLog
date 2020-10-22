using System;
using Json;
using System.IO;
using System.Collections.Generic;

namespace ViewLog
{

    public interface ISetting
    {
        void Save();
        ISetting Load();
        string Server { get; set; }
        string DB { get; set; }
        string Ext { get; set; }
        string Machine { get; set; }
        int RecCount { get; set; }
        bool SinceLast { get; set; }
        Int64 LastMax { get; set; }
        bool Filter { get; set; }
        DateTime FromDate { get; set; }
        DateTime ToDate { get; set; }
        string FromHour { get; set; }
        string LastMinute { get; set; }
        List<string> IncFilterItems { get; }
        List<string> ExcFilterItems { get; }
        bool UseFromDate { get; set; }
        bool UseToDate { get; set; }
        bool UseFromTime { get; set; }
    }

    public class Setting : ISetting
    {
        private const string LOCAL_SAVE = "ViewLogSetting.txt";
        private string localSaveFile;
        public string Server { get; set; }
        public string DB { get; set; }
        public string Ext { get; set; }
        public string Machine { get; set; }
        public int RecCount { get; set; }
        public bool SinceLast { get; set; }
        public Int64 LastMax { get; set; }
        public bool Filter { get; set; }
        public bool UseFromDate { get; set; }
        public bool UseToDate { get; set; }
        public bool UseFromTime { get; set; }
        public bool UseToDateTime { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public string FromHour { get; set; }
        public string LastMinute { get; set; }
        public List<string> IncFilterItems { get; private set; }
        public List<string> ExcFilterItems { get; private set; }

        public Setting()
        {
            localSaveFile = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), LOCAL_SAVE);
            IncFilterItems = new List<string>();
            ExcFilterItems = new List<string>();
        }

        public void Save()
        {
            string text = JsonParser.Serialize<ISetting>(this).Replace("\\", "[__]");
            File.WriteAllText(localSaveFile, text);
        }

        public ISetting Load()
        {
            ISetting setting = new Setting();
            if (!File.Exists(localSaveFile))
                return setting;
            try
            {
                string text = File.ReadAllText(localSaveFile);
                if (string.IsNullOrWhiteSpace(text))
                    return setting;
                setting = JsonParser.Deserialize<Setting>(text);
                setting.Server = setting.Server.Replace("[__]", "\\");
            }
            catch
            {
            }
            return setting;
        }

    }
}