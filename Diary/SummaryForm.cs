using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml.Serialization;
using System.IO;
using System.Text.RegularExpressions;

namespace Diary
{
    public partial class SummaryForm : Form
    {

        // --- Common ---
        int CurMonthDays = 30;
        bool ValueChangedEvent = false;
        public SummaryForm()
        {
            InitializeComponent();
            dateTimePicker1.Value = System.DateTime.Now.Date;
            CurMonthDays = DateTime.DaysInMonth(dateTimePicker1.Value.Year, dateTimePicker1.Value.Month);
            this.LoadEvent();
            this.LoadTimeTable();
            ValueChangedEvent = true;
        }

        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            try
            {
                dateTimePicker1.Value = dateTimePicker1.Value.Date.AddDays(-7);
                //this.PrevEvent();
                //this.PrevTimeTable();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            try
            {
                dateTimePicker1.Value = dateTimePicker1.Value.Date.AddDays(7);
                //this.NextEvent();
                //this.PrevTimeTable();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void DiaryForm_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (ValueChangedEvent)
            {
                this.LoadCurEvents();
                this.LoadCurTimeTable();
            }
        }

        // -------------------------------------------------------------
        // Event 
        // -------------------------------------------------------------
        EventData EData;
        List<DEvent> CurEvents = new List<DEvent>();
        // --- Initialize ---
        private void LoadEvent()
        {
            EData = EventData.GetData();
            LoadCurEvents();
        }

        private void FormClearEvent()
        {
            dataGridViewEvent.Rows.Clear();
        }

        private void LoadCurEvents()
        {
            CurEvents.Clear();
            foreach (var evs in EData.EventList.EventList)
            {
                if (evs.Date >= new DateTime(dateTimePicker1.Value.Year, dateTimePicker1.Value.Month, 1)
                    && evs.Date < new DateTime(dateTimePicker1.Value.Year, dateTimePicker1.Value.Month + 1, 1) )
                {
                    foreach (DEvent ev in evs.Items)
                    {
                        bool exist = false;
                        foreach (DEvent curEv in CurEvents)
                        {
                            if (curEv.Content == ev.Content) 
                            {
                                ev.Duration = curEv.Duration + 1;
                                CurEvents.Remove(curEv);
                                CurEvents.Add(ev);
                                exist = true;
                                break;
                            }
                        }
                        if (!exist)
                        {
                            ev.Duration = 1;
                            CurEvents.Add(ev);
                        }
                    }
                }
            }
            dataGridViewEvent.Columns.Clear();
            BindingSource bs = new BindingSource();
            bs.DataSource = CurEvents;
            dataGridViewEvent.DataSource = bs;
            dataGridViewEvent.Refresh();

        }

        // --- Event ---


        // -------------------------------------------------------------
        // TimeTable 
        // -------------------------------------------------------------
        TimeTableData TBData;
        DTimeTableItem CurTimeTable;

        // --- Initialize ---
        private void LoadTimeTable()
        {
            TBData = TimeTableData.GetData();
            CurTimeTable = new DTimeTableItem();
            LoadCurTimeTable();
        }

        private void LoadCurTimeTable()
        {
            try
            {
                FormClearTimeTable();
                CurTimeTable = null;
                CurMonthDays = 0;
                foreach (var ctb in TBData.TimeTable.Items)
                {
                    if (ctb.Date >= new DateTime(dateTimePicker1.Value.Year, dateTimePicker1.Value.Month, 1)
                        && ctb.Date < new DateTime(dateTimePicker1.Value.Year, dateTimePicker1.Value.Month + 1, 1))
                    {
                        CurMonthDays++;
                        foreach (var col in ctb.Columns)
                        {
                            foreach (Control c in TimeTable.Controls)
                            {
                                if (c is TextBox
                                    && c.Name == col.Name)
                                {
                                    if (((TextBox)c).ReadOnly == false)
                                    {
                                        c.Text = (DConvert.ToDoble(c.Text) + col.Duration).ToString();
                                    }
                                }
                            }
                        }
                    }
                }
                if (CurMonthDays == 0)
                {
                    CurMonthDays = DateTime.DaysInMonth(dateTimePicker1.Value.Year, dateTimePicker1.Value.Month);
                }

                foreach (Control c in TimeTable.Controls)
                {
                    if (c is TextBox)
                    {
                        if (((TextBox)c).ReadOnly == false)
                        {
                            Object obj = TimeTable.Controls.Find(c.Name + "Description", false).First();
                            if (obj != null)
                            {
                                ((Label)obj).Text = "% Cnt: ";
                            }
                        }
                    }
                }

                foreach (Control c in TimeTable.Controls)
                {
                    if (c is TextBox)
                    {
                        if (((TextBox)c).ReadOnly == true)
                        {
                            double d = 0.0;
                            switch (c.Name)
                            {
                                case "work":
                                    d += DConvert.ToDoble(business.Text);
                                    d += DConvert.ToDoble(note.Text);
                                    d += DConvert.ToDoble(project.Text);
                                    d += DConvert.ToDoble(language.Text);
                                    d += DConvert.ToDoble(fantasy.Text);
                                    work.Text = Convert.ToString(d);
                                    break;
                                case "life":
                                    d += DConvert.ToDoble(live.Text);
                                    d += DConvert.ToDoble(sleep.Text);
                                    d += DConvert.ToDoble(communication.Text);
                                    d += DConvert.ToDoble(discipline.Text);
                                    d += DConvert.ToDoble(exercise.Text);
                                    life.Text = Convert.ToString(d);
                                    break;
                                case "play":
                                    d += DConvert.ToDoble(book.Text);
                                    d += DConvert.ToDoble(animation.Text);
                                    d += DConvert.ToDoble(game.Text);
                                    d += DConvert.ToDoble(ero.Text);
                                    d += DConvert.ToDoble(other.Text);
                                    play.Text = Convert.ToString(d);
                                    break;
                            }
                        }
                    }
                }

                double w = DConvert.ToDoble(work.Text);
                double l = DConvert.ToDoble(life.Text);
                double p = DConvert.ToDoble(play.Text);
                total.Text = Convert.ToString(w + l + p);
                workLabel.Text = Convert.ToString(Convert.ToInt32(w / 24 / CurMonthDays * 100)) + "%";
                lifeLabel.Text = Convert.ToString(Convert.ToInt32(l / 24 / CurMonthDays * 100)) + "%";
                playLabel.Text = Convert.ToString(Convert.ToInt32(p / 24 / CurMonthDays * 100)) + "%";
                totalLabel.Text = Convert.ToString(Convert.ToInt32((w + l + p) / 24.0 / CurMonthDays * 100)) + "%";
                totalCount.Text = "Count: " + CurMonthDays.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void FormClearTimeTable()
        {
            foreach (Control c in TimeTable.Controls)
            {
                if (c is TextBox)
                {
                    if (((TextBox)c).ReadOnly == false)
                        c.Text = "";
                    else
                        c.Text = "0";
                }
            }
        }

        // --- Event ---
        private void TimeTable_TextChanged(object sender, EventArgs e)
        {

            
        }

        private void timerRefresh_Tick(object sender, EventArgs e)
        {
            DEvents DEvsToday = null;
            foreach (var evs in EData.EventList.EventList)
            {
                if (evs.Date == dateTimePicker1.Value)
                {
                    DEvsToday = evs;
                }
            }

            //selected rows
            if (DEvsToday == null) return;
            if (dataGridViewEvent.CurrentRow != null) dataGridViewEvent.CurrentRow.Selected = false;
            int count = 0;
            foreach (var ev in DEvsToday.Items)
            {
                int i = 0;
                foreach (DataGridViewRow itr in dataGridViewEvent.Rows)
                {
                    string name = (itr.Cells[0].Value == null) ? "" : itr.Cells[0].Value.ToString();
                    string evName = ev.Content;
                    if (name == evName)
                    {
                        count++;
                        dataGridViewEvent.Rows[i].Selected = true;
                    }
                    i++;
                }
            }
            dataGridViewEvent.Refresh();

            ((Timer)sender).Enabled = false;
        }

    }
}
