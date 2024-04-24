using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2024_1_17
{
    public partial class frmStatistics : Form
    {
        public frmStatistics()
        {
            InitializeComponent();
        }

        //dat mau neu muon
        Color pnTotalColor;
        Color pnMaleColor;
        Color pnFemaleColor;

        private void frmStatistics_Load(object sender, EventArgs e)
        {
            //get panels color
            pnTotalColor = pnTotal.BackColor;
            pnMaleColor = pnMale.BackColor;
            pnFemaleColor = pnFemale.BackColor;
            //display the values
            STUDENT student = new STUDENT();
            double total = Convert.ToDouble(student.totalStudent());
            double totalMale = Convert.ToDouble(student.totalMaleStudent());
            double totalFemale = Convert.ToDouble(student.totalFemaleStudent());
            //tinh %
            //male hoac female * 100 / totalStudent
            double totalMalePercentage = totalMale * (100 / total);
            double totalFemalePercentage = totalFemale * (100 / total);
            lblTotal.Text = ("Total Student: " + total.ToString());
            lblMale.Text = "Male: " + totalMalePercentage.ToString("0.00") + " %"; //dinh dang 2 chu so thap phan
            lblFemale.Text = "Female: " + totalFemalePercentage.ToString("0.00") + " %";

            
        }
        //thu lam viec voi mouse
        private void lblTotal_MouseEnter(object sender, EventArgs e)
        {
            lblTotal.ForeColor = pnTotalColor;
            pnTotal.BackColor = Color.White;
        }

        private void lblTotal_MouseLeave(object sender, EventArgs e)
        {
            lblTotal.ForeColor = Color.Black;
            pnTotal.BackColor = pnTotalColor;
        }

        private void lblMale_MouseEnter(object sender, EventArgs e)
        {
            lblMale.ForeColor = pnMaleColor;
            pnMale.BackColor = Color.White;
        }

        private void lblMale_MouseLeave(object sender, EventArgs e)
        {
            lblMale.ForeColor = Color.Black;
            pnMale.BackColor = pnMaleColor;
        }

        private void lblFemale_MouseEnter(object sender, EventArgs e)
        {
            lblFemale.ForeColor = pnFemaleColor;
            pnFemale.BackColor = Color.White;
        }

        private void lblFemale_MouseLeave(object sender, EventArgs e)
        {
            lblFemale.ForeColor = Color.Black;
            pnFemale.BackColor = pnFemaleColor;
        }
    }
}
