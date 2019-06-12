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
    public class DEvent
    {
        public string Content { get; set; }
        public double Duration { get; set; }
        public double Planned { get; set; }
        public string Status { get; set; }
        //public DateTime Time { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        //public double DurationHour { get; set; }
        //public int Level { get; set; }
        public string Description { get; set; }
        
        public DEvent() { }
        public DEvent(string Content, double Duration, DateTime StartTime, DateTime EndTime)
        {
            this.Content = Content;
            this.Duration = Duration;
            this.StartTime = StartTime;
            this.EndTime = EndTime;
        }

        public DEvent(string Content, double Duration, double Planned, string Status, DateTime StartTime, DateTime EndTime, string Description)
        {
            this.Content = Content;
            this.Duration = Duration;
            this.Planned = Planned;
            this.Status = Status;
            this.StartTime = StartTime;
            this.EndTime = EndTime;
            this.Description = Description;
        }
    }

    public class DEvents : IComparable<DEvents>
    {
        public DateTime Date { get; set; }
        public List<DEvent> Items { get; set; }
        public List<DEvent> Plans { get; set; }
        //public List<DEvent> PlansNext { get; set; }
        public DEvents() { Items = new List<DEvent>(); Plans = new List<DEvent>(); }

        //重写的CompareTo方法，根据Id排序
        public int CompareTo(DEvents other)
        {
            if (null == other)
            {
                return 1;//空值比较大，返回1
            }
            return this.Date.CompareTo(other.Date);//升序
            //return other.Date.CompareTo(this.Date);//降序
        }
    }

    public class DEventList
    {
        public List<DEvents> EventList { get; set; }
        public DEventList() { EventList = new List<DEvents>(); }
    }

    public class EventData
    {
        public DEventList EventList { get; set; }
        private string xmlPath = "Event.xml";
        XmlSerializer XmlSerializer;
        public int LastAutoId = 1000000;

        static private EventData Data;
        public static EventData GetData()
        {
            if (Data == null) { Data = new EventData(); }
            return Data;
        }

        private EventData()
        {
            XmlSerializer = new XmlSerializer(typeof(DEventList));
            LoadXml();
        }

        private void LoadXml()
        {
            //DEventList list = new DEventList();

            //DateTime date = new DateTime(2019, 3, 15); ;
            //DEvent d = new DEvent();
            //d.StartTime = date;
            //d.EndTime = date;
            //d.Content = "Harry Potter";
            //DEvents demo = new DEvents();
            //demo.Date = date;
            //demo.Items.Add(d);

            //DEvent d2 = new DEvent();
            //d2.StartTime = date;
            //d2.EndTime = date;
            //d2.Content = "Lord of The Rings";
            //demo.Items.Add(d2);

            //list.EventList.Add(demo);
            //Save(list);

            try
            {
                FileStream fs = new FileStream(xmlPath, FileMode.Open, FileAccess.Read);
                EventList = (DEventList)XmlSerializer.Deserialize(fs);
                fs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Load xml error : " + ex.ToString());
            }
        }

        public void Save(DEventList oData)
        {
            FileStream fs = new FileStream(xmlPath, FileMode.Truncate, FileAccess.Write);
            XmlSerializer.Serialize(fs, oData);
            fs.Close();
        }

    }
}
