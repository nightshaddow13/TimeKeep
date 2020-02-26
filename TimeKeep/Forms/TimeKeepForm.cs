using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data.Entity.Migrations;
using TimeKeep.Entities;
using System.Collections;
using System.Linq;

namespace TimeKeep
{
    public partial class TimeKeepForm : Form
    {
        private TimeKeepEntityContext _context;

        public TimeKeepForm()
        {
            _context = new TimeKeepEntityContext();
            InitializeComponent();
        }

        // *****************
        //  Utility methods
        // *****************

        private void _setValuesIfEntryExists(DateTime date)
        {
            // get the entry for the current date if available and set the start end end values
            Entry testEntry = _context.Entries != null ? _context.Entries.Find(EnterCalendar.SelectionStart) : null;

            if (testEntry != null)
            {
                StartTimePicker.Value = testEntry.StartTime;
                EndTimePicker.Value = testEntry.EndTime;
                _recordBtn_IsEquivalent(false);
            }
            else
            {
                StartTimePicker.Value = new DateTime(date.Year, date.Month, date.Day, 8, 00, 0);
                EndTimePicker.Value = new DateTime(date.Year, date.Month, date.Day, 17, 00, 0);
            }
        }

        private void _recordBtn_IsEquivalent(bool isEnabled)
        {
            if (isEnabled)
            {
                RecordBtn.BackColor = Color.Orange;
                RecordBtn.ForeColor = Color.Black;
            }
            else
            {
                RecordBtn.BackColor = Color.Green;
                RecordBtn.ForeColor = Color.White;
            }
            //RecordBtn.Enabled = isEnabled;
        }

        private void _updateTimeCounts()
        {
            // select the current week based on a single value
            DateTime selection = SummaryCalendar.SelectionStart;
            DateTime start = DateTime.Today;
            DateTime end = DateTime.Today;

            switch (selection.DayOfWeek)
            {
                case DayOfWeek.Saturday:
                    start = selection;
                    end = selection.AddDays(6);
                    break;

                case DayOfWeek.Sunday:
                    start = selection.AddDays(-1);
                    end = selection.AddDays(5);
                    break;

                case DayOfWeek.Monday:
                    start = selection.AddDays(-2);
                    end = selection.AddDays(4);
                    break;

                case DayOfWeek.Tuesday:
                    start = selection.AddDays(-3);
                    end = selection.AddDays(3);
                    break;

                case DayOfWeek.Wednesday:
                    start = selection.AddDays(-4);
                    end = selection.AddDays(2);
                    break;

                case DayOfWeek.Thursday:
                    start = selection.AddDays(-5);
                    end = selection.AddDays(1);
                    break;

                case DayOfWeek.Friday:
                    start = selection.AddDays(-6);
                    end = selection;
                    break;
            }

            SummaryCalendar.SelectionStart = start;
            SummaryCalendar.SelectionEnd = end;

            // query a list of entries for this week in order to calculate the weekly hours total.
            var entryList = _context.Entries.Where(entry => entry.ID.CompareTo(start) >= 0 && entry.ID.CompareTo(end) <= 0).ToList();
            TimeSpan timePassed = new TimeSpan(0);

            foreach (Entry entry in entryList)
                timePassed = timePassed.Add(entry.EndTime.Subtract(entry.StartTime));

            // deturmine time left
            TimeSpan timeRemaining = new TimeSpan(45, 0, 0).Subtract(timePassed);

            // Modify labels to represent time worked
            TimeWorkedValueLbl.Text = String.Format("{0}h : {1}m", timePassed.Hours + timePassed.Days * 24, timePassed.Minutes);
            TimeRemainingValueLbl.Text = String.Format("{0}h : {1}m", timeRemaining.Hours + timeRemaining.Days * 24, timeRemaining.Minutes);
        }

        // *******************
        //  Triggered methods
        // *******************

        private void TimeKeepForm_Load(object sender, EventArgs e)
        {
            _recordBtn_IsEquivalent(true);

            // set the calendars to the current date on form load
            DateTime today = DateTime.Now;
            EnterCalendar.SetDate(today);
            EnterCalendar.TodayDate = today;
            SummaryCalendar.SetDate(today);
            SummaryCalendar.TodayDate = today;

            // get the entry for the current date if available and set the start end end values
            // set to default values if false
            _setValuesIfEntryExists(today);
        }

        private void EnterCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            _setValuesIfEntryExists(e.Start);
            SummaryCalendar.SelectionStart = EnterCalendar.SelectionStart;
        }

        private void SummaryCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            _updateTimeCounts();
        }

        private void TimeKeepForm_ValueChanged(object sender, EventArgs e)
        {
            _recordBtn_IsEquivalent(true);
        }

        private void RecordBtn_Click(object sender, EventArgs e)
        {
            // Pull data from the form for easy access
            DateTime date = EnterCalendar.SelectionStart;
            DateTime startTime = StartTimePicker.Value;
            DateTime endTime = EndTimePicker.Value;

            // create an entry to persist to the DB
            Entry newEntry = new Entry
            {
                ID = new DateTime(date.Year, date.Month, date.Day),
                StartTime = new DateTime(date.Year, date.Month, date.Day, startTime.Hour, startTime.Minute, 0),
                EndTime = new DateTime(date.Year, date.Month, date.Day, endTime.Hour, endTime.Minute, 0)
            };

            // persist the entity to the DB
            _context.Set<Entry>().AddOrUpdate(newEntry);
            _context.SaveChanges();

            _recordBtn_IsEquivalent(false);
            _updateTimeCounts();
        }
    }
}
