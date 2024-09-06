using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }


        private void buttonsave_Click(object sender, EventArgs e)
        {
            String surname = TBsurname.Text;
            String firstname = TBfirstname.Text;
            String middle = TBmiddleinitiial.Text;
            String history = results.Text;

            String month = CBmonth.Text;
            String day = CBday.Text;
            String year = CByear.Text;
            String number = TBmobile.Text;
            String email = TBemail.Text;
            String sex = "";
            if (RBmale.Checked){sex = RBmale.Text;}
            else if (RBfemale.Checked) {sex = RBfemale.Text; }
            else if (RBothers.Checked) {sex = RBothers.Text; }

            String status = "";
            if (RBsingle.Checked) { status = RBsingle.Text; }
            else if (RBmarried.Checked) { status = RBmarried.Text; }
            else if (RBnotmarried.Checked) { status = RBnotmarried.Text; }

            String region = CBregion.Text;
            String city = CBcity.Text;
            String province = CBprovince.Text;
            String street = CBstreet.Text;


            String qualifications = "";
            if (CBhsd.Checked) { qualifications = CBhsd.Text; }
            if (CBad.Checked) { qualifications = qualifications + ", " + CBad.Text; }
            if (CBmd.Checked) { qualifications = qualifications + ", " + CBmd.Text; }
            if (CBdd.Checked) { qualifications = qualifications + ", " + CBdd.Text; }
            String past = results.Text;
            results.Text = past + "\n" + surname + ", " + firstname + " " + middle + "." + "\t"
                + month + " " + day + ", " + year + "\t"
                + number + "\t"
                + email + "\t"
                + sex + "\t"
                + status + "\t"
                + region + ", " + province + ", " + city + ", " + street + "\t"
                + qualifications + "\n";
        }

        private void buttonreset_Click(object sender, EventArgs e)
        {
            TBemail.Text = string.Empty;
            TBfirstname.Text = string.Empty;
            TBsurname.Text = string.Empty;
            TBmiddleinitiial.Text = string.Empty;
            TBmobile.Text = string.Empty;

            CBregion.SelectedIndex = -1;
            CBcity.SelectedIndex = -1;
            CBprovince.SelectedIndex = -1;
            CBstreet.SelectedIndex = -1;

            CBmonth.SelectedIndex = -1;
            CBday.SelectedIndex = -1;
            CByear.SelectedIndex = -1;

            RBfemale.Checked = false;
            RBmale.Checked = false;
            RBothers.Checked = false;
            RBsingle.Checked = false;
            RBmarried.Checked = false;
            RBnotmarried.Checked = false;

            CBhsd.Checked = false;
            CBad.Checked = false;
            CBbd.Checked = false;
            CBmd.Checked = false;
            CBdd.Checked = false;

            results.Text = string.Empty;
        }

        private void RBsingle_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RBmarried_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RBnotmarried_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
