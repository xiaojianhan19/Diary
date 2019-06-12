using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diary
{
    public class DItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Key { get; set; }
    }

    public class DCategory : DItem
    {
        public int CategoryLvl { get; set; }
        public int ParentId { get; set; }
        public string ParentName { get; set; }

        public DCategory() { CategoryLvl = 1; }
    }

}
