using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignement
{
    public partial class IndataForm : Form
    {
        public IndataForm()
        {
            InitializeComponent();
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            string name = tbxName.Text;
            int daysInAdvance = (int)numDaysInAdvance.Value;
            ProductType type = new ProductType();
            List<DayOfWeek> deliveryDays = new List<DayOfWeek>();
            if (cbxMonday.Checked)
            {
                deliveryDays.Add(DayOfWeek.Monday);
            }
            if(cbxTuesday.Checked)
            {
                deliveryDays.Add(DayOfWeek.Tuesday);
            }
            if (cbxWednesday.Checked)
            {
                deliveryDays.Add(DayOfWeek.Wednesday);
            }
            if(cbxThursday.Checked)
            {
                deliveryDays.Add(DayOfWeek.Thursday);
            }
            if(cbxFriday.Checked)
            {
                deliveryDays.Add(DayOfWeek.Friday);
            }
            if (cbxSaturday.Checked)
            {
                deliveryDays.Add(DayOfWeek.Saturday);
            }
            if (cbxSunday.Checked)
            {
                deliveryDays.Add(DayOfWeek.Sunday);
            }
            
        }
        //public List<DeliveryDate> ToDeliveryDateList()
        //{

        //}
    }
}
