namespace ViewLog
{
    partial class fmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmMain));
            this.cbxDatabase = new System.Windows.Forms.ComboBox();
            this.cbxComputer = new System.Windows.Forms.ComboBox();
            this.tableLog = new System.Windows.Forms.DataGridView();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.cbxExt = new System.Windows.Forms.ComboBox();
            this.txtRec = new System.Windows.Forms.TextBox();
            this.cbxHost = new System.Windows.Forms.ComboBox();
            this.btnLast = new System.Windows.Forms.Button();
            this.chkFilter = new System.Windows.Forms.CheckBox();
            this.pnlFilter = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddExcFilterText = new System.Windows.Forms.Button();
            this.pnlFilterDate = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.chkUseToDate = new System.Windows.Forms.CheckBox();
            this.pnlFilterDateTo = new System.Windows.Forms.Panel();
            this.rdUseToDate = new System.Windows.Forms.RadioButton();
            this.rdUseFromHour = new System.Windows.Forms.RadioButton();
            this.txtForMinute = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFromHour = new System.Windows.Forms.TextBox();
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.chkUseFromDate = new System.Windows.Forms.CheckBox();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.chkFilterDateTime = new System.Windows.Forms.CheckBox();
            this.btnAddIncFilterText = new System.Windows.Forms.Button();
            this.btnCopyLog = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tableLog)).BeginInit();
            this.pnlFilter.SuspendLayout();
            this.pnlFilterDate.SuspendLayout();
            this.pnlFilterDateTo.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbxDatabase
            // 
            this.cbxDatabase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDatabase.FormattingEnabled = true;
            this.cbxDatabase.Items.AddRange(new object[] {
            "ASSET_DISPOSAL",
            "ELECTRONIC_PAYMENT",
            "SUPPLY_SERVICES"});
            this.cbxDatabase.Location = new System.Drawing.Point(141, 12);
            this.cbxDatabase.Name = "cbxDatabase";
            this.cbxDatabase.Size = new System.Drawing.Size(230, 21);
            this.cbxDatabase.Sorted = true;
            this.cbxDatabase.TabIndex = 0;
            // 
            // cbxComputer
            // 
            this.cbxComputer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxComputer.FormattingEnabled = true;
            this.cbxComputer.Items.AddRange(new object[] {
            "KINETIC\\CA_DEV",
            "KINETIC\\CA_SIT1",
            "NERVE\\CA_TST",
            "VIVACITY\\CA_PRD"});
            this.cbxComputer.Location = new System.Drawing.Point(14, 12);
            this.cbxComputer.Name = "cbxComputer";
            this.cbxComputer.Size = new System.Drawing.Size(121, 21);
            this.cbxComputer.TabIndex = 1;
            // 
            // tableLog
            // 
            this.tableLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLog.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.tableLog.Location = new System.Drawing.Point(12, 130);
            this.tableLog.Name = "tableLog";
            this.tableLog.Size = new System.Drawing.Size(1345, 621);
            this.tableLog.TabIndex = 2;
            this.tableLog.Visible = false;
            this.tableLog.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tableLog_CellDoubleClick);
            this.tableLog.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.tableLog_CellMouseDown);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(631, 10);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // cbxExt
            // 
            this.cbxExt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxExt.FormattingEnabled = true;
            this.cbxExt.Items.AddRange(new object[] {
            "OP",
            "PP",
            "SM"});
            this.cbxExt.Location = new System.Drawing.Point(377, 12);
            this.cbxExt.Name = "cbxExt";
            this.cbxExt.Size = new System.Drawing.Size(121, 21);
            this.cbxExt.Sorted = true;
            this.cbxExt.TabIndex = 4;
            // 
            // txtRec
            // 
            this.txtRec.Location = new System.Drawing.Point(882, 8);
            this.txtRec.Name = "txtRec";
            this.txtRec.Size = new System.Drawing.Size(39, 20);
            this.txtRec.TabIndex = 5;
            this.txtRec.Text = "10";
            // 
            // cbxHost
            // 
            this.cbxHost.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxHost.FormattingEnabled = true;
            this.cbxHost.Items.AddRange(new object[] {
            "ALL",
            "CETO",
            "DIONYSUS",
            "HAILA",
            "ND080010",
            "PARTICLE",
            "PHORCYS",
            "TRIDENT"});
            this.cbxHost.Location = new System.Drawing.Point(504, 12);
            this.cbxHost.Name = "cbxHost";
            this.cbxHost.Size = new System.Drawing.Size(121, 21);
            this.cbxHost.Sorted = true;
            this.cbxHost.TabIndex = 6;
            // 
            // btnLast
            // 
            this.btnLast.Location = new System.Drawing.Point(712, 10);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(110, 23);
            this.btnLast.TabIndex = 8;
            this.btnLast.Text = "Update Since Last";
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // chkFilter
            // 
            this.chkFilter.AutoSize = true;
            this.chkFilter.Location = new System.Drawing.Point(828, 10);
            this.chkFilter.Name = "chkFilter";
            this.chkFilter.Size = new System.Drawing.Size(48, 17);
            this.chkFilter.TabIndex = 9;
            this.chkFilter.Text = "Filter";
            this.chkFilter.UseVisualStyleBackColor = true;
            this.chkFilter.CheckedChanged += new System.EventHandler(this.chkFilter_CheckedChanged);
            // 
            // pnlFilter
            // 
            this.pnlFilter.Controls.Add(this.label3);
            this.pnlFilter.Controls.Add(this.label1);
            this.pnlFilter.Controls.Add(this.pnlFilterDateTo);
            this.pnlFilter.Controls.Add(this.btnAddExcFilterText);
            this.pnlFilter.Controls.Add(this.pnlFilterDate);
            this.pnlFilter.Controls.Add(this.chkFilterDateTime);
            this.pnlFilter.Controls.Add(this.btnAddIncFilterText);
            this.pnlFilter.Enabled = false;
            this.pnlFilter.Location = new System.Drawing.Point(14, 39);
            this.pnlFilter.Name = "pnlFilter";
            this.pnlFilter.Size = new System.Drawing.Size(1345, 85);
            this.pnlFilter.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Exclude";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Include";
            // 
            // btnAddExcFilterText
            // 
            this.btnAddExcFilterText.Location = new System.Drawing.Point(51, 57);
            this.btnAddExcFilterText.Name = "btnAddExcFilterText";
            this.btnAddExcFilterText.Size = new System.Drawing.Size(23, 23);
            this.btnAddExcFilterText.TabIndex = 25;
            this.btnAddExcFilterText.Text = "+";
            this.btnAddExcFilterText.UseVisualStyleBackColor = true;
            this.btnAddExcFilterText.Click += new System.EventHandler(this.btnAddExcFilterText_Click);
            // 
            // pnlFilterDate
            // 
            this.pnlFilterDate.Controls.Add(this.label4);
            this.pnlFilterDate.Controls.Add(this.chkUseToDate);
            this.pnlFilterDate.Controls.Add(this.chkUseFromDate);
            this.pnlFilterDate.Controls.Add(this.dtpFromDate);
            this.pnlFilterDate.Enabled = false;
            this.pnlFilterDate.Location = new System.Drawing.Point(27, 3);
            this.pnlFilterDate.Name = "pnlFilterDate";
            this.pnlFilterDate.Size = new System.Drawing.Size(933, 25);
            this.pnlFilterDate.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 34;
            this.label4.Text = "From Date";
            // 
            // chkUseToDate
            // 
            this.chkUseToDate.AutoSize = true;
            this.chkUseToDate.Location = new System.Drawing.Point(231, 4);
            this.chkUseToDate.Name = "chkUseToDate";
            this.chkUseToDate.Size = new System.Drawing.Size(15, 14);
            this.chkUseToDate.TabIndex = 33;
            this.chkUseToDate.UseVisualStyleBackColor = true;
            this.chkUseToDate.CheckedChanged += new System.EventHandler(this.chkUseToDate_CheckedChanged_1);
            // 
            // pnlFilterDateTo
            // 
            this.pnlFilterDateTo.Controls.Add(this.rdUseToDate);
            this.pnlFilterDateTo.Controls.Add(this.rdUseFromHour);
            this.pnlFilterDateTo.Controls.Add(this.txtForMinute);
            this.pnlFilterDateTo.Controls.Add(this.label2);
            this.pnlFilterDateTo.Controls.Add(this.txtFromHour);
            this.pnlFilterDateTo.Controls.Add(this.dtpToDate);
            this.pnlFilterDateTo.Enabled = false;
            this.pnlFilterDateTo.Location = new System.Drawing.Point(279, 3);
            this.pnlFilterDateTo.Name = "pnlFilterDateTo";
            this.pnlFilterDateTo.Size = new System.Drawing.Size(385, 25);
            this.pnlFilterDateTo.TabIndex = 32;
            // 
            // rdUseToDate
            // 
            this.rdUseToDate.AutoSize = true;
            this.rdUseToDate.Checked = true;
            this.rdUseToDate.Location = new System.Drawing.Point(215, 8);
            this.rdUseToDate.Name = "rdUseToDate";
            this.rdUseToDate.Size = new System.Drawing.Size(14, 13);
            this.rdUseToDate.TabIndex = 35;
            this.rdUseToDate.TabStop = true;
            this.rdUseToDate.UseVisualStyleBackColor = true;
            // 
            // rdUseFromHour
            // 
            this.rdUseFromHour.AutoSize = true;
            this.rdUseFromHour.Location = new System.Drawing.Point(3, 5);
            this.rdUseFromHour.Name = "rdUseFromHour";
            this.rdUseFromHour.Size = new System.Drawing.Size(74, 17);
            this.rdUseFromHour.TabIndex = 34;
            this.rdUseFromHour.Text = "From Hour";
            this.rdUseFromHour.UseVisualStyleBackColor = true;
            this.rdUseFromHour.CheckedChanged += new System.EventHandler(this.rdUseFromHour_CheckedChanged);
            // 
            // txtForMinute
            // 
            this.txtForMinute.Enabled = false;
            this.txtForMinute.Location = new System.Drawing.Point(183, 2);
            this.txtForMinute.Name = "txtForMinute";
            this.txtForMinute.Size = new System.Drawing.Size(26, 20);
            this.txtForMinute.TabIndex = 33;
            this.txtForMinute.Text = "120";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(115, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "For Minutes";
            // 
            // txtFromHour
            // 
            this.txtFromHour.Enabled = false;
            this.txtFromHour.Location = new System.Drawing.Point(83, 3);
            this.txtFromHour.Name = "txtFromHour";
            this.txtFromHour.Size = new System.Drawing.Size(26, 20);
            this.txtFromHour.TabIndex = 31;
            this.txtFromHour.Text = "10";
            // 
            // dtpToDate
            // 
            this.dtpToDate.Location = new System.Drawing.Point(235, 3);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(134, 20);
            this.dtpToDate.TabIndex = 30;
            // 
            // chkUseFromDate
            // 
            this.chkUseFromDate.AutoSize = true;
            this.chkUseFromDate.Checked = true;
            this.chkUseFromDate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkUseFromDate.Location = new System.Drawing.Point(3, 3);
            this.chkUseFromDate.Name = "chkUseFromDate";
            this.chkUseFromDate.Size = new System.Drawing.Size(15, 14);
            this.chkUseFromDate.TabIndex = 31;
            this.chkUseFromDate.UseVisualStyleBackColor = true;
            this.chkUseFromDate.CheckedChanged += new System.EventHandler(this.chkUseFromDate_CheckedChanged_1);
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.Location = new System.Drawing.Point(86, 3);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(139, 20);
            this.dtpFromDate.TabIndex = 30;
            // 
            // chkFilterDateTime
            // 
            this.chkFilterDateTime.AutoSize = true;
            this.chkFilterDateTime.Location = new System.Drawing.Point(6, 5);
            this.chkFilterDateTime.Name = "chkFilterDateTime";
            this.chkFilterDateTime.Size = new System.Drawing.Size(15, 14);
            this.chkFilterDateTime.TabIndex = 17;
            this.chkFilterDateTime.UseVisualStyleBackColor = true;
            this.chkFilterDateTime.CheckedChanged += new System.EventHandler(this.chkFilterDateTime_CheckedChanged);
            // 
            // btnAddIncFilterText
            // 
            this.btnAddIncFilterText.Location = new System.Drawing.Point(51, 28);
            this.btnAddIncFilterText.Name = "btnAddIncFilterText";
            this.btnAddIncFilterText.Size = new System.Drawing.Size(23, 23);
            this.btnAddIncFilterText.TabIndex = 12;
            this.btnAddIncFilterText.Text = "+";
            this.btnAddIncFilterText.UseVisualStyleBackColor = true;
            this.btnAddIncFilterText.Click += new System.EventHandler(this.btnAddIncFilterText_Click);
            // 
            // btnCopyLog
            // 
            this.btnCopyLog.Location = new System.Drawing.Point(937, 10);
            this.btnCopyLog.Name = "btnCopyLog";
            this.btnCopyLog.Size = new System.Drawing.Size(75, 23);
            this.btnCopyLog.TabIndex = 13;
            this.btnCopyLog.Text = "Copy Log";
            this.btnCopyLog.UseVisualStyleBackColor = true;
            this.btnCopyLog.Click += new System.EventHandler(this.btnCopyLog_Click);
            // 
            // fmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1385, 735);
            this.Controls.Add(this.btnCopyLog);
            this.Controls.Add(this.pnlFilter);
            this.Controls.Add(this.chkFilter);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.cbxHost);
            this.Controls.Add(this.txtRec);
            this.Controls.Add(this.cbxExt);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.tableLog);
            this.Controls.Add(this.cbxComputer);
            this.Controls.Add(this.cbxDatabase);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "View Log";
            ((System.ComponentModel.ISupportInitialize)(this.tableLog)).EndInit();
            this.pnlFilter.ResumeLayout(false);
            this.pnlFilter.PerformLayout();
            this.pnlFilterDate.ResumeLayout(false);
            this.pnlFilterDate.PerformLayout();
            this.pnlFilterDateTo.ResumeLayout(false);
            this.pnlFilterDateTo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxDatabase;
        private System.Windows.Forms.ComboBox cbxComputer;
        private System.Windows.Forms.DataGridView tableLog;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ComboBox cbxExt;
        private System.Windows.Forms.TextBox txtRec;
        private System.Windows.Forms.ComboBox cbxHost;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.CheckBox chkFilter;
        private System.Windows.Forms.Panel pnlFilter;
        private System.Windows.Forms.Button btnAddIncFilterText;
        private System.Windows.Forms.CheckBox chkFilterDateTime;
        private System.Windows.Forms.Panel pnlFilterDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddExcFilterText;
        private System.Windows.Forms.Button btnCopyLog;
        private System.Windows.Forms.Panel pnlFilterDateTo;
        private System.Windows.Forms.CheckBox chkUseFromDate;
        private System.Windows.Forms.DateTimePicker dtpFromDate;
        private System.Windows.Forms.CheckBox chkUseToDate;
        private System.Windows.Forms.RadioButton rdUseToDate;
        private System.Windows.Forms.RadioButton rdUseFromHour;
        private System.Windows.Forms.TextBox txtForMinute;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFromHour;
        private System.Windows.Forms.DateTimePicker dtpToDate;
        private System.Windows.Forms.Label label4;
    }
}

