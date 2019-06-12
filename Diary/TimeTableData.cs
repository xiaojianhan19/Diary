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
    public class DTimeTableColumn
    {
        public string Name { get; set; } 
        public double Duration { get; set; }
        public DTimeTableColumn() {}
        public DTimeTableColumn(string Name, double Duration)
        {
            this.Name = Name;
            this.Duration = Duration;
        }
    }

    public class DTimeTableItem : IComparable<DTimeTableItem>
    {
        public DateTime Date { get; set; } 
        public List<DTimeTableColumn> Columns;
        public DTimeTableItem() { Columns = new List<DTimeTableColumn>(); }

        //重写的CompareTo方法，根据Id排序
        public int CompareTo(DTimeTableItem other)
        {
            if (null == other)
            {
                return 1;//空值比较大，返回1
            }
            return this.Date.CompareTo(other.Date);//升序
            //return other.Date.CompareTo(this.Date);//降序
        }
    }

    public class DTimeTable
    {
        public List<DTimeTableItem> Items { get; set; }
        public DTimeTable() { Items = new List<DTimeTableItem>(); }
    }

    public class TimeTableData
    {
        public DTimeTable TimeTable { get; set; }
        private string xmlPath = "TimeTable.xml";
        XmlSerializer XmlSerializer;

        static private TimeTableData Data;
        public static TimeTableData GetData()
        {
            if (Data == null) { Data = new TimeTableData(); }
            return Data;
        }

        private TimeTableData()
        {
            XmlSerializer = new XmlSerializer(typeof(DTimeTable));
            LoadXml();
        }

        private void LoadXml()
        {
            //DTimeTable demo = new DTimeTable();
            //DTimeTableItem item = new DTimeTableItem();
            //item.Name = "20190315";
            //DTimeTableColumn d1 = new DTimeTableColumn("work", "textBoxS1", 4);
            //item.Columns.Add(d1);
            //DTimeTableColumn d2 = new DTimeTableColumn("work", "textBoxS2", 4);
            //item.Columns.Add(d2);
            //DTimeTableColumn d3 = new DTimeTableColumn("work", "textBoxS3", 4);
            //item.Columns.Add(d3);
            //DTimeTableColumn d4 = new DTimeTableColumn("work", "textBoxS4", 4);
            //item.Columns.Add(d4);
            //DTimeTableColumn d11 = new DTimeTableColumn("business", "textBoxD11", 1);
            //item.Columns.Add(d11);
            //DTimeTableColumn d12 = new DTimeTableColumn("porject", "textBoxD12", 1);
            //item.Columns.Add(d12);
            //demo.Items.Add(item);
            //Save(demo);

            try
            {
                FileStream fs = new FileStream(xmlPath, FileMode.Open, FileAccess.Read);
                TimeTable = (DTimeTable)XmlSerializer.Deserialize(fs);
                fs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Load xml error : " + ex.ToString());
            }
        }

        public void Save(DTimeTable oData)
        {
            FileStream fs = new FileStream(xmlPath, FileMode.Truncate, FileAccess.ReadWrite);
            XmlSerializer.Serialize(fs, oData);
            fs.Close();
        }

    }
}
