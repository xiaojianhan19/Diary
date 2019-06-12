using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diary
{
    public partial class CollectionForm : Form
    {
        // --- Common ---
        
        public CollectionForm()
        {
            InitializeComponent();
            LoadCollection();
        }

        private void ToDiaryForm_Click(object sender, EventArgs e)
        {
            this.Hide();
            DiaryForm f = new DiaryForm();
            f.ShowDialog();
            this.Close();
        }

        private void ToCSummaryForm_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //CSummaryForm f = new CSummaryForm();
            //f.ShowDialog();
            //this.Close();
        }

        // -------------------------------------------------------------
        // Collection 
        // -------------------------------------------------------------
        CollectionData CData;
        List<DCollectionItem> CurList = new List<DCollectionItem>();
        // --- Initialize ---
        private void LoadCollection()
        {
            CData = CollectionData.GetData();
            LoadCurCollectionList();
            //CurEvents.Add(new DEvent());
            //PrevEvent();
            //NextEvent();
        }

        Random rnd = new Random();
        private void LoadCurCollectionList()
        {
            CurList = CData.CollectionList.List.FirstOrDefault();
            for (int i = 0; i < 100; i++)
            {
                CurList.Add(new DCollectionItem("Ani" + i.ToString(), 1, rnd.Next(8)));
            
            }

            displayCurCollectionList();
        }


        // Display
        int topInit = 50;
        int leftInit = 50;
        int heiInc = 50;
        int widInc = 50;
        Dictionary<int, Dictionary<Point, int>> containerMap = new Dictionary<int, Dictionary<Point, int>>();
        int containerWidth = 32;
        int containerHeight = 4;
        int lastContainIndex = -1;
        
        private void displayCurCollectionList()
        {
            Label labelBack = new Label();
            labelBack.Width = 1600 + 10;
            labelBack.Height = 800 + 5;
            labelBack.Top = topInit - 5;
            labelBack.Left = leftInit - 5;
            labelBack.BackColor = Color.WhiteSmoke;
            labelBack.BorderStyle = BorderStyle.FixedSingle;
            this.Controls.Add(labelBack);
            labelBack.SendToBack();

            foreach (var item in CurList)
            {
                Point pSize = GetSizeByLevel(item.Level);               
                Button itemBtn = new Button();
                itemBtn.Width = pSize.X * widInc;
                itemBtn.Height = pSize.Y * heiInc;
                itemBtn.BackColor = GetColorByLevel(item.Level);
                itemBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                itemBtn.Font = GetFondByLevel(item.Level);
                itemBtn.Text = item.Name;
                //itemBtn.Select();
                itemBtn.Click += new System.EventHandler(this.ItemSelect_Click);

                Point pos = SearchAndSetPoint(pSize);
                itemBtn.Top = topInit + pos.Y * heiInc;
                itemBtn.Left = leftInit + pos.X * widInc;
                this.Controls.Add(itemBtn);
                itemBtn.BringToFront();

                if(itemBtn.Top + itemBtn.Height + 10 > labelBack.Height )
                    labelBack.Height = itemBtn.Top + itemBtn.Height + 10;

            }


        }

        private Point GetSizeByLevel(int level)
        {
            switch (level)
            { 
                case 7:
                    return new Point(4, 4);
                case 6:
                    return new Point(4, 3);
                case 5:
                    return new Point(4, 2);
                case 4:
                    return new Point(4, 2);
                case 3:
                    return new Point(4, 1);
                case 2:
                    return new Point(4, 1);
            }

            return new Point(4, 1);
        }

        List<Font> fondList = new List<Font>();
        private Font GetFondByLevel(int level)
        {
            if(fondList.Count == 0)
            {
                for(int i=0; i < 10; i++)
                {
                    Font f = new System.Drawing.Font("宋体", 8 + i * 2, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 128);
                    fondList.Add(f);
                }
            }

            //字体逐渐增大
            //if (level > 0 && level <= fondList.Count)
            //    return fondList[level -1];

            //选择字体
            switch (level)
            {
                case 7:
                    return fondList[9];
                case 6:
                    return fondList[7];
                case 5:
                    return fondList[4];
                case 4:
                    return fondList[4];
                case 3:
                    return fondList[2];
                case 2:
                    return fondList[2];
                default:
                    return fondList[2];
            }
            //return fondList[0];
        }

        private Color GetColorByLevel(int level)
        {
            switch (level)
            {
                case 7:
                    return Color.Red;
                case 6:
                    return Color.DeepPink;
                case 5:
                    return Color.Orange;
                case 4:
                    return Color.Yellow;
                case 3:
                    return Color.LightBlue;
                case 2:
                    return Color.LightGreen;
            }

            return Color.White;
        }

        private Point SearchAndSetPoint(Point size)
        { 
            Point tgtPt = new Point(-1, -1);
            Point endPt = new Point(-1, -1);
            foreach(var container in containerMap)
            {
                if(container.Key < lastContainIndex)
                    continue;
                foreach (var pt in container.Value.Keys)
                {
                    Dictionary<Point, int> cont = container.Value;
                    if (cont[pt] == 0)
                    {
                        bool available = true;
                        for (int x = 0; x < size.X; x++ )
                        {
                            for (int y = 0; y < size.Y; y++)
                            {
                                if (pt.Y + y >= (lastContainIndex + 1) * containerHeight)
                                {
                                    available = false;
                                }
                                else if (pt.X + x >= containerWidth)
                                {
                                    available = false;
                                }
                                else if (cont[new Point(pt.X + x, pt.Y + y)] == 1)
                                {
                                    available = false;
                                }                           
                            }
                        }
                        if (!available)
                            continue;
                        
                        for (int y = 0; y < size.Y; y++)
                        {
                            //物品左侧位置可以放置
                            for (int x = 0; x < size.X; x++)
                            {
                                cont[new Point(pt.X + x, pt.Y + y)] = 1;
                            }

                            ////物品左侧位置设置为不能放置
                            //for (int x = 0; x < pt.X + size.X; x++)
                            //{
                            //    cont[new Point(x, pt.Y + y)] = 1;
                            //}
                        }

                        tgtPt = pt;
                        break;
                    }
                }
            }

            if (tgtPt == new Point(-1, -1))
            {
                lastContainIndex++;
                Dictionary<Point, int> container = new Dictionary<Point, int>();
                for (int x = 0; x < containerWidth; x++)
                {
                    for (int y = lastContainIndex * containerHeight; y < (lastContainIndex + 1) * containerHeight; y++)
                    {
                        if( x < size.X && y < size.Y + lastContainIndex * containerHeight)
                            container[new Point(x, y)] = 1;
                        else
                            container[new Point(x, y)] = 0;
                    }
                }
                containerMap.Add(lastContainIndex, container);
                tgtPt = new Point(0, lastContainIndex * containerHeight);
            }

            return tgtPt;
        }

        /// <summary>
        /// 单选
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LevelCheckedListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (LevelCheckedListBox.CheckedItems.Count > 0)
            {
                for (int i = 0; i < LevelCheckedListBox.Items.Count; i++)
                {
                    if (i != e.Index)
                    {
                        this.LevelCheckedListBox.SetItemCheckState(i, System.Windows.Forms.CheckState.Unchecked);
                    }
                }
            }
        }

        private void ItemSelect_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            DCollectionItem item = null;
            for(int i=0;i<CurList.Count;i++)
            {
                if(CurList[i].Name == btn.Text)
                {
                    item = CurList[i];
                
                }
            
            }

            if(item != null)
            {
                CollectionName.Text = item.Name;
                CollectionType.Text = item.Type.ToString() ;
                LevelCheckedListBox.SelectedIndex = (item.Level == 0) ? 0 : item.Level - 1;
                InputTime.Text = item.InputDateTime.ToShortDateString();
                RealeaseTime.Text = item.ReleaseDateTime.ToShortDateString();
            }
        }

    }
}
