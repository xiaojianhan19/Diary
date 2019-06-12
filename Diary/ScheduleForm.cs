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
    public partial class ScheduleForm : Form
    {
        //DCategoryList DCategoryData;
        //DiaryData DData;
        public ScheduleForm()
        {
            //InitializeComponent();
            //DCategoryData = ShareData.GetShareData().DCategoryData;
            //DData = ShareData.GetShareData().DData;
            //LoadCategory();
        }

        //private void LoadCategory()
        //{
        //    for (int i = 0; i < DCategoryData.DCategorys.Count; i++)
        //    {
        //        DCategory DC = DCategoryData.DCategorys[i];

        //        double DDuration = 0.0;
        //        foreach(DDiary DD in DData.Diarys)
        //        {
        //            foreach (DEvent DEv in DD.Schedule.Events)
        //            {
        //                if(DEv.Category.Name == null || DC.Name == null) continue;
        //                if (DEv.Category.Name.ToUpper() == DC.Name.ToUpper())
        //                {
        //                    double dur = (DEv.Duration == 0.0) ? 2.0 : DEv.Duration;
        //                    DDuration += dur;
        //                }
        //                else if (DEv.Category.ParentName != null && DEv.Category.ParentName != "") 
        //                {
        //                    foreach(DCategory tDC in DCategoryData.DCategorys)
        //                    {
                                
        //                    }
        //                }
        //            }
        //        }

        //        //添加控件
        //        Button tBox = new Button();
        //        tBox.Text = DC.Name + ":" + DDuration;
        //        tBox.Left = 200;
        //        tBox.Top = 50 + i * 50;
        //        tBox.Width = 200;
        //        tBox.Height = 30;
        //        this.Controls.Add(tBox);          
        //    }

        //}

        //private void ToDiaryForm_Click(object sender, EventArgs e)
        //{
        //    this.Hide();
        //    DiaryForm DF = new DiaryForm();
        //    DF.ShowDialog();
        //    this.Close();
        //}

    }

}
