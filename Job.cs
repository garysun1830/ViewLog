using System;
using System.Linq;
using System.Windows.Forms;
using System.Data;
using System.Data.Common;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System.Configuration;
using System.Text.RegularExpressions;

namespace ViewLog
{

    public interface IJob
    {
        void Init(ContextMenuStrip menuStrip);
        void Update(ISetting setting);
    }

    public class Job : IJob
    {
        string[] allFieldNames = new string[] {
            "LogID"
            ,"EventID"
            ,"Priority"
            ,"Severity"
            ,"Title"
            ,"Timestamp"
            ,"MachineName"
            ,"AppDomainName"
            ,"ProcessID"
            ,"ProcessName"
            ,"ThreadName"
            ,"Win32ThreadId"
            ,"Message"
            ,"FormattedMessage"
        };
        string[][] dispFieldNames = new string[][] {
            new string[] {  "Timestamp","50" }
            ,new string[] { "MachineName","50" }
            ,new string[] { "FormattedMessage","400" }
        };
        private Database db;
        private DataGridView view;

        public Job(DataGridView View)
        {
            if (View == null)
                throw new NullReferenceException("View");
            view = View;
        }

        public void Init(ContextMenuStrip menuStrip)
        {
            foreach (string[] f in dispFieldNames)
            {
                view.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    DataPropertyName = f[0],
                    HeaderText = f[0],
                    Name = f[0],
                    Width = Convert.ToInt32(f[1]),
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells,
                    ContextMenuStrip = menuStrip
                });
            }
            view.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            view.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
        }

        private void ValidateInput(ISetting setting)
        {
            if (setting.UseFromTime)
            {
                int val;
                if (!int.TryParse(setting.FromHour, out val) || val < 0 || val > 24)
                    throw new Exception("From hour is not valid.");
                if (!int.TryParse(setting.LastMinute, out val) || val < 0 || val > 9999)
                    throw new Exception("For minutes is not valid.");
            }
        }

        private string CreateTimeFilter(ISetting setting, string cri)
        {
            if (!string.IsNullOrWhiteSpace(cri))
            {
                cri = Regex.Replace(cri, "Timestamp>=((?!AND).)*AND", "").Trim();
            }
            DateTime dtFrom = setting.FromDate.Date.AddHours(Convert.ToInt32(setting.FromHour));
            DateTime dtTo = dtFrom.AddMinutes(Convert.ToInt32(setting.LastMinute));
            return string.Format("{0} Timestamp>='{1}' AND Timestamp<='{2}' AND", cri, dtFrom, dtTo);
        }

        public void Update(ISetting setting)
        {
            ValidateInput(setting);
            string dbName = setting.Server.Replace("\\", "_") + "_" + setting.DB;
            bool ok = true;
            try
            {
                db = DatabaseFactory.CreateDatabase(dbName + "_" + setting.Ext);
            }
            catch (ConfigurationErrorsException)
            {
                ok = false;
            }
            if (!ok)
            {
                db = DatabaseFactory.CreateDatabase(dbName);
            }
            view.Rows.Clear();
            string fields = string.Join(",", dispFieldNames.Select(fn => fn[0]));
            if (!fields.Contains("LogID"))
                fields += ",LogID";
            string cri = null;
            if (setting.Machine != "ALL" || setting.SinceLast)
            {
                if (setting.Machine != "ALL")
                    cri = string.Format("MachineName='{0}' AND", setting.Machine);
                if (setting.SinceLast)
                    cri = string.Format("LogID >{0} AND", setting.LastMax);
            }
            if (setting.Filter)
            {
                if (setting.UseFromDate)
                {
                    DateTime dt = setting.FromDate.Date;
                    if (setting.UseFromDate) cri = string.Format("{0} Timestamp>=convert(datetime,'{1}/{2}/{3}',101) AND", cri, dt.Month, dt.Day, dt.Year);
                }
                if (setting.UseFromTime)
                {
                    cri = CreateTimeFilter(setting, cri);
                }
                else if (setting.UseToDate)
                {
                    DateTime dt = setting.ToDate.Date;
                    dt = dt.AddDays(1);
                    cri = string.Format("{0} Timestamp<convert(datetime,'{1}/{2}/{3}',101) AND", cri, dt.Month, dt.Day, dt.Year);
                }
                setting.IncFilterItems.Where(s => !string.IsNullOrWhiteSpace(s)).ToList().ForEach(s => cri = string.Format("{0} Message like '%{1}%' AND", cri, s));
                setting.ExcFilterItems.Where(s => !string.IsNullOrWhiteSpace(s)).ToList().ForEach(s => cri = string.Format("{0} Message not like '%{1}%' AND", cri, s));
            }
            if (!string.IsNullOrWhiteSpace(cri)) cri = string.Format("WHERE {0}", cri.Remove(cri.Length - 4));
            string sql = string.Format("SELECT TOP({0}) {1} FROM log.Log {2} ORDER BY Timestamp DESC", setting.RecCount, fields, cri);
            DbCommand dbCommand = db.GetSqlStringCommand(sql);
            if (!setting.SinceLast) setting.LastMax = 1;
            using (IDataReader dReader = db.ExecuteReader(dbCommand))
            {
                int i = 0;
                while (dReader.Read())
                {
                    view.Rows.Add();
                    foreach (string[] f in dispFieldNames)
                    {
                        view.Rows[i].Cells[f[0]].Value = dReader[f[0]].ToString();
                    }
                    i++;
                    uint lastID = (uint)(int)dReader["LogID"];
                    if (lastID > setting.LastMax)
                        setting.LastMax = lastID;
                }
            }
            view.Visible = true;
        }

    }
}
