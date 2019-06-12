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
    public partial class DiaryForm : Form
    {

        // --- Common ---
        int curIndex;
        bool ValueChangedEvent = false;
        public DiaryForm()
        {
            InitializeComponent();
            dateTimePicker1.Value = System.DateTime.Now.Date;
            curIndex = 0;
            this.LoadDiary();
            this.LoadEvent();
            this.LoadTimeTable();
            ValueChangedEvent = true;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {     
            try
            {
                this.SaveDiary();
                this.SaveEvent();
                this.SaveTimeTable();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            try
            {
                this.PrevDiary();
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
                this.NextDiary();
                //this.NextEvent();
                //this.PrevTimeTable();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void ToScheduleForm_Click(object sender, EventArgs e)
        {
            this.Hide();
            ScheduleForm SF = new ScheduleForm();
            SF.ShowDialog();
            this.Close();
        }


        private void ToSummaryForm_Click(object sender, EventArgs e)
        {
            this.Hide();
            SummaryForm SF = new SummaryForm();
            SF.ShowDialog();
            this.Close();
        }

        private void ToCollectionForm_Click(object sender, EventArgs e)
        {
            this.Hide();
            CollectionForm CF = new CollectionForm();
            CF.ShowDialog();
            this.Close();
        }

        private void DiaryForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if (curDiaryCount == DData.Diarys.Items.Count && CheckVaildDiary())
            //{
            //    DialogResult dr = MessageBox.Show("New diary have not been saved, are you sure to close?", "Rementation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);//触发事件进行提示
            //    if (dr == DialogResult.No)
            //    {
            //        e.Cancel = true;//就不退了
            //    }
            //    else
            //    {
            //        e.Cancel = false;//退了
            //    }
            //}
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (ValueChangedEvent)
            {
                this.LoadCurDiary();
                this.LoadCurEvents();
                this.LoadCurTimeTable();
            }
        }

        // -------------------------------------------------------------
        // Diary 
        // -------------------------------------------------------------
        DiaryData DData;
        DDiary curDiary;


        // --- Initialize ---
        private void LoadDiary()
        {
            DData = DiaryData.GetData();
            curIndex = DData.Diarys.Items.Count;
            curDiary = DData.Diarys.Items.Last();
            LoadCurDiary();
        }

        private void FormClearDiary()
        {
            //dateTimePicker1.Value = System.DateTime.Now.Date;
            textBoxTitle.Text = "";
            textBoxContent.Text = "";
        }

        private void LoadDDiary(DDiary dd)
        {
            dateTimePicker1.Value = dd.InputDateTime.Date;
            textBoxTitle.Text = dd.Title;
            dd.Content = dd.Content.Replace("\r\n", "\n");
            dd.Content = dd.Content.Replace("\n", System.Environment.NewLine);
            textBoxContent.Text = dd.Content;
        }

        private void LoadCurDiary()
        {
            FormClearDiary();

            DDiary dd = null;
            for (int i = 0; i < DData.Diarys.Items.Count; i++)
            {
                if (dateTimePicker1.Value == DData.Diarys.Items[i].InputDateTime)
                {
                    curIndex = i;
                    dd = DData.Diarys.Items[i];
                    break;
                }
            }
            if (dd != null)
            {
                textBoxTitle.Text = dd.Title;
                dd.Content = dd.Content.Replace("\r\n", "\n");
                dd.Content = dd.Content.Replace("\n", System.Environment.NewLine);
                textBoxContent.Text = dd.Content;
            }
            else
            {
                for (int i = 0; i < DData.Diarys.Items.Count; i++)
                {
                    if (dateTimePicker1.Value < DData.Diarys.Items[i].InputDateTime)
                    {
                        curIndex = i;
                        break;
                    }
                }            
            }
        }

        // --- Event ---
        private void SaveDiary()
        {
            DDiary dd;
            bool newDd = false;
            curIndex = DData.Diarys.Items.Count;
            for (int i = 0; i < DData.Diarys.Items.Count; i++)
            {
                if (dateTimePicker1.Value == DData.Diarys.Items[i].InputDateTime)
                {
                    curIndex = i;
                    break;
                }
            }
            if (0 <= curIndex && curIndex < DData.Diarys.Items.Count)
            {
                dd = DData.Diarys.Items[curIndex];
            }
            else
            {
                dd = new DDiary();
                newDd = true;
            }

            dd.InputDateTime = dateTimePicker1.Value.Date;
            dd.Title = textBoxTitle.Text;
            dd.Content = textBoxContent.Text;
            //dd.Content = dd.Content.Replace("\r\n", "\n");
            //dd.Content = dd.Content.Replace("\n", System.Environment.NewLine);

            if (newDd)
            {
                for (int i = 0; i < DData.Diarys.Items.Count; i++)
                {
                    if (dateTimePicker1.Value < DData.Diarys.Items[i].InputDateTime)
                    {
                        curIndex = i;
                        break;
                    }
                }
                DData.Diarys.Items.Insert(curIndex, dd);
            }

            DData.Save(DData.Diarys);

            //FormClearDiary();
            //curDiaryCount = DData.Diarys.Items.Count;
        }

        private void PrevDiary()
        {
            try
            {
                //curCount = DData.Diarys.FindIndex(curDiary);
                if (curIndex <= 0) return;
                curIndex--;
                curDiary = DData.Diarys.Items[curIndex];
                //LoadDDiary(curDiary);
                dateTimePicker1.Value = curDiary.InputDateTime;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void NextDiary()
        {
            try
            {
                //curCount = DData.Diarys.FindIndex(curDiary);
                if (curIndex < DData.Diarys.Items.Count - 1)
                {
                    curIndex++;
                    curDiary = DData.Diarys.Items[curIndex];
                    //LoadDDiary(curDiary);
                    if (curDiary != null)
                        dateTimePicker1.Value = curDiary.InputDateTime;
                }
                else if (curIndex == DData.Diarys.Items.Count - 1
                    && curDiary.InputDateTime != System.DateTime.Now.Date)
                {
                    FormClearDiary();
                    curIndex++;
                    dateTimePicker1.Value = System.DateTime.Now.Date;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private bool CheckVaildDiary()
        {
            bool nRet = false;
            if (textBoxTitle.Text.Trim() != "") nRet = true;
            if (textBoxContent.Text.Trim() != "") nRet = true;
            return nRet;
        }

        // -------------------------------------------------------------
        // Event 
        // -------------------------------------------------------------
        EventData EData;
        DEvents CurDEvents = new DEvents();
        DEvents NextDEvents = new DEvents();
        List<DEvent> CurEvents = new List<DEvent>();
          
        //List<DEvent> EventsToday = new List<DEvent>();

        // --- Initialize ---
        private void LoadEvent()
        {
            EData = EventData.GetData();
            LoadCurEvents();
            //CurEvents.Add(new DEvent());
            //PrevEvent();
            //NextEvent();
        }

        private void FormClearEvent()
        {
            dataGridViewEvent.Rows.Clear();
        }

        private void LoadCurEvents()
        {
            LoadCurEventList();
            CurDEvents = new DEvents();
            CurDEvents.Date = dateTimePicker1.Value.Date;
            NextDEvents = new DEvents();
            NextDEvents.Date = dateTimePicker1.Value.AddDays(1).Date;
            foreach (var evs in EData.EventList.EventList)
            {
                if (evs.Date == dateTimePicker1.Value.Date)
                {
                    CurDEvents = evs;
                }
                else if (evs.Date == dateTimePicker1.Value.AddDays(1).Date)
                {
                    NextDEvents = evs;
                }
            }
            
            LoadListDEvent(CurDEvents.Plans, dataGridViewCurPlan);
            LoadListDEvent(CurDEvents.Items, dataGridViewCurResult);
            LoadListDEvent(NextDEvents.Plans, dataGridViewNextPlan);
        }

        private void LoadListDEvent(List<DEvent> ListDEvent, DataGridView DGV)
        {
            DGV.Columns.Clear();
            BindingSource bs = new BindingSource();
            bs.DataSource = ListDEvent;
            DGV.DataSource = bs;
            DGV.Columns["Content"].FillWeight = 200;
            DGV.Columns["StartTime"].Visible = false;
            DGV.Columns["EndTime"].Visible = false;
            DGV.Columns["Description"].FillWeight = 200;
            DGV.Refresh();
        }

        private void LoadCurEventList()
        {
            CurEvents.Clear();
            DEvents DEvsToday = null;
            foreach (var evs in EData.EventList.EventList)
            {
                if (evs.Date >= new DateTime(dateTimePicker1.Value.Year, dateTimePicker1.Value.Month, 1)
                    && evs.Date <= dateTimePicker1.Value)
                {
                    foreach (DEvent ev in evs.Items)
                    {
                        bool exist = false;
                        foreach (DEvent curEv in CurEvents)
                        {
                            if (curEv.Content == ev.Content)
                            {
                                ev.Duration = curEv.Duration + 1;
                                if (string.IsNullOrEmpty(ev.Status) && !string.IsNullOrEmpty(curEv.Status))
                                    ev.Status = curEv.Status;
                                CurEvents.Remove(curEv);
                                CurEvents.Insert(0, ev);
                                exist = true;
                                break;
                            }
                        }
                        if (!exist)
                        {
                            ev.Duration = 1;
                            CurEvents.Insert(0, ev);
                        }
                    }
                }

                if (evs.Date == dateTimePicker1.Value)
                {
                    DEvsToday = evs;
                }
            }
            dataGridViewEvent.Columns.Clear();
            BindingSource bs = new BindingSource();
            bs.DataSource = CurEvents;
            dataGridViewEvent.DataSource = bs;
            dataGridViewEvent.Columns["Content"].FillWeight = 200;
            dataGridViewEvent.Columns["StartTime"].Visible = false;
            dataGridViewEvent.Columns["EndTime"].Visible = false;
            dataGridViewEvent.Columns["Description"].Visible = false;
            dataGridViewEvent.Refresh();

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
            dataGridViewEvent.Columns["Content"].FillWeight = 200;
            dataGridViewEvent.Columns["StartTime"].Visible = false;
            dataGridViewEvent.Columns["EndTime"].Visible = false;
            dataGridViewEvent.Columns["Description"].Visible = false;
            dataGridViewEvent.Refresh();
        }


        // --- Event ---
        private void SaveEvent()
        {
            //if (CheckVaildEvent() == false)
            //{
            //    return;
            //}

            DEvents CurDEvs = null;
            DEvents NextDEvs = null;
            foreach (var evs in EData.EventList.EventList)
            {
                if (evs.Date == dateTimePicker1.Value.Date)
                {
                    CurDEvs = evs;
                }
                else if (evs.Date == dateTimePicker1.Value.AddDays(1).Date)
                {
                    NextDEvs = evs;
                }
            }
            if (CurDEvs == null)
            {
                int curDiaryIndex = EData.EventList.EventList.Count;
                for (int i = 0; i < EData.EventList.EventList.Count; i++)
                {
                    if (dateTimePicker1.Value < EData.EventList.EventList[i].Date)
                    {
                        curDiaryIndex = i;
                        break;
                    }
                }
                EData.EventList.EventList.Insert(curDiaryIndex, CurDEvents);
            }
            if (NextDEvs == null)
            {
                int nextDiaryIndex = EData.EventList.EventList.Count;
                for (int i = 0; i < EData.EventList.EventList.Count; i++)
                {
                    if (dateTimePicker1.Value.AddDays(1).Date < EData.EventList.EventList[i].Date)
                    {
                        nextDiaryIndex = i;
                        break;
                    }
                }
                EData.EventList.EventList.Insert(nextDiaryIndex, NextDEvents);
            }

            foreach (var ev in CurDEvents.Items)
            {
                if (ev.Status != "")
                {
                    int statusCode = Convert.ToInt32(DConvert.ToDoble(ev.Status));
                    switch (statusCode)
                    {
                        case -1:
                            ev.Status = "放弃";
                            break;
                        case 0:
                            break;
                        case 1:
                            ev.Status = "完成";
                            break;
                        default:
                            ev.Status = statusCode.ToString() + "%";
                            break;
                    }
                }

            }


            EData.Save(EData.EventList);

            //SaveListDEvent(CurDEvents.Plans, dataGridViewCurPlan);
            //SaveListDEvent(CurDEvents.Items, dataGridViewCurResult);
            //SaveListDEvent(NextDEvents.Plans, dataGridViewNextPlan);            
            LoadCurEvents();
            //dataGridViewEvent.Sort(dataGridViewEvent.Columns[3], ListSortDirection.Ascending);
            //FormClearEvent();

        }

        private void SaveListDEvent(List<DEvent> ListDEvent, DataGridView DGV)
        {
            DEvents CurEvs = new DEvents();
            DEvents PreEvs = null;
            foreach (var evs in EData.EventList.EventList)
            {
                if (evs.Date == dateTimePicker1.Value.Date)
                {
                    CurEvs = evs;
                    PreEvs = new DEvents();
                    PreEvs.Date = evs.Date;
                    foreach (DEvent itr in evs.Items)
                    {
                        PreEvs.Items.Add(itr);
                    }
                    break;
                }
            }

            CurEvs.Date = dateTimePicker1.Value;
            CurEvs.Items.Clear();
            for (int i = 0; i < dataGridViewEvent.SelectedRows.Count; i++)
            {
                string eventName = dataGridViewEvent.SelectedRows[i].Cells[0].Value.ToString();
                // EventData in DataSource
                DEvent ev = null;
                foreach (var itr in CurEvents)
                {
                    if (itr.Content == eventName)
                    {
                        //ev = itr;
                        ev = new DEvent(itr.Content, itr.Duration, itr.StartTime, itr.EndTime);
                        if (ev.StartTime > dateTimePicker1.Value || ev.StartTime == null || ev.StartTime == DateTime.MinValue)
                            ev.StartTime = dateTimePicker1.Value;

                        if (ev.EndTime < dateTimePicker1.Value || ev.EndTime == null || ev.EndTime == DateTime.MinValue)
                            ev.EndTime = dateTimePicker1.Value;
                        break;
                    }
                }

                if (ev == null)
                    continue;

                // EventData in xml
                DEvent PreEv = null;
                if (PreEvs != null)
                {
                    foreach (var itr in PreEvs.Items)
                    {
                        if (itr.Content == eventName)
                        {
                            PreEv = itr;
                            break;
                        }
                    }
                }

                if (PreEv == null)
                {
                    if (ev.StartTime > dateTimePicker1.Value || ev.StartTime == null || ev.StartTime == DateTime.MinValue)
                        ev.StartTime = dateTimePicker1.Value;

                    if (ev.EndTime < dateTimePicker1.Value || ev.EndTime == null || ev.EndTime == DateTime.MinValue)
                        ev.EndTime = dateTimePicker1.Value;

                    ev.Duration += 1;
                }
                CurEvs.Items.Add(ev);
            }

            if (PreEvs == null)
            {
                int curDiaryIndex = EData.EventList.EventList.Count;
                for (int i = 0; i < EData.EventList.EventList.Count; i++)
                {
                    if (dateTimePicker1.Value < EData.EventList.EventList[i].Date)
                    {
                        curDiaryIndex = i;
                        break;
                    }
                }
                EData.EventList.EventList.Insert(curDiaryIndex, CurEvs);
            }

            EData.Save(EData.EventList);
        
        }

        private void UpdateEventListDataForDate()
        {
            Dictionary<string, DEvent> CountMap = new Dictionary<string, DEvent>();
            DateTime tmpMonthStart = DateTime.MinValue;
            foreach (var evs in EData.EventList.EventList)
            {
                if (evs.Date >= tmpMonthStart)
                {
                    tmpMonthStart = new DateTime(evs.Date.Year, evs.Date.Month + 1, 1);
                    CountMap.Clear();
                }
                foreach (DEvent itr in evs.Items)
                {
                    DEvent d;
                    if(CountMap.ContainsKey(itr.Content))
                    {
                        d = CountMap[itr.Content];
                        d.Duration++;
                        if (d.StartTime > itr.StartTime) d.StartTime = itr.StartTime;
                        if (d.EndTime < itr.EndTime) d.EndTime = itr.EndTime;
                        if (!string.IsNullOrEmpty(itr.Description)) d.Description = itr.Description;
                        if (itr.Planned != 0.0) d.Planned = itr.Planned;
                        if (!string.IsNullOrEmpty(itr.Status)) d.Status = itr.Status;
                    }
                    else
                    {
                        CountMap[itr.Content] = new DEvent();
                        d = CountMap[itr.Content];
                        d.Duration = 1;
                        d.StartTime = itr.StartTime;
                        d.EndTime = itr.EndTime;
                        d.Description = itr.Description;
                        d.Planned = itr.Planned;
                        d.Status = itr.Status;
                    }

                    itr.Duration = d.Duration;
                    itr.StartTime = d.StartTime;
                    itr.EndTime = d.EndTime;
                    itr.Description = d.Description;
                    itr.Planned = d.Planned;
                    if (itr.Planned == 0.0)
                    {
                        itr.Planned = 1.0;
                    } 
                    itr.Status = d.Status;
                    if (string.IsNullOrEmpty(itr.Status))
                    {
                        if (evs.Date.Date <= System.DateTime.Today.AddDays(-7))
                        {
                            if (itr.Duration >= itr.Planned)
                            {
                                itr.Status = "完成";
                            }
                            else
                            {
                                itr.Status = "放弃";
                            }
                        }                   
                    }

                }
            }
        }

        private void PrevEvent()
        {
            try
            {
                LoadCurEvents();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void NextEvent()
        {
            try
            {
                LoadCurEvents();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private bool CheckVaildEvent()
        {
            bool nRet = false;
            //if(dataGridViewEvent.SelectedRows != null) return true;
            return nRet;
        }

        private void dataGridViewEvent_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewEvent.SelectedRows.Count == 1)
            {
                if (dataGridViewEvent.SelectedRows[0].Index == dataGridViewEvent.Rows.Count - 1)
                {
                    CurEvents.Add( new DEvent());
                }
                
            }

        }

        private void buttonLToTPlan_Click(object sender, EventArgs e)
        {
            AddSelectedEventsToListDEvent(dataGridViewCurPlan, CurDEvents.Plans, dataGridViewEvent, CurEvents);
        }

        private void buttonLToTResult_Click(object sender, EventArgs e)
        {
            AddSelectedEventsToListDEvent(dataGridViewCurResult, CurDEvents.Items, dataGridViewEvent, CurEvents);
        }

        private void buttonLToMPlan_Click(object sender, EventArgs e)
        {
            AddSelectedEventsToListDEvent(dataGridViewNextPlan, NextDEvents.Plans, dataGridViewEvent, CurEvents);
        }

        private void buttonTPToTResult_Click(object sender, EventArgs e)
        {
            AddSelectedEventsToListDEvent(dataGridViewCurResult, CurDEvents.Items, dataGridViewCurPlan, CurDEvents.Plans);
        }

        private void buttonTPToMPlan_Click(object sender, EventArgs e)
        {
            AddSelectedEventsToListDEvent(dataGridViewNextPlan, NextDEvents.Plans, dataGridViewCurPlan, CurDEvents.Plans);
        }

        private void buttonTRToMPlan_Click(object sender, EventArgs e)
        {
            AddSelectedEventsToListDEvent(dataGridViewNextPlan, NextDEvents.Plans, dataGridViewCurResult, CurDEvents.Items);
        }

        private void AddSelectedEventsToListDEvent(DataGridView TargetDGV, List<DEvent> TargetListDEvent, DataGridView DGV, List<DEvent> DGVListDEvent)
        {
            for (int i = 0; i < DGV.SelectedRows.Count; i++)
            {
                string eventName = DGV.SelectedRows[i].Cells[0].Value.ToString();
                if (eventName == "") continue;
                foreach (var itr in DGVListDEvent)
                {
                    if (itr.Content == eventName)
                    {
                        bool exist = false;
                        foreach (var evt in TargetListDEvent)
                        {
                            if (evt.Content == itr.Content)
                            {
                                exist = true;
                                break;
                            }
                        }
                        if (!exist)
                            TargetListDEvent.Add(itr);
                        break;
                    }
                }
            }

            BindListDEventToDGV(TargetListDEvent, TargetDGV, 00);

        }

        private void BindListDEventToDGV(List<DEvent> ListDEvent, DataGridView DGV, int mode)
        {
            switch(mode)
            {
                case 0:
                    {
                        DGV.Columns.Clear();
                        BindingSource bs = new BindingSource();
                        bs.DataSource = ListDEvent;
                        DGV.DataSource = bs;
                        DGV.Refresh();
                    }
                    break;
                case 1:
                    {
                        DGV.Columns.Clear();
                        BindingSource bs = new BindingSource();
                        bs.DataSource = ListDEvent;
                        DGV.DataSource = bs;
                        DGV.Columns["StartTime"].Visible = false;
                        DGV.Columns["EndTime"].Visible = false;
                        DGV.Columns["Description"].Visible = false;
                        DGV.Refresh();
                    }
                    break;
                default:
                    break;

            }
    
        }

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
                //CurTimeTable.Date = dateTimePicker1.Value;
                //CurTimeTable.Columns.Clear();
                CurTimeTable = null;
                foreach (var ctb in TBData.TimeTable.Items)
                {
                    if (ctb.Date == dateTimePicker1.Value)
                    {
                        CurTimeTable = ctb;
                        break;
                    }
                }
                if (CurTimeTable == null)
                {
                    CurTimeTable = new DTimeTableItem();
                    CurTimeTable.Date = dateTimePicker1.Value;
                }
                foreach (var col in CurTimeTable.Columns)
                {
                    foreach (Control c in TimeTable.Controls)
                    {
                        if (c is TextBox 
                            && c.Name == col.Name)
                        {
                            if(((TextBox)c).ReadOnly == false)
                                c.Text = col.Duration.ToString();
                        }
                    }

                    //((TextBox)(TimeTable.Find(col.Name, false)[0])).Text = col.Duration.ToString();
                }
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
        private void SaveTimeTable()
        {
            if (CheckVaildTimeTable() == false)
            {
                MessageBox.Show("Invalid TimeTable data.");
                return;
            }

            bool exist = false;
            foreach (var ctb in TBData.TimeTable.Items)
            {
                if (ctb.Date == dateTimePicker1.Value)
                {
                    CurTimeTable = ctb;
                    exist = true;
                    break;
                }
            }
            if (!exist)
            {
                int curDiaryIndex = TBData.TimeTable.Items.Count;
                for (int i = 0; i < TBData.TimeTable.Items.Count; i++)
                {
                    if (dateTimePicker1.Value < TBData.TimeTable.Items[i].Date)
                    {
                        curDiaryIndex = i;
                        break;
                    }
                }
                TBData.TimeTable.Items.Insert(curDiaryIndex, CurTimeTable);
            }

            foreach (Control c in TimeTable.Controls)
            {
                if (c is TextBox)
                {
                    bool existCol = false;
                    foreach (var itr in CurTimeTable.Columns)
                    {
                        if (itr.Name == c.Name)
                        {
                            try { itr.Duration = Convert.ToDouble(c.Text); }
                            catch (Exception ex) { itr.Duration = 0; ex.ToString(); }
                            if (itr.Duration == 0)
                            {
                                c.Text = "";
                                CurTimeTable.Columns.Remove(itr);
                            }
                            existCol = true;
                            break;
                        }
                    }
                    if (!existCol)
                    {
                        DTimeTableColumn col = new DTimeTableColumn();
                        col.Name = c.Name;
                        try { col.Duration = Convert.ToDouble(c.Text); }
                        catch (Exception ex) { col.Duration = 0; ex.ToString(); }
                        if (col.Duration != 0)
                        {
                            CurTimeTable.Columns.Add(col);
                        }
                        else
                        {
                            c.Text = "";
                        }
                    }
                }
            }
            CurTimeTable.Date = dateTimePicker1.Value.Date;
            TBData.Save(TBData.TimeTable);
        }

        private void PrevTimeTable()
        {
            FormClearTimeTable();
            LoadCurTimeTable();
        }

        private void NextTimeTable()
        {
            FormClearTimeTable();
            LoadCurTimeTable();
        }

        private bool CheckVaildTimeTable()
        {
            bool nRet = true;

            return nRet;
        }

        private void TimeTable_TextChanged(object sender, EventArgs e)
        {
            try
            {
                TextBox s = ((TextBox)sender);
                double d = 0.0;
                switch (s.Name)
                { 
                    case "business":
                    case "note":
                    case "project":
                    case "language":
                    case "fantasy":
                        d += DConvert.ToDoble(business.Text);
                        d += DConvert.ToDoble(note.Text);
                        d += DConvert.ToDoble(project.Text);
                        d += DConvert.ToDoble(language.Text);
                        d += DConvert.ToDoble(fantasy.Text);
                        work.Text = Convert.ToString(d);
                        break;
                    case "live":
                    case "sleep":
                    case "communication":
                    case "discipline":
                    case "exercise":
                        d += DConvert.ToDoble(live.Text);
                        d += DConvert.ToDoble(sleep.Text);
                        d += DConvert.ToDoble(communication.Text);
                        d += DConvert.ToDoble(discipline.Text);
                        d += DConvert.ToDoble(exercise.Text);
                        life.Text = Convert.ToString(d);
                        break;
                    case "book":
                    case "animation":
                    case "game":
                    case "movie":
                    case "ero":
                        d += DConvert.ToDoble(book.Text);
                        d += DConvert.ToDoble(animation.Text);
                        d += DConvert.ToDoble(game.Text);
                        d += DConvert.ToDoble(ero.Text);
                        d += DConvert.ToDoble(movie.Text);
                        play.Text = Convert.ToString(d);
                        break;

                }
                double w = DConvert.ToDoble(work.Text);
                double l = DConvert.ToDoble(life.Text);
                double p = DConvert.ToDoble(play.Text);
                total.Text = Convert.ToString(w + l + p);
                workLabel.Text = Convert.ToString( Convert.ToInt32(w / 24 * 100) ) + "%";
                lifeLabel.Text = Convert.ToString( Convert.ToInt32(l / 24 * 100) ) + "%";
                playLabel.Text = Convert.ToString( Convert.ToInt32(p / 24 * 100) ) + "%";
                totalLabel.Text = Convert.ToString( Convert.ToInt32((w + l + p) / 24.0 * 100 )) + "%";
            }
            catch { }
            
        }

        private void UpdateTimeTableDataForDate()
        {
            foreach (var TB in TBData.TimeTable.Items)
            {
                for (int i = 0; i < TB.Columns.Count; i++ )
                {
                    if (TB.Columns[i].Duration == 0)
                    {
                        TB.Columns.RemoveAt(i);
                        i--;
                    }
                }
            }
            TBData.Save(TBData.TimeTable);
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

        private void ButtonUpdate_Click(object sender, EventArgs e)
        {

            //this.SaveDiary();
            DData.Diarys.Items.Sort();
            DData.Save(DData.Diarys);

            EData.EventList.EventList.Sort();
            UpdateEventListDataForDate();
            EData.Save(EData.EventList); ;
            this.LoadCurEvents();

            TBData.TimeTable.Items.Sort();
            UpdateTimeTableDataForDate();
            TBData.Save(TBData.TimeTable);
            this.LoadCurEvents();


        }


    }
}
