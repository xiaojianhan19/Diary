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
    public class DDiary : IComparable<DDiary>
    {
        public DateTime InputDateTime { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }

        //重写的CompareTo方法，根据Id排序
        public int CompareTo(DDiary other)
        {
            if (null == other)
            {
                return 1;//空值比较大，返回1
            }
            return this.InputDateTime.CompareTo(other.InputDateTime);//升序
            //return other.InputDateTime.CompareTo(this.InputDateTime);//降序
        }
    }

    public class DDiarys
    {
        public List<DDiary> Items { get; set; }
        public DDiarys() { Items = new List<DDiary>(); }
    }

    public class DiaryData
    {
        public DDiarys Diarys { get; set; }
        private string xmlPath = "Diary.xml";
        XmlSerializer XmlSerializerDDiarys;

        static private DiaryData Data;
        public static DiaryData GetData()
        {
            if (Data == null) { Data = new DiaryData(); }
            return Data;
        }

        private DiaryData()
        {
            XmlSerializerDDiarys = new XmlSerializer(typeof(DDiarys));
            LoadXml();
        }

        private void LoadXml()
        {
            //DDiary d = new DDiary();
            //d.InputDateTime = new DateTime(2019, 3, 15);
            //d.Name = "20190315";
            //d.Content = "ceshi";
            //DDiarys demo = new DDiarys();
            //demo.Items.Add(d);
            //demo.Items.Add(d);
            //Save(demo);
            //Diarys = demo;

            try
            {
                FileStream fs = new FileStream(xmlPath, FileMode.Open, FileAccess.Read);
                Diarys = (DDiarys)XmlSerializerDDiarys.Deserialize(fs);
                fs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Load xml error : " + ex.ToString());
            }
        }

        public void Save(DDiarys oData)
        {
            FileStream fs = new FileStream(xmlPath, FileMode.Truncate, FileAccess.ReadWrite);
            XmlSerializerDDiarys.Serialize(fs, oData);
            fs.Close();
        }

    }
}
