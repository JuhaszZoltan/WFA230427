using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA230427
{
    public class Item
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public bool IsDone { get; set; } = false;
        public DateTime AddDate { get; set; } = DateTime.Now;
        public DateTime Deadline { get; set; }
        public TimeSpan? PeriodOfTime { get; set; }
        public int Importance { get; set; } = 2;
    }
}
