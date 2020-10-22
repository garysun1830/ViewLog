using System;
using System.Linq;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Text;

namespace ViewLog
{

    public partial class fmMain : Form
    {

        private string selCellText;
        private IJob job;
        private ISetting setting;
        private List<TextBox> IncFilterBoxes;
        private List<TextBox> ExcFilterBoxes;

        public fmMain()
        {
            InitializeComponent();
            IncFilterBoxes = new List<TextBox>();
            ExcFilterBoxes = new List<TextBox>();
            cbxComputer.SelectedIndex = 0;
            cbxExt.SelectedIndex = 0;
            cbxDatabase.SelectedIndex = 0;
            cbxHost.SelectedIndex = 0;
            tableLog.ReadOnly = true;
            ContextMenuStrip menuStrip = new ContextMenuStrip();
            ToolStripMenuItem menuItem = new ToolStripMenuItem("Copy");
            menuItem.Click += new EventHandler(menuItem_Click);
            menuItem.Name = "Copy";
            menuStrip.Items.Add(menuItem);
            job = new Job(tableLog);
            job.Init(menuStrip);
            setting = new Setting();
            setting = setting.Load();
            if (!string.IsNullOrWhiteSpace(setting.Server))
            {
                cbxDatabase.Text = setting.DB;
                cbxExt.Text = setting.Ext;
                cbxHost.Text = setting.Machine;
                txtRec.Text = setting.RecCount.ToString();
                cbxComputer.Text = setting.Server;
            }
        }


        private void menuItem_Click(object sender, System.EventArgs e)
        {
            ButtonAct(() =>
            {
                Clipboard.SetText(selCellText);
            });
        }

        private void ButtonAct(Action act)
        {
            try
            {
                if (act == null)
                    throw new NullReferenceException();
                Cursor.Current = Cursors.WaitCursor;
                try
                {
                    act();
                }
                finally
                {
                    Cursor.Current = Cursors.Default;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, System.EventArgs e)
        {
            ButtonAct(() =>
            {
                setting.SinceLast = false;
                doUpdate();
            });
        }

        private void doUpdate()
        {
            setting.DB = cbxDatabase.Text;
            setting.Ext = cbxExt.Text;
            setting.Machine = cbxHost.Text;
            setting.RecCount = Convert.ToInt32(txtRec.Text);
            setting.Server = cbxComputer.Text;
            setting.Filter = chkFilter.Checked;
            setting.FromDate = dtpFromDate.Value;
            setting.ToDate = dtpToDate.Value;
            setting.UseFromTime =pnlFilterDateTo.Enabled && rdUseFromHour.Checked;
            setting.FromHour = txtFromHour.Text;
            setting.LastMinute = txtForMinute.Text;
            setting.UseFromDate = dtpFromDate.Enabled;
            setting.UseToDate = dtpToDate.Enabled;
            setting.IncFilterItems.Clear();
            setting.ExcFilterItems.Clear();
            IncFilterBoxes.Where(f => !string.IsNullOrWhiteSpace(f.Text)).ToList().ForEach(f => setting.IncFilterItems.Add(f.Text.Trim()));
            ExcFilterBoxes.Where(f => !string.IsNullOrWhiteSpace(f.Text)).ToList().ForEach(f => setting.ExcFilterItems.Add(f.Text.Trim()));
            job.Update(setting);
            setting.Save();
        }

        private void tableLog_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            ButtonAct(() =>
            {
                if (e.Button == MouseButtons.Right)
                {
                    tableLog.ClearSelection();
                    tableLog[e.ColumnIndex, e.RowIndex].Selected = true;
                    selCellText = (string)tableLog[e.ColumnIndex, e.RowIndex].Value;
                }
            });
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            ButtonAct(() =>
            {
                setting.SinceLast = true;
                doUpdate();
            });
        }

        private void chkFilter_CheckedChanged(object sender, EventArgs e)
        {
            ButtonAct(() =>
            {
                pnlFilter.Enabled = chkFilter.Checked;
            });
        }

        private void tableLog_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ButtonAct(() =>
            {
                fmMessageCopy copyForm = new fmMessageCopy();
                copyForm.Message = tableLog[e.ColumnIndex, e.RowIndex].Value.ToString();
                copyForm.ShowDialog();
            });
        }

        private void chkUseFromDate_CheckedChanged(object sender, EventArgs e)
        {
            ButtonAct(() =>
            {
                dtpFromDate.Enabled = chkUseFromDate.Checked;
            });
        }

        private void chkUseToDate_CheckedChanged(object sender, EventArgs e)
        {
            ButtonAct(() =>
            {
                chkFilterDateTime.Enabled = false;
                dtpToDate.Enabled = chkUseToDate.Checked;
            });
        }

        private void chkFilterDateTime_CheckedChanged(object sender, EventArgs e)
        {
            ButtonAct(() =>
            {
                pnlFilterDate.Enabled = chkFilterDateTime.Checked;
            });
        }

        private void chkUseFromHour_CheckedChanged(object sender, EventArgs e)
        {
            if (!chkUseFromDate.Checked)
            {
                chkUseToDate.Checked = true;
            }
            else
            {
                txtFromHour.Enabled = rdUseFromHour.Checked;
                txtForMinute.Enabled = rdUseFromHour.Checked;
            }
        }

        private void btnAddIncFilterText_Click(object sender, EventArgs e)
        {
            ButtonAct(() =>
            {
                if (IncFilterBoxes.Count == 5)
                    return;
                TextBox tbx = new TextBox();
                tbx.Location = new Point(80 + IncFilterBoxes.Count * 191, 29);
                tbx.Width = 181;
                pnlFilter.Controls.Add(tbx);
                IncFilterBoxes.Add(tbx);
            });
        }

        private void btnAddExcFilterText_Click(object sender, EventArgs e)
        {
            ButtonAct(() =>
            {
                if (ExcFilterBoxes.Count == 5)
                    return;
                TextBox tbx = new TextBox();
                tbx.Location = new Point(80 + ExcFilterBoxes.Count * 191, 59);
                tbx.Width = 181;
                pnlFilter.Controls.Add(tbx);
                ExcFilterBoxes.Add(tbx);
            });
        }

        private void btnCopyLog_Click(object sender, EventArgs e)
        {
            ButtonAct(() =>
            {
                StringBuilder sb = new StringBuilder();
                foreach (DataGridViewRow row in tableLog.Rows)
                {
                    sb.AppendLine();
                    foreach (DataGridViewColumn col in tableLog.Columns)
                    {
                        string s = (string)tableLog[col.Index, row.Index].Value;
                        if (string.IsNullOrWhiteSpace(s))
                            continue;
                        //               if (s.Contains("\n\r"))
                        s = s.Replace("\n", " ").Replace("\r", " ");
                        sb.Append(s);
                        sb.Append("\t");
                    }
                }
                Clipboard.SetText(sb.ToString());
            });

        }

        private void chkUseFromDate_CheckedChanged_1(object sender, EventArgs e)
        {
            dtpFromDate.Enabled = chkUseFromDate.Checked;
        }

        private void chkUseToDate_CheckedChanged_1(object sender, EventArgs e)
        {
            pnlFilterDateTo.Enabled = chkUseToDate.Checked;
        }

        private void rdUseFromHour_CheckedChanged(object sender, EventArgs e)
        {
            txtForMinute.Enabled = rdUseFromHour.Checked;
            txtFromHour.Enabled = rdUseFromHour.Checked;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}

