using System;
using System.Collections.Generic;
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
    //CollectionType:

    public class DCollectionItem
    {
        public string Name { get; set; }
        public int Type { get; set; }
        public int Level { get; set; }
        public String SeriesName { get; set; }
        public DateTime InputDateTime { get; set; }
        public DateTime ReleaseDateTime { get; set; }

        public DCollectionItem() { }
        public DCollectionItem(String Name, int Type, int Level) {
            this.Name = Name;
            this.Type = Type;
            this.Level = Level;
        }
    }

    public class DCollectionList
    {
        public List<List<DCollectionItem>> List { get; set; }
        public DCollectionList() { List = new List<List<DCollectionItem>>(); }
    }



    class CollectionData
    {
        public DCollectionList CollectionList { get; set; }
        private string xmlPath = "Collection.xml";
        XmlSerializer XmlSerializer;
        static private CollectionData Data;
        public static CollectionData GetData()
        {
            if (Data == null) { Data = new CollectionData(); }
            return Data;
        }

        private CollectionData()
        {
            XmlSerializer = new XmlSerializer(typeof(DCollectionList));
            LoadXml();
        }

        private void LoadXml()
        {
            //DCollectionList list = new DCollectionList();
            //DateTime date = new DateTime(2019, 3, 15); ;
            //DCollectionItem d = new DCollectionItem();
            //d.InputDateTime = date;
            //d.Name = "Harry Potter";
            //List<DCollectionItem> demo = new List<DCollectionItem>();
            //demo.Add(d);
            //DCollectionItem d2 = new DCollectionItem();
            //d2.InputDateTime = date;
            //d2.Name = "Gundam Seed";
            //demo.Add(d2);
            //list.List.Add(demo);
            //Save(list);

            try
            {
                FileStream fs = new FileStream(xmlPath, FileMode.Open, FileAccess.Read);
                CollectionList = (DCollectionList)XmlSerializer.Deserialize(fs);
                fs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Load xml error : " + ex.ToString());
            }
        }

        public void Save(DCollectionList oData)
        {
            FileStream fs = new FileStream(xmlPath, FileMode.Truncate, FileAccess.Write);
            XmlSerializer.Serialize(fs, oData);
            fs.Close();
        }

    }

}
