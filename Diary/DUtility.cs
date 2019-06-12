using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diary
{
    class DUtility
    {
        private DateTime dt { set; get; }
        private int day { set; get; }
        DateTime startDate = Convert.ToDateTime("2000-01-01 00:00:00");
        
        DUtility(string s) {
            dt = Convert.ToDateTime(s);
            TimeSpan ts = dt - startDate;
            day = ts.Days + 1;
        }

        DUtility(int d)
        {
            day = d;
            dt = startDate.AddDays(d);
        }
    }

    public class DConvert
    {
        public static double ToDoble(string s)
        {
            try
            {
                return Convert.ToDouble(s);
            }
            catch
            {
                return 0.0;
            }
        }
    }

    enum Day { Sun, Mon, Tue, Wed, Thu, Fri, Sat };
}
