using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA230427
{
    public partial class UcItemDetails : UserControl
    {
        public UcItemDetails(Item item)
        {
            InitializeComponent();

            lblTitle.Text = item.Title;
            lblDescription.Text = item.Description;
            dtpAddDate.CustomFormat = "yyyy. MMMM dd. (dddd) - hh:mm";
            dtpAddDate.Value = item.AddDate;
            dtpDeadline.CustomFormat = "yyyy. MMMM dd. (dddd) - hh:mm";
            dtpDeadline.Value = item.Deadline;

            if (item.PeriodOfTime is not null)
            {
                nudPeriodHours.Value = item.PeriodOfTime.Value.Hours;
                nudPeriodMins.Value = item.PeriodOfTime.Value.Minutes;
            }

            pbIsDone.Image = item.IsDone
                ? Properties.Resources.check
                : Properties.Resources.cross;

            lblTitle.ForeColor = item.Importance switch
            {
                1 => Color.Green,
                2 => Color.Yellow,
                3 => Color.Red,
                _ => Color.Black,
            };
        }
    }
}
