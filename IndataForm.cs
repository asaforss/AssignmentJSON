using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Text.RegularExpressions;

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

            string postalCode = tbxPostalCode.Text;
            bool postalCodeIsCorrect = CheckPostalCode(postalCode);
            if(!postalCodeIsCorrect)
                return;

            Productlist product = makeProduct();
            if (product != null)
            {
                //this.Hide();
                Methods methods = new Methods();
                OutputForm outForm = new OutputForm();
                outForm.Show();

                StringBuilder sb = new StringBuilder($"Id: {product.Id} Name: {product.Name} JSON: \n", 100);

                List<DeliveryDate> availableDates = methods.ToDeliveryDateList(postalCode, product);

                if (availableDates.Count > 0)
                {

                    sb.Append("{\n\"status\":success,\n \"data\":{\n deliveryDates");

                    sb.Append(methods.ToJson(availableDates) + "\n");
                    sb.Append("}\n}");
                    outForm.rtbxOutput.Text = sb.ToString();
                }
                else
                    outForm.rtbxOutput.Text = "No avalible dates";
                //}
            }
        }
        private bool CheckPostalCode(string postalCode)
        {

            Match result = Regex.Match(postalCode, @"([0-9]{5})");
            if (!result.Success)
            {
                lblErrorMessage.BackColor = Color.PaleGoldenrod;
                lblErrorMessage.Text = "You have to give a proper postal code: 5 digits";

            }
            return result.Success;

        }

        private Productlist makeProduct()
        {
            string name = tbxName.Text;
            int daysInAdvance = (int)numDaysInAdvance.Value;
            ProductType type = new ProductType();

            if (rbnNormal.Checked)
                type = ProductType.Normal;
            else if (rbnTemporary.Checked)
                type = ProductType.Temporary;
            else if (rbnExternal.Checked)
                type = ProductType.External;
            List<DayOfWeek> deliveryDays = new List<DayOfWeek>();
            if (cbxMonday.Checked)
            {
                deliveryDays.Add(DayOfWeek.Monday);
            }
            if (cbxTuesday.Checked)
            {
                deliveryDays.Add(DayOfWeek.Tuesday);
            }
            if (cbxWednesday.Checked)
            {
                deliveryDays.Add(DayOfWeek.Wednesday);
            }
            if (cbxThursday.Checked)
            {
                deliveryDays.Add(DayOfWeek.Thursday);
            }
            if (cbxFriday.Checked)
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

            lblErrorMessage.Text = "";
            if (deliveryDays.Count == 0 || name == "")
            {
                lblErrorMessage.BackColor = Color.PaleGoldenrod;
                lblErrorMessage.Text = "You have to enter all data for the productlist";
                return null;
            }
            return new Productlist(name, daysInAdvance, type, deliveryDays);

        }


        private void RbnExternal_CheckedChanged(object sender, EventArgs e)
        {
            if (rbnExternal.Checked)
            {
                //All external products need to be ordered 5 days in advance.
                numDaysInAdvance.Value = 5;

            }
        }

        private void NumDaysInAdvance_ValueChanged(object sender, EventArgs e)
        {
            if (rbnExternal.Checked)
            {
                //All external products need to be ordered 5 days in advance. 
                numDaysInAdvance.Value = 5;
            }
        }

        private void RbnNormal_CheckedChanged(object sender, EventArgs e)
        {
            if (rbnNormal.Checked)
            {
                numDaysInAdvance.Value = 0;
            }
        }

        private void RbnTemporary_CheckedChanged(object sender, EventArgs e)
        {
            if (rbnTemporary.Checked)
            {
                numDaysInAdvance.Value = 0;
            }
        }
    }
}

