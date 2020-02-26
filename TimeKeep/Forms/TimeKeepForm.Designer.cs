namespace TimeKeep
{
    partial class TimeKeepForm
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
            this.TabControl = new System.Windows.Forms.TabControl();
            this.EnterTimeTab = new System.Windows.Forms.TabPage();
            this.EnterCalendar = new System.Windows.Forms.MonthCalendar();
            this.RecordBtn = new System.Windows.Forms.Button();
            this.StartTimeLbl = new System.Windows.Forms.Label();
            this.EndTimePicker = new System.Windows.Forms.DateTimePicker();
            this.EndTimeLbl = new System.Windows.Forms.Label();
            this.StartTimePicker = new System.Windows.Forms.DateTimePicker();
            this.WeeklySummaryTab = new System.Windows.Forms.TabPage();
            this.TimeWorkedValueLbl = new System.Windows.Forms.Label();
            this.TimeRemainingValueLbl = new System.Windows.Forms.Label();
            this.TimeWorkedLbl = new System.Windows.Forms.Label();
            this.TimeRemainingLbl = new System.Windows.Forms.Label();
            this.SummaryCalendar = new System.Windows.Forms.MonthCalendar();
            this.TabControl.SuspendLayout();
            this.EnterTimeTab.SuspendLayout();
            this.WeeklySummaryTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.EnterTimeTab);
            this.TabControl.Controls.Add(this.WeeklySummaryTab);
            this.TabControl.Location = new System.Drawing.Point(13, 13);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(253, 269);
            this.TabControl.TabIndex = 6;
            // 
            // EnterTimeTab
            // 
            this.EnterTimeTab.Controls.Add(this.EnterCalendar);
            this.EnterTimeTab.Controls.Add(this.RecordBtn);
            this.EnterTimeTab.Controls.Add(this.StartTimeLbl);
            this.EnterTimeTab.Controls.Add(this.EndTimePicker);
            this.EnterTimeTab.Controls.Add(this.EndTimeLbl);
            this.EnterTimeTab.Controls.Add(this.StartTimePicker);
            this.EnterTimeTab.Location = new System.Drawing.Point(4, 22);
            this.EnterTimeTab.Name = "EnterTimeTab";
            this.EnterTimeTab.Padding = new System.Windows.Forms.Padding(3);
            this.EnterTimeTab.Size = new System.Drawing.Size(245, 243);
            this.EnterTimeTab.TabIndex = 0;
            this.EnterTimeTab.Text = "Enter Time";
            this.EnterTimeTab.UseVisualStyleBackColor = true;
            // 
            // EnterCalendar
            // 
            this.EnterCalendar.BackColor = System.Drawing.SystemColors.Control;
            this.EnterCalendar.FirstDayOfWeek = System.Windows.Forms.Day.Saturday;
            this.EnterCalendar.Location = new System.Drawing.Point(9, 9);
            this.EnterCalendar.MaxSelectionCount = 1;
            this.EnterCalendar.MinDate = new System.DateTime(2020, 2, 8, 0, 0, 0, 0);
            this.EnterCalendar.Name = "EnterCalendar";
            this.EnterCalendar.ShowToday = false;
            this.EnterCalendar.TabIndex = 6;
            this.EnterCalendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.EnterCalendar_DateChanged);
            // 
            // RecordBtn
            // 
            this.RecordBtn.BackColor = System.Drawing.Color.Transparent;
            this.RecordBtn.Location = new System.Drawing.Point(153, 183);
            this.RecordBtn.Name = "RecordBtn";
            this.RecordBtn.Size = new System.Drawing.Size(75, 46);
            this.RecordBtn.TabIndex = 11;
            this.RecordBtn.Text = "Record";
            this.RecordBtn.UseVisualStyleBackColor = false;
            this.RecordBtn.Click += new System.EventHandler(this.RecordBtn_Click);
            // 
            // StartTimeLbl
            // 
            this.StartTimeLbl.AutoSize = true;
            this.StartTimeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartTimeLbl.Location = new System.Drawing.Point(14, 185);
            this.StartTimeLbl.Name = "StartTimeLbl";
            this.StartTimeLbl.Size = new System.Drawing.Size(41, 15);
            this.StartTimeLbl.TabIndex = 7;
            this.StartTimeLbl.Text = "Start:";
            // 
            // EndTimePicker
            // 
            this.EndTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.EndTimePicker.Location = new System.Drawing.Point(61, 209);
            this.EndTimePicker.Name = "EndTimePicker";
            this.EndTimePicker.ShowUpDown = true;
            this.EndTimePicker.Size = new System.Drawing.Size(85, 20);
            this.EndTimePicker.TabIndex = 10;
            this.EndTimePicker.ValueChanged += new System.EventHandler(this.TimeKeepForm_ValueChanged);
            // 
            // EndTimeLbl
            // 
            this.EndTimeLbl.AutoSize = true;
            this.EndTimeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EndTimeLbl.Location = new System.Drawing.Point(19, 210);
            this.EndTimeLbl.Name = "EndTimeLbl";
            this.EndTimeLbl.Size = new System.Drawing.Size(36, 15);
            this.EndTimeLbl.TabIndex = 8;
            this.EndTimeLbl.Text = "End:";
            // 
            // StartTimePicker
            // 
            this.StartTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.StartTimePicker.Location = new System.Drawing.Point(61, 183);
            this.StartTimePicker.Name = "StartTimePicker";
            this.StartTimePicker.ShowUpDown = true;
            this.StartTimePicker.Size = new System.Drawing.Size(85, 20);
            this.StartTimePicker.TabIndex = 9;
            this.StartTimePicker.ValueChanged += new System.EventHandler(this.TimeKeepForm_ValueChanged);
            // 
            // WeeklySummaryTab
            // 
            this.WeeklySummaryTab.Controls.Add(this.TimeWorkedValueLbl);
            this.WeeklySummaryTab.Controls.Add(this.TimeRemainingValueLbl);
            this.WeeklySummaryTab.Controls.Add(this.TimeWorkedLbl);
            this.WeeklySummaryTab.Controls.Add(this.TimeRemainingLbl);
            this.WeeklySummaryTab.Controls.Add(this.SummaryCalendar);
            this.WeeklySummaryTab.Location = new System.Drawing.Point(4, 22);
            this.WeeklySummaryTab.Name = "WeeklySummaryTab";
            this.WeeklySummaryTab.Padding = new System.Windows.Forms.Padding(3);
            this.WeeklySummaryTab.Size = new System.Drawing.Size(245, 243);
            this.WeeklySummaryTab.TabIndex = 1;
            this.WeeklySummaryTab.Text = "Weekly Summary";
            this.WeeklySummaryTab.UseVisualStyleBackColor = true;
            // 
            // TimeWorkedValueLbl
            // 
            this.TimeWorkedValueLbl.AutoSize = true;
            this.TimeWorkedValueLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeWorkedValueLbl.Location = new System.Drawing.Point(151, 180);
            this.TimeWorkedValueLbl.Name = "TimeWorkedValueLbl";
            this.TimeWorkedValueLbl.Size = new System.Drawing.Size(26, 15);
            this.TimeWorkedValueLbl.TabIndex = 11;
            this.TimeWorkedValueLbl.Text = "N/A";
            // 
            // TimeRemainingValueLbl
            // 
            this.TimeRemainingValueLbl.AutoSize = true;
            this.TimeRemainingValueLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeRemainingValueLbl.Location = new System.Drawing.Point(151, 207);
            this.TimeRemainingValueLbl.Name = "TimeRemainingValueLbl";
            this.TimeRemainingValueLbl.Size = new System.Drawing.Size(26, 15);
            this.TimeRemainingValueLbl.TabIndex = 12;
            this.TimeRemainingValueLbl.Text = "N/A";
            // 
            // TimeWorkedLbl
            // 
            this.TimeWorkedLbl.AutoSize = true;
            this.TimeWorkedLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeWorkedLbl.Location = new System.Drawing.Point(46, 180);
            this.TimeWorkedLbl.Name = "TimeWorkedLbl";
            this.TimeWorkedLbl.Size = new System.Drawing.Size(99, 15);
            this.TimeWorkedLbl.TabIndex = 9;
            this.TimeWorkedLbl.Text = "Time Worked: ";
            // 
            // TimeRemainingLbl
            // 
            this.TimeRemainingLbl.AutoSize = true;
            this.TimeRemainingLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeRemainingLbl.Location = new System.Drawing.Point(24, 207);
            this.TimeRemainingLbl.Name = "TimeRemainingLbl";
            this.TimeRemainingLbl.Size = new System.Drawing.Size(121, 15);
            this.TimeRemainingLbl.TabIndex = 10;
            this.TimeRemainingLbl.Text = "Time Remaining: ";
            // 
            // SummaryCalendar
            // 
            this.SummaryCalendar.BackColor = System.Drawing.SystemColors.Control;
            this.SummaryCalendar.FirstDayOfWeek = System.Windows.Forms.Day.Saturday;
            this.SummaryCalendar.Location = new System.Drawing.Point(9, 9);
            this.SummaryCalendar.MinDate = new System.DateTime(2020, 2, 8, 0, 0, 0, 0);
            this.SummaryCalendar.Name = "SummaryCalendar";
            this.SummaryCalendar.ShowToday = false;
            this.SummaryCalendar.TabIndex = 7;
            this.SummaryCalendar.TodayDate = new System.DateTime(2020, 2, 25, 0, 0, 0, 0);
            this.SummaryCalendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.SummaryCalendar_DateChanged);
            // 
            // TimeKeepForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(274, 292);
            this.Controls.Add(this.TabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "TimeKeepForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Time Keeper";
            this.Load += new System.EventHandler(this.TimeKeepForm_Load);
            this.TabControl.ResumeLayout(false);
            this.EnterTimeTab.ResumeLayout(false);
            this.EnterTimeTab.PerformLayout();
            this.WeeklySummaryTab.ResumeLayout(false);
            this.WeeklySummaryTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage EnterTimeTab;
        private System.Windows.Forms.TabPage WeeklySummaryTab;
        private System.Windows.Forms.MonthCalendar EnterCalendar;
        private System.Windows.Forms.Button RecordBtn;
        private System.Windows.Forms.Label StartTimeLbl;
        private System.Windows.Forms.DateTimePicker EndTimePicker;
        private System.Windows.Forms.Label EndTimeLbl;
        private System.Windows.Forms.DateTimePicker StartTimePicker;
        private System.Windows.Forms.Label TimeWorkedValueLbl;
        private System.Windows.Forms.Label TimeRemainingValueLbl;
        private System.Windows.Forms.Label TimeWorkedLbl;
        private System.Windows.Forms.Label TimeRemainingLbl;
        private System.Windows.Forms.MonthCalendar SummaryCalendar;
    }
}

